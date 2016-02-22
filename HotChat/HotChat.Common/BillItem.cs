namespace HotChat.Common
{
   using System;

   public class BillItem
   {
      public double Amount { get; set; }
      public BillType Type { get; set; }
      public BillStatus Status { get; set; }
      public DateTime CreatedOn { get; set; }
   }

   public enum BillType
   {
      Register = 0,
      Charge,
      Withdraw,
   }

   public enum BillStatus
   {
      Success = 0,
      Failure,
      Pending,
   }
}
