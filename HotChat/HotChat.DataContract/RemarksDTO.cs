using HotChat.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace HotChat.DTO
{
   public class RemarksDTO
   {
      [JsonProperty]
      public List<Remark> Remarks { get; set; }      
   }
}
