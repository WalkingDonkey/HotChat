namespace HotChat.API.Controllers.V1
{
   using HotChat.BO;
   using HotChat.DTO;
   using HotChat.Framework.Utility;
   using HotChat.Service.Interface;
   using System.Web.Http;

   [RoutePrefix("api/v1/user")]
   public class UserController : ApiController
   {
      private IUserService _userService;

      public UserController(IUserService userService)
      {
         _userService = userService;
      }

      // POST api/v1/{controller}/signup
      [Route("signup")]
      [HttpPost]
      public UserDTO SignUp(UserDTO userDTO)
      {
         UserBO userBO = _userService.SignUp(userDTO.Map<UserDTO, UserBO>());
         return userBO.Map<UserBO, UserDTO>();
      }

      // POST api/v1/{controller}/signin
      [Route("signin")]
      [HttpPost]
      public UserDTO SignIn(UserDTO userDTO)
      {
         UserBO userBO = _userService.SignIn(userDTO.Map<UserDTO, UserBO>());
         return userBO.Map<UserBO, UserDTO>();
      }

      // POST api/v1/{controller}/profile
      [Route("profile")]
      [HttpPost]
      public void UpdateProfile()
      {
         // TODO:
      }

      // POST api/v1/{controller}/recharge
      [Route("recharge")]
      [HttpPost]
      public void Recharge(BillDTO billDTO)
      {
         // TODO: call recharge service.
      }

      // POST api/v1/{controller}/withdraw
      [Route("withdraw")]
      [HttpPost]
      public void Withdraw(BillDTO billDTO)
      {
         // TODO: call withdraw service.
      }
   }
}