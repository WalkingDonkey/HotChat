namespace HotChat.API.Controllers.V1
{
   using System.Web.Http;

   [RoutePrefix("api/v1/userstatus")]
   public class UserStatusController : ApiController
   {
      public UserStatusController()
      {
         
      }

      public void HeartBeat(string userId)
      {
         // TODO:
      }
   }
}