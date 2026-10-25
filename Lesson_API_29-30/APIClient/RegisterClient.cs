using Lesson_API_29_30.Models.Requests;
using Lesson_API_29_30.Models.Responses;
using Newtonsoft.Json;

namespace Lesson_API_29_30.APIClient;

public class RegisterClient : ApiClient
{
    private readonly string RegisterEndpoint = "/api/register";
    
    public RegisterClient(string endpoint) : base(endpoint)
    {

    }

    public T PostRegister<T>(RegisterRequest request)
    {
        var restResponse = Post(RegisterEndpoint, request);
        return JsonConvert.DeserializeObject<T>(restResponse.Content);
    }
}