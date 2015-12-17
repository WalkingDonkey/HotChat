using HotChat.BO;
using HotChat.DAO;
using HotChat.Framework.Utility;
using HotChat.Repository.Interface;
using HotChat.Repository.Mongo.Abstract;

namespace HotChat.Repository.Mongo.Impl
{
    public class UserRepository : Repository<User, string>, IUserRepository
    {
        private const string _collectionName = "Users";
        public UserRepository()
            : base(_collectionName)
        {
        }

        public UserBO Register(UserBO userBO)
        {
            Add(userBO.TODAO());
            return userBO;
        }
    }
}
