using RestSharp;

namespace Lesson_API_29_30.APIClient;

public class ApiClient
{
    protected readonly RestClient Client;

    public ApiClient(string baseUrl) //https://reqres.in/
    {
        Client = new RestClient(baseUrl);
    }

    public RestResponse Get(string endpoint, Dictionary<string, string> queryParams = null)
    {
        var request = new RestRequest(endpoint);

        request.AddHeader("Content-Type", "application/json");

        foreach (var parameter in queryParams)
        {
            request.AddParameter(parameter.Key, parameter.Value);
        }

        return Client.Execute(request);
    }

    public RestResponse Post(string endpoint, object body)
    {
        var request = new RestRequest(endpoint, Method.Post);

        //request.AddHeader("x-api-key", "reqres_7756b4f4ca5e477b92c8c7dec4584053"); //авторизация
        //или через токен
        //request.AddHeader("Authorization", $"Bearer {token}");
        request.AddJsonBody(body);
        return Client.Execute(request);
    }

    public RestResponse Put(string endpoint, object body)
    {
        var request = new RestRequest(endpoint, Method.Put);
        request.AddJsonBody(body);
        return Client.Execute(request);
    }

    public RestResponse Delete(string endpoint, Dictionary<string, string> queryParams = null)
    {
        var request = new RestRequest(endpoint, Method.Delete);
        request.AddHeader("Content-Type", "application/json");

        queryParams ??= new Dictionary<string, string>();

        foreach (var parameter in queryParams)
        {
            request.AddParameter(parameter.Key, parameter.Value);
        }

        return Client.Execute(request);
    }
}