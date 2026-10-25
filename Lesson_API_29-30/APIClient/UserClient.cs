using Lesson_API_29_30.Models.Responses;
using Newtonsoft.Json;
using RestSharp;

namespace Lesson_API_29_30.APIClient;

public class UserClient : ApiClient
{
    private const string usersEndpoint = "api/users/";
    public UserClient(string baseUrl) : base(baseUrl)
    {
        
    }

    public UsersListResponse GetUsers()
    {
        var response = Get(usersEndpoint);
        return JsonConvert.DeserializeObject<UsersListResponse>(response.Content);
    }

    public UserResponse GetUser(int userId)
    {
        var response = Get(usersEndpoint + userId);
        return JsonConvert.DeserializeObject<UserResponse>(response.Content);
    
    }

    public UsersListResponse GetUsersBePage(int page)
    {
        Dictionary<string, string> queryParams = new Dictionary<string, string>()
        {
            {"page", page.ToString()}
        }
        ;
        var response = Get(usersEndpoint, queryParams);
        return JsonConvert.DeserializeObject<UsersListResponse>(response.Content);

    }
}