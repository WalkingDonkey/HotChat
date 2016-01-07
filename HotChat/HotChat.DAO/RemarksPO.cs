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
      public Dictionary<string, List<Remark>> Course2Remarks { get; set; }

      public RemarksPO()
      {
         Course2Remarks = new Dictionary<string, List<Remark>>();
      }

      public RemarksPO(string userId)
      {
         UserId = userId;
         Course2Remarks = new Dictionary<string, List<Remark>>();
      }

      public void Add(string courseId, Remark remark)
      {
         if (!Course2Remarks.ContainsKey(courseId))
         {
            Course2Remarks[courseId] = new List<Remark>();
         }
         Course2Remarks[courseId].Add(remark);
      }
   }
}
