namespace HotChat.Repository.Interface
{
   public interface IRepository<TEntity, TKey> where TEntity : class
   {
      //IList<TEntity> GetAll();
      //IList<TEntity> GetAll(int pageIndex, int pageSize);
      //TEntity GetByID(TKey id);

      // CRUD
      void Add(TEntity entity);
      //void Delete(TKey key);
      //void Update<T1, T2>(T1 query1,T2 query2);
      //bool Exist<T>(T query);
   }
}
