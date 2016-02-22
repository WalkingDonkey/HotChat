namespace HotChat.DTO
{
   using HotChat.Common;
   using System;

   public class BillDTO
   {
      public DateTime CreatedOn { get; set; }
      public double Amount { get; set; }
      public BillStatus Status { get; set; }
   }
}
