namespace HotChat.PO.Mongo
{
   using HotChat.Common;
   using MongoDB.Bson;
   using MongoDB.Bson.Serialization.Attributes;
   using System.Collections.Generic;

   public class AccountPO
   {
      [BsonId]
      [BsonRepresentation(BsonType.ObjectId)]
      public string Id { get; set; }
      public string UserId { get; set; }
      public double Balance { get; set; }
      public double BonusForWithdraw { get; set; }
      public Bill Bill { get; set; }
   }

   public class Bill
   {
      public IEnumerable<BillItem> Items { get; set; } 
   }
}
