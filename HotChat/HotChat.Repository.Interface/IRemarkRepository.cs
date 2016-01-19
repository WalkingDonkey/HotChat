using HotChat.BO;
using HotChat.Common;

namespace HotChat.Repository.Interface
{
   public interface IRemarkRepository
   {
      void AddRemark(string courseId, string userId, Remark remark);
      RemarksBO GetRemarks(string userId, string courseId);
   }
}
