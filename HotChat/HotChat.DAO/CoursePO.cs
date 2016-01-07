using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace HotChat.PO.Mongo
{
   public class CoursePO
   {
      [BsonId]
      [BsonRepresentation(BsonType.ObjectId)]
      public string Id { get; set; }
      public string Name { get; set; }
      public List<string> Students { get; set; }
   }
}
