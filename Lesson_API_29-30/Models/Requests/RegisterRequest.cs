using Newtonsoft.Json;

namespace Lesson_API_29_30.Models.Requests;

public class RegisterRequest
{
    public string Email { get; set; }
    public string Password { get; set; }
}