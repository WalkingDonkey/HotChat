using HotChat.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotChat.Service
{
    public interface IUserService
    {
        UserBO Register(UserBO userBO);
    }
}
