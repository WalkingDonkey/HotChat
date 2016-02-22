namespace HotChat.PO.Mongo
{
   using MongoDB.Bson;
   using MongoDB.Bson.Serialization.Attributes;
   using System;
   using System.Collections.Generic;

   public class MessagePO
   {
      [BsonId]
      [BsonRepresentation(BsonType.ObjectId)]
      public string Id { get; set; }
      public string UserId { get; set; }
      public IEnumerable<MessageRecord> Records { get; set; }
   }

   public class MessageRecord
   {
      public string FromUserId { get; set; }
      public string FromUserName { get; set; }
      public FirstMessage Message { get; set; }
      public MessageType Type { get; set; }
   }

   public class FirstMessage
   {
      public DateTime CreatedOn { get; set; }
      public string Content { get; set; }
   }

   public enum MessageType
   {
      Chat = 0,
      Notification
   }
}
