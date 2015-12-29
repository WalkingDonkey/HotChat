using HotChat.BO;
using HotChat.Common;
using HotChat.Framework.Utility;
using HotChat.PO.Mongo;
using HotChat.Repository.Interface;
using HotChat.Repository.Mongo.Abstract;
using MongoDB.Driver;

namespace HotChat.Repository.Mongo.Impl
{
   public class RemarkRepository : Repository<RemarksPO, string>, IRemarkRepository
   {
      private const string _collectionName = "Remarks";
      public RemarkRepository()
          : base(_collectionName)
      {
      }

      public void AddRemark(string userId, Remark remark)
      {
         var collection = GetCollection();
         var filter = Builders<RemarksPO>.Filter.Eq("UserId", userId);
         var updater = Builders<RemarksPO>.Update.Push("Remarks", remark);
         if (collection.Count(filter) == 0)
         {
            RemarksPO po = new RemarksPO(userId);
            po.Add(remark);
            collection.InsertOne(po);
         }
         else
         {
            collection.FindOneAndUpdate(filter, updater);
         }
      }

      public RemarksBO GetRemarks(string userId)
      {
         RemarksBO remarkBO = new RemarksBO();
         var collection = GetCollection();
         var filter = Builders<RemarksPO>.Filter.Eq("UserId", userId);
         if (collection.Count(filter) != 0)
         {
            remarkBO.Remarks = collection.Find(filter).First().Remarks;
         }

         return remarkBO;
      }
   }
}
