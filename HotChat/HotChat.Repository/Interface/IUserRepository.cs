using HotChat.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotChat.Repository.Interface
{
    public interface IUserRepository : IRepository<UserBO, string>
    {
        UserBO Register(UserBO userBO);
    }
}
