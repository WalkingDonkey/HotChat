using HotChat.BO;
using HotChat.DTO;
using HotChat.Framework.Utility;
using HotChat.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace HotChat.API.Controllers.V1
{
   [RoutePrefix("api/v1/user")]
   public class UserController : ApiController
   {
      private IUserService _userService;

      public UserController(IUserService userService)
      {
         _userService = userService;
      }

      // POST api/v1/<controller>/signup
      [Route("signup")]
      [HttpPost]
      public UserDTO SignUp(UserDTO userDTO)
      {
         UserBO userBO = _userService.SignUp(userDTO.Map<UserDTO, UserBO>());
         return userBO.Map<UserBO, UserDTO>();
      }

      // Get api/<controller>/signin
      [Route("signin")]
      [HttpPost]
      public UserDTO SignIn(UserDTO userDTO)
      {
         UserBO userBO = _userService.SignIn(userDTO.Map<UserDTO, UserBO>());
         return userBO.Map<UserBO, UserDTO>();
      }

      [Route("recharge")]
      [HttpPost]
      public void Recharge(BillDTO billDTO)
      {
         // TODO: call recharge service.
      }

      [Route("withdraw")]
      [HttpPost]
      public void Withdraw(BillDTO billDTO)
      {
         // TODO: call withdraw service.

      }
      // GET api/<controller>
      [Route("get")]
      public IEnumerable<string> Get()
      {
         return new string[] { "value1", "value2" };
      }
   }
}