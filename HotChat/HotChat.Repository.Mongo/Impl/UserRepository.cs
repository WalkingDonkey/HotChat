using HotChat.BO;
using HotChat.DAO;
using HotChat.Framework.Utility;
using HotChat.Repository.Interface;
using HotChat.Repository.Mongo.Abstract;
using MongoDB.Driver;
using System;

namespace HotChat.Repository.Mongo.Impl
{
   public class UserRepository : Repository<UserDAO, string>, IUserRepository
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
         Add(userBO.Map<UserBO, UserDAO>());
         return userBO;
      }

      public bool Exist(string userId)
      {
         var collection = GetCollection();
         var filter = Builders<UserDAO>.Filter.Eq("_id", userId);
         return collection.Find(filter).First() != null;
      }
   }
}
