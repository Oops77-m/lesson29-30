using Lesson_API_29_30.Models.Responses;
using Newtonsoft.Json;

namespace Lesson_API_29_30.APIClient;

public class UserDelete : ApiClient
{
    private const string usersDelEndpoint = "api/users/2";
    public UserDelete (string baseUrl) : base(baseUrl)
    {
        
    }
    public UserDeleteResponse DeleteUser(int userId)
    {
        var response = Delete(usersDelEndpoint);
        return JsonConvert.DeserializeObject<UserDeleteResponse>(response.Content);
    
    }
}