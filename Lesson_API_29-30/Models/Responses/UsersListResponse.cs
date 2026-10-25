
using Newtonsoft.Json;

namespace Lesson_API_29_30.Models.Responses;

public class UsersListResponse
{
    [JsonProperty("data")]
    public List<User> Data { get; set; }
}