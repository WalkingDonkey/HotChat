using HotChat.BO;
using HotChat.Common;
using System.Collections.Generic;

namespace HotChat.Repository.Interface
{
   public interface ICourseRepository
   {
      void AddCourse(string courseName);
      void AddStudent(string courseId, string userId);

      IEnumerable<CourseBO> GetCourses();
      IEnumerable<TeacherBO> GetTeachers(string courseId);
   }
}
