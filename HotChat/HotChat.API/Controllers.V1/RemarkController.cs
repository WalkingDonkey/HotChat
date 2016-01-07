﻿using HotChat.BO;
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

      // POST api/v1/<controller>/
      [Route("")]
      [HttpPost]
      public void AddRemark(RemarkDTO remarkDTO)
      {
         _remarkService.AddRemark(remarkDTO.CourseId, remarkDTO.ToUserId, remarkDTO.Map<RemarkDTO, Remark>());
      }

      // GET api/v1/<controller>/remarks/<userId>
      [Route("remarks/{userId}/{courseId}")]
      [HttpGet]
      public RemarksDTO GetRemarks(string userId, string courseId)
      {
         RemarksBO remarksBO = _remarkService.GetRemarks(userId, courseId);
         return remarksBO.Map<RemarksBO, RemarksDTO>();
      }
   }
}