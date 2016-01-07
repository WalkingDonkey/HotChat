using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace HotChat.PO.Mongo
{
   public class UserPO
   {
      [BsonId]
      public string UserId { get; set; }
      public string UserName { get; set; }
      public string Password { get; set; }
      public string Avatar { get; set; }
      public string Mobile { get; set; }
      public Gender Gender { get; set; }
      public Nationality Nationality { get; set; }
   }

   public enum Gender
   {
      Male = 0,
      Female
   }

   public enum Nationality
   {
      American = 0,
      Chinese
   }
}
