using HotChat.BO;
using HotChat.DAO;
using HotChat.Framework.Utility;
using HotChat.Repository.Interface;
using HotChat.Repository.Mongo.Abstract;
using MongoDB.Driver;
using System;

namespace HotChat.Repository.Mongo.Impl
{
   public class RemarkRepository : Repository<RemarksDAO, string>, IRemarkRepository
   {
      private const string _collectionName = "Remarks";
      public RemarkRepository()
          : base(_collectionName)
      {
      }

      public void Add(RemarkBO remarkBO)
      {
         string toUserId = remarkBO.ToUserId;
         var collection = GetCollection();
         var filter = Builders<RemarksDAO>.Filter.Eq("UserId", toUserId);
         var updater = Builders<RemarksDAO>.Update.Push("Remarks", remarkBO.Map<RemarkBO, Remark>());
         if(collection.Find(filter).First() == null)
         {

         }
      }

      public bool Exist(string userId)
      {
         var collection = GetCollection();
         var filter = Builders<RemarksDAO>.Filter.Eq("UserId", userId);
         return collection.Find(filter).First() != null;
      }
   }
}
