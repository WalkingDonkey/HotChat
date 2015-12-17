using Newtonsoft.Json;

namespace HotChat.DTO
{
    public class UserDTO
    {
        [JsonProperty]
        public string UserId { get; set; }

        [JsonProperty]
        public string UserName { get; set; }

        [JsonProperty]
        public string Password { get; set; }
    }
}