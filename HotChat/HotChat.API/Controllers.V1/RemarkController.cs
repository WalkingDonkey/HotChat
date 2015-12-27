using HotChat.BO;
using HotChat.DTO;
using HotChat.Framework.Utility;
using HotChat.Service.Interface;
using System.Collections.Generic;
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
      [Route("add")]
      public void AddRemark(RemarkDTO remarkDTO)
      {
         _remarkService.Add(remarkDTO.Map<RemarkDTO, RemarkBO>());
      }
   }
}