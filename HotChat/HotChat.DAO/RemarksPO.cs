using HotChat.Common;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace HotChat.PO.Mongo
{
   public class RemarksPO
   {
      [BsonId]
      [BsonRepresentation(BsonType.ObjectId)]
      public string Id { get; set; }
      public string UserId { get; set; }
      public List<Remark> Remarks { get; set; }

      public RemarksPO()
      {
         Remarks = new List<Remark>();
      }

      public RemarksPO(string userId)
      {
         UserId = userId;
         Remarks = new List<Remark>();
      }

      public void Add(Remark remark)
      {
         Remarks.Add(remark);
      }
   }
}
