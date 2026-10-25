using Lesson_API_29_30.Models.Requests;
using Newtonsoft.Json;

namespace Lesson_API_29_30.APIClient;

public class UpdateClient : ApiClient
{
    private readonly string UpdateEndpoint = "/api/users/2";

    public UpdateClient(string endpoint) : base(endpoint)
    {
        
    }

    public T PutClient<T>(UserUpdate request)
    {
        var restResponse = Put(UpdateEndpoint, request);
        return JsonConvert.DeserializeObject<T>(restResponse.Content);
    }
}