using HotChat.BO;
using HotChat.Repository.Interface;
using HotChat.Service.Interface;

namespace HotChat.Service.Impl
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserBO Register(UserBO userBO)
        {
            return _userRepository.Register(userBO);
        }
    }
}
