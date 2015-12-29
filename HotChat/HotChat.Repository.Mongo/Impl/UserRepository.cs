using HotChat.BO;
using HotChat.Framework.Utility;
using HotChat.PO.Mongo;
using HotChat.Repository.Interface;
using HotChat.Repository.Mongo.Abstract;
using System;

namespace HotChat.Repository.Mongo.Impl
{
   public class UserRepository : Repository<UserPO, string>, IUserRepository
   {
      private const string _collectionName = "Users";
      public UserRepository()
          : base(_collectionName)
      {
      }

      public UserBO Register(UserBO userBO)
      {
         if (userBO == null)
         {
            throw new ArgumentNullException("userBO");
         }

         if (NameExist(userBO.UserName))
         {
            throw new Exception(string.Format("The user name \"{0}\" already exists.", userBO.UserName));
         }

         userBO.UserId = Guid.NewGuid().ToString();
         Add(userBO.Map<UserBO, UserPO>());
         return userBO;
      }

      private bool IdExist(string userId)
      {
         var filter = EqFilter("_id", userId);
         return Count(filter) != 0;
      }

      private bool NameExist(string userName)
      {
         var filter = EqFilter("UserName", userName);
         return Count(filter) != 0;
      }
   }
}
