using HotChat.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotChat.DTO
{
   public class RemarkDTO
   {
      [JsonProperty]
      public string ToUserId { get; set; }
      [JsonProperty]
      public string FromUserId { get; set; }
      [JsonProperty]
      public string FromUserName { get; set; }
      [JsonProperty]
      public string Avatar { get; set; }
      [JsonProperty]
      public Rating Rating { get; set; }
      [JsonProperty]
      public string Comment { get; set; }
      [JsonProperty]
      public DateTime CreatedOn { get; set; }
   }
}
