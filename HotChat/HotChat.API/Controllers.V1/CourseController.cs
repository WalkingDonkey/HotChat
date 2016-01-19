using HotChat.BO;
using HotChat.DTO;
using HotChat.Framework.Utility;
using HotChat.Service.Interface;
using System.Collections.Generic;
using System.Web.Http;

namespace HotChat.API.Controllers.V1
{
   [RoutePrefix("api/v1/course")]
   public class CourseController : ApiController
   {
      private ICourseService _courseService;

      public CourseController(ICourseService courseService)
      {
         _courseService = courseService;
      }

      public void AddCourse(string courseName)
      {
         _courseService.AddCourse(courseName);
      }

      public void AddStudent(string courseId, string userId)
      {
         _courseService.AddStudent(courseId, userId);
      }

      public IEnumerable<CourseDTO> GetCourses()
      {
         _courseService.GetCourses();
         return null;
      }

      public IEnumerable<TeacherProfileDTO> GetTeachers(string courseId)
      {
         _courseService.GetTeachers(courseId);
         return null;
      }

      public TeacherDTO GetTeacher(string userId)
      {
         _courseService.GetTeacher(userId);
         return null;
      }
   }
}