using HotChat.Common;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace HotChat.DAO
{
   public class Remark
   {
      public string FromUserId { get; set; }
      public string FromUserName { get; set; }
      public string Avatar { get; set; }
      public Rating Rating { get; set; }
      public string Comment { get; set; }
      public DateTime CreatedOn { get; set; }
   }

   public class RemarksDAO
   {
      [BsonId]
      [BsonRepresentation(BsonType.ObjectId)]
      public string Id { get; set; }
      public string UserId { get; set; }
      public List<Remark> Remarks { get; set; }

      public RemarksDAO()
      {
         Remarks = new List<Remark>();
      }

      public RemarksDAO(string userId)
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
