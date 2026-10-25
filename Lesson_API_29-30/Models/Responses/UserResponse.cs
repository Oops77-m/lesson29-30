using Newtonsoft.Json;

namespace Lesson_API_29_30.Models.Responses;

public class UserResponse
{
    [JsonProperty("data")]
    public User Data { get; set; }
}