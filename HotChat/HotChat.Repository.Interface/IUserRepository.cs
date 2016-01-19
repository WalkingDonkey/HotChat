using HotChat.BO;

namespace HotChat.Repository.Interface
{
   public interface IUserRepository
   {
      UserBO SignUp(UserBO userBO);
      UserBO SignIn(UserBO userBO);
   }
}
