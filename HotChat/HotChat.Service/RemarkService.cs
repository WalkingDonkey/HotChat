using HotChat.BO;
using HotChat.Common;
using HotChat.Repository.Interface;
using HotChat.Service.Interface;

namespace HotChat.Service.Impl
{
   public class RemarkService : IRemarkService
   {
      private IRemarkRepository _remarkRepository;

      public RemarkService(IRemarkRepository remarkRepository)
      {
         _remarkRepository = remarkRepository;
      }

      public void AddRemark(string userId, Remark remark)
      {
         _remarkRepository.AddRemark(userId, remark);
      }

      public RemarksBO GetRemarks(string userId)
      {
         return _remarkRepository.GetRemarks(userId);
      }
   }
}
