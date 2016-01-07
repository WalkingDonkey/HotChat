using HotChat.BO;
using HotChat.Common;
using HotChat.PO.Mongo;
using HotChat.Repository.Interface;
using HotChat.Repository.Mongo.Abstract;

namespace HotChat.Repository.Mongo.Impl
{
   public class RemarkRepository : Repository<RemarksPO, string>, IRemarkRepository
   {
      private const string _collectionName = "Remarks";
      public RemarkRepository()
          : base(_collectionName)
      {
      }

      public void AddRemark(string courseId, string userId, Remark remark)
      {
         var filter = EqFilter("UserId", userId);
         var updater = PushUpdater("Remark", remark);
         if (Count(filter) == 0)
         {
            RemarksPO remarksPO = new RemarksPO(userId);
            remarksPO.Add(courseId,remark);
            Add(remarksPO);
         }
         else
         {
            FindOneAndUpdate(filter, updater);
         }
      }

      public RemarksBO GetRemarks(string userId, string courseId)
      {
         RemarksBO remarkBO = new RemarksBO();
         var filter = EqFilter("UserId", userId);
         if (Count(filter) != 0)
         {
            remarkBO.Remarks = First(filter).Course2Remarks[courseId];
         }

         return remarkBO;
      }
   }
}
