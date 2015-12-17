using HotChat.BO;

namespace HotChat.Service.Interface
{
    public interface IUserService
    {
        UserBO Register(UserBO userBO);
    }
}
