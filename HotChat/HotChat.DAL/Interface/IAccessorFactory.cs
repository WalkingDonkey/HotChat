using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotChat.DAL.Interface
{
    interface IAccessorFactory
    {
        IDataAccessor CreateDataAccessor();
    }
}
