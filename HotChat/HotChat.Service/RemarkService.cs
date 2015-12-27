using HotChat.BO;
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

      public void Add(RemarkBO remarkBO)
      {
         _remarkRepository.Add(remarkBO);
      }
   }
}
