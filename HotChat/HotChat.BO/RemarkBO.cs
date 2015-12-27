using HotChat.Common;
using System;

namespace HotChat.BO
{
   public class RemarkBO
   {
      public string ToUserId { get; set; }
      public string FromUserId { get; set; }
      public string FromUserName { get; set; }
      public string Avatar { get; set; }
      public Rating Rating { get; set; }
      public string Comment { get; set; }
      public DateTime CreatedOn { get; set; }
   }
}
