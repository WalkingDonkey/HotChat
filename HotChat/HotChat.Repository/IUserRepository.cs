using HotChat.BO;

namespace HotChat.Repository.Interface
{
    public interface IUserRepository
    {
        UserBO Register(UserBO userBO);
    }
}
