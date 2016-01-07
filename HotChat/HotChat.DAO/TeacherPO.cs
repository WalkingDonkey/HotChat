using System.Collections.Generic;

namespace HotChat.PO.Mongo
{
   public class TeacherPO : UserPO
   {
      public Profile Profile { get; set; }
      public List<CourseInfo> Courses { get; set; }

      public TeacherPO()
      {
         Profile = new Profile();
         Courses = new List<CourseInfo>();
      }
   }

   public class Profile
   {
      public Dictionary<Languange, Level> LanguageAbility { get; set; }
      public string Education { get; set; }
      public string Experience { get; set; }
      public string SelfIntroduction { get; set; }
      public string Hobbies { get; set; }
      public string VideoUrl { get; set; }

      public Profile()
      {
         LanguageAbility = new Dictionary<Languange, Level>();
      }
   }

   public class CourseInfo
   {
      public string CourseId { get; set; }
      public double Price { get; set; }
      public long CallDuration { get; set; }
   }

   public enum Languange
   {
      English = 0,
      Chinese,
      Spanish
   }

   public enum Level
   {
      Basic = 0,
      Dialog,
      Fluent,
      Native
   }
}
