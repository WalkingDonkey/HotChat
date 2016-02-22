using HotChat.BO;
using HotChat.Common;
using HotChat.DTO;
using HotChat.Framework.Utility;
using HotChat.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace HotChat.API.Controllers.V1
{
   [RoutePrefix("api/v1/message")]
   public class MessageController : ApiController
   {
      public MessageController()
      {
         
      }

      // GET api/v1/<controller>/messages/<userId>
      [Route("messages/{userId}")]
      [HttpGet]
      public IEnumerable<MessageDTO> GetMessages(string userId)
      {
         // TODO: call message service
         return null;
      }
   }
}