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

      public virtual void Add(TEntity entity)
      {
         GetCollection().InsertOne(entity);
      }

      //public virtual void Delete(TKey key)
      //{
      //}

      //public virtual void Update(FilterDefinition<TEntity> filter, UpdateDefinition<TEntity> updater)
      //{
      //   GetCollection().FindOneAndUpdate(filter, updater);
      //}

      protected TEntity First(FilterDefinition<TEntity> filter)
      {
         return Find(filter).First();
      }

      protected IFindFluent<TEntity, TEntity> Find(FilterDefinition<TEntity> filter)
      {
         return GetCollection().Find(filter);
      }

      protected TEntity FindOneAndUpdate(FilterDefinition<TEntity> filter, UpdateDefinition<TEntity> updater)
      {
         return GetCollection().FindOneAndUpdate(filter, updater);
      }

      protected long Count(FilterDefinition<TEntity> filter)
      {
         return GetCollection().Count(filter);
      }

      protected FilterDefinition<TEntity> EqFilter<TValue>(string field, TValue value)
      { 
         return Builders<TEntity>.Filter.Eq(field, value);
      }

      protected UpdateDefinition<TEntity> PushUpdater<TValue>(string field, TValue value)
      {
         return Builders<TEntity>.Update.Push(field, value);
      }

      private IMongoCollection<TEntity> GetCollection()
      {
         return _db.GetCollection<TEntity>(_collectionName);
      }
   }
}
