using MongoDB.Bson.Serialization.Attributes;

namespace HotChat.PO.Mongo
{
   public class UserPO
   {
      [BsonId]
      public string UserId { get; set; }
      public string UserName { get; set; }
      public string Password { get; set; }
      public string Avatar { get; set; }
   }
}
