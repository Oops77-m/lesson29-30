using Lesson_API_29_30.APIClient;
using Lesson_API_29_30.Models.Requests;
using Lesson_API_29_30.Models.Responses;

namespace Lesson_API_29_30.API;

public class RegisterTestApi_POST : BaseTestApi
{
    private RegisterClient Client {get; set;}
    [OneTimeSetUp]
    public void SetUp()
    {
        Client = new RegisterClient("https://reqres.in/");
    }

    [Test]
    public void RegisterPost()
    {
        RegisterRequest request = new RegisterRequest()
        {
            Email = "eve.holt@reqres.in",
            Password = "pistol"
        };
        var response = Client.PostRegister<RegisterResponse>(request);
        Assert.That(response.Id, Is.EqualTo(4));
        Assert.That(response.Token, Is.Not.Null);
    }
    
    [Test]
    public void RegisterPost_EmptyData()
    {
        RegisterRequest request = new RegisterRequest()
        {
            Email = "",
            Password = ""
        };
        var response = Client.PostRegister<ErrorResponse>(request);
        Assert.That(response.Error, Is.EqualTo("Missing email or username"));
        
    }
}