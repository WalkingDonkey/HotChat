using HotChat.BO;

namespace HotChat.Service.Interface
{
   public interface IUserService
   {
      UserBO SignUp(UserBO userBO);
      UserBO SignIn(UserBO userBO);
   }
}
