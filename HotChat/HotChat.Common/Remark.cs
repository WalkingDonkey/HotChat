﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotChat.Common
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
}
