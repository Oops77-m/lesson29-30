using Newtonsoft.Json;

namespace Lesson_API_29_30.Models.Responses;

public class UserDeleteResponse
{
    [JsonProperty("id")]
    public User Id { get; set; }
}