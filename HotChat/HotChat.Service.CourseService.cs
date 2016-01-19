using HotChat.BO;
using HotChat.Repository.Interface;
using HotChat.Service.Interface;
using System.Collections.Generic;

namespace HotChat.Service.Impl
{
   public class CourseService : ICourseService
   {
      private ICourseRepository _courseRepository;
      private ITeacherRepository _teacherRepository;

      public CourseService(ICourseRepository courseRepository, ITeacherRepository teacherRepository)
      {
         _courseRepository = courseRepository;
         _teacherRepository = teacherRepository;
      }

      public void AddCourse(string courseName)
      {
         _courseRepository.AddCourse(courseName);
      }

      public void AddStudent(string courseId, string userId)
      {
         _courseRepository.AddStudent(courseId, userId);
      }

      public IEnumerable<CourseBO> GetCourses()
      {
         return _courseRepository.GetCourses();
      }

      public IEnumerable<TeacherBO> GetTeachers(string courseId)
      {
         return _courseRepository.GetTeachers(courseId);
      }

      public TeacherBO GetTeacher(string userId)
      {
         return _teacherRepository.GetTeacher(userId);
      }
   }
}
