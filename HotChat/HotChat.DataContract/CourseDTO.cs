using Newtonsoft.Json;

namespace HotChat.DTO
{ 
    public class CourseDTO
    {
        [JsonProperty]
        public string CourseId { get; set; }

        [JsonProperty]
        public string CourseName { get; set; }
    }
}