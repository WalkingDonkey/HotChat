using HotChat.Repository.Interface;
using MongoDB.Driver;

namespace HotChat.Repository.Mongo.Abstract
{
   public abstract class Repository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class
   {
      private static IMongoDatabase _db;
      private string _collectionName;

      public Repository(string collectionName)
      {
         _collectionName = collectionName;
      }

      static Repository()
      {
         var client = new MongoClient("mongodb://127.0.0.1:27017");
         _db = client.GetDatabase("HotChat");
      }

      public IMongoCollection<TEntity> GetCollection()
      {
         return _db.GetCollection<TEntity>(_collectionName);
      }

      public virtual void Add(TEntity entity)
      {
         IMongoCollection<TEntity> collection = GetCollection();
         collection.InsertOne(entity);
      }

      public virtual void Delete(TKey key)
      {
      }

      //public virtual void Update(FilterDefinition<TEntity> filter, UpdateDefinition<TEntity> updater)
      //{
      //   GetCollection().FindOneAndUpdate(filter, updater);
      //}

      public virtual bool Exist<T>(T filter)
      {
         return true;
         //return GetCollection().Count(filter) != 0;
      }

      protected FilterDefinition<TEntity> EqFilter<TValue>(string field, TValue value)
      { 
         return Builders<TEntity>.Filter.Eq(field, value);
      }

      protected UpdateDefinition<TEntity> PushUpdater<TValue>(string field, TValue value)
      {
         return Builders<TEntity>.Update.Push(field, value);
      }
   }
}
