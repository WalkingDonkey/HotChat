using HotChat.BO;
using HotChat.Framework.Utility;
using HotChat.PO.Mongo;
using HotChat.Repository.Interface;
using HotChat.Repository.Mongo.Abstract;
using MongoDB.Driver;
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
         string userId = Guid.NewGuid().ToString();
         userBO.UserId = userId;
         Add(userBO.Map<UserBO, UserPO>());
         return userBO;
      }

      public bool Exist(string userId)
      {
         var collection = GetCollection();
         var filter = Builders<UserPO>.Filter.Eq("_id", userId);
         return collection.Find(filter).First() != null;
      }
   }
}
