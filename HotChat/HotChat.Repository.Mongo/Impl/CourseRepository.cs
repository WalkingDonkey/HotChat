using HotChat.BO;
using HotChat.Common;
using HotChat.PO.Mongo;
using HotChat.Repository.Interface;
using HotChat.Repository.Mongo.Abstract;
using System.Collections.Generic;

namespace HotChat.Repository.Mongo.Impl
{
   public class CourseRepository : Repository<CoursePO, string>, ICourseRepository
   {
      private const string _collectionName = "Courses";
      public CourseRepository()
          : base(_collectionName)
      {
      }

      public void AddCourse(string courseName)
      {

      }
      public void AddStudent(string courseId, string userId)
      {

      }

      public IEnumerable<CourseBO> GetCourses()
      {
         return null;
      }

      public IEnumerable<TeacherBO> GetTeachers(string courseId)
      {
         return null;
      }
   }
}
