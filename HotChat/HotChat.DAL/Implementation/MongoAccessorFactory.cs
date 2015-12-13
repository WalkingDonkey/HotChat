using HotChat.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotChat.DAL.Implementation
{
    class MongoAccessorFactory : IAccessorFactory
    {
        public IDataAccessor CreateDataAccessor()
        {
            return new MongoDataAccessor();
        }
    }
}
