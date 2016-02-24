namespace HotChat.API.Controllers.V1
{
   using HotChat.DTO;
   using System.Collections.Generic;
   using System.Web.Http;

   [RoutePrefix("api/v1/message")]
   public class MessageController : ApiController
   {
      public MessageController()
      {
         
      }

      // GET api/v1/{controller}/{userId}/messages
      [Route("{userId}/messages")]
      [HttpGet]
      public IEnumerable<MessageDTO> GetAllMessages(string userId)
      {
         // TODO: call message service
         return null;
      }

      // GET api/v1/{controller}/{userId}/messages/{fromUserId}
      [Route("{userId}/messages/{fromUserId}")]
      [HttpGet]
      public IEnumerable<MessageDTO> GetMessagesFromOneUser(string userId, string fromUserId)
      {
         // TODO: call message service
         return null;
      }
   }
}