using HotChat.BO;
using HotChat.Common;

namespace HotChat.Service.Interface
{
   public interface IRemarkService
   {
      void AddRemark(string userId, Remark remark);
      RemarksBO GetRemarks(string userId);
   }
}
