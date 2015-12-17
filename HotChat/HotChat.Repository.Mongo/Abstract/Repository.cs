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

        public virtual void Update(TKey key)
        {
        }
    }
}
