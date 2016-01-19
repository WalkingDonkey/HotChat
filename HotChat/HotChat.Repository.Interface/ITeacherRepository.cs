using HotChat.BO;
using HotChat.Common;
using System.Collections.Generic;

namespace HotChat.Repository.Interface
{
   public interface ITeacherRepository
   {
      void AddTeacher();
      TeacherBO GetTeacher(string userId);
   }
}
