using HotChat.Common;
using System.Collections.Generic;

namespace HotChat.BO
{
   public class RemarksBO
   {
      public List<Remark> Remarks { get; set; }

      public RemarksBO()
      {
         Remarks = new List<Remark>();
      }
   }
}
