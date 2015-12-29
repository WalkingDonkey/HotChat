using HotChat.BO;
using HotChat.Common;
using HotChat.DTO;
using HotChat.Framework.Utility;
using HotChat.Service.Interface;
using System.Web.Http;

namespace HotChat.API.Controllers.V1
{
   [RoutePrefix("api/v1/remark")]
   public class RemarkController : ApiController
   {
      private IRemarkService _remarkService;

      public RemarkController(IRemarkService remarkService)
      {
         _remarkService = remarkService;
      }

      // POST api/<controller>/add
      [Route("remark")]
      public void AddRemark(RemarkDTO remarkDTO)
      {
         _remarkService.AddRemark(remarkDTO.ToUserId, remarkDTO.Map<RemarkDTO, Remark>());
      }

      // GET api/<controller>/get
      [Route("remarks/{userId}")]
      public RemarksDTO GetRemarks(string userId)
      {
         RemarksBO remarksBO = _remarkService.GetRemarks(userId);
         return remarksBO.Map<RemarksBO, RemarksDTO>();
      }
   }
}