

using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Lesson_API_29_30.Models;

public class User
{
    [JsonProperty("id")]
    public int Id { get; set; }
    
    [JsonProperty("email")]
    public string Email { get; set; }
    
    [JsonProperty("first_name")]
    public string FirstName { get; set; }
    
    [JsonProperty("last_name")]
    public string LastName { get; set; }
    
    [JsonProperty("avatar")]
    public string Avatar { get; set; }
}
public class Users
{
    [JsonProperty("name")]
    public int Name { get; set; }
    [JsonProperty("job")]
    public string Job { get; set; }
}