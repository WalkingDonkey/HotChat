using HotChat.BO;
using HotChat.Common;
using HotChat.PO.Mongo;
using HotChat.Repository.Interface;
using HotChat.Repository.Mongo.Abstract;
using System.Collections.Generic;

namespace HotChat.Repository.Mongo.Impl
{
   public class TeacherRepository : Repository<TeacherPO, string>, ITeacherRepository
   {
      private const string _collectionName = "Teachers";
      public TeacherRepository()
          : base(_collectionName)
      {
      }

      public void AddTeacher()
      {

      }

      public TeacherBO GetTeacher(string userId)
      {
         return null;
      }
   }
}
