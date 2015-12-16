using HotChat.BO;
using HotChat.Repository.Interface;
using HotChat.Repository.Mongo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotChat.Repository.Mongo.Implementation
{
    public class UserRepository : Repository<UserBO, string>, IUserRepository
    {
        private const string _collectionName = "Users";
        public UserRepository()
            : base(_collectionName)
        {
        }

        public UserBO Register(UserBO userBO)
        {
            Add(userBO);
            return userBO;
        }
    }
}
