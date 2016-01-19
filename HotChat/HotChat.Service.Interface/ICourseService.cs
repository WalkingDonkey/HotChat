using HotChat.BO;
using System.Collections.Generic;

namespace HotChat.Service.Interface
{
   public interface ICourseService
   {
      void AddCourse(string courseName);
      void AddStudent(string courseId, string userId);
      IEnumerable<CourseBO> GetCourses();
      IEnumerable<TeacherBO> GetTeachers(string courseId);
      TeacherBO GetTeacher(string userId);
   }
}
