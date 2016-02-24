namespace HotChat.API.Controllers.V1
{
   using HotChat.DTO;
   using HotChat.Service.Interface;
   using System.Collections.Generic;
   using System.Web.Http;

   [RoutePrefix("api/v1/course")]
   public class CourseController : ApiController
   {
      private ICourseService _courseService;

      public CourseController(ICourseService courseService)
      {
         _courseService = courseService;
      }

      // POST api/v1/{controller}/course/{courseName}
      [Route("course/{courseName}")]
      [HttpPost]
      public void AddCourse(string courseName)
      {
         _courseService.AddCourse(courseName);
      }

      // POST api/v1/{controller}/student/{courseId}/{userId}
      [Route("student/{courseId}/{userId}")]
      [HttpPost]
      public void AddStudent(string courseId, string userId)
      {
         _courseService.AddStudent(courseId, userId);
      }

      // GET api/v1/{controller}
      [Route("")]
      [HttpGet]
      public IEnumerable<CourseDTO> GetCourses()
      {
         // TODO: mapping
         _courseService.GetCourses();
         return null;
      }

      // GET api/v1/{controller}/{courseId}/teachers
      [Route("{courseId}/teachers")]
      [HttpGet]
      public IEnumerable<TeacherProfileDTO> GetTeachers(string courseId)
      {
         // TODO: mapping
         _courseService.GetTeachers(courseId);
         return null;
      }

      // GET api/v1/{controller}/{userId}/teacher
      [Route("{userId}/teacher")]
      [HttpGet]
      public TeacherDTO GetTeacher(string userId)
      {
         // TODO: mapping
         _courseService.GetTeacher(userId);
         return null;
      }
   }
}