using HotChat.Repository.Interface;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var client = new MongoClient("");
            _db = client.GetDatabase("");
        }

        private IMongoCollection<TEntity> GetCollection()
        {
            return _db.GetCollection<TEntity>(_collectionName);
        }

        public virtual void Add(TEntity entity)
        {
            GetCollection().InsertOneAsync(entity);
        }

        public virtual void Delete(TKey key)
        {
        }

        public virtual void Update(TKey key)
        {
        }
    }
}
