using System.Net;
using Lesson_API_29_30.APIClient;
using Lesson_API_29_30.Models;
using Lesson_API_29_30.Models.Responses;
using Newtonsoft.Json;

namespace Lesson_API_29_30.API;

[TestFixture]
public class UserTestApi_GET : BaseTestApi
{
    public UserClient Client { get; set; }

    [OneTimeSetUp]
    public void SetUp()
    {
        Client = new UserClient("https://reqres.in/");
    }
    [Test]
    public void GetUsers_Success()
    {
        var userListResponse = Client.GetUsers();
        Assert.That(userListResponse.Data.Count, Is.EqualTo(6));
        Assert.That(userListResponse.Data[0].FirstName, Is.EqualTo("George"));
        
    }
    [Test]
    public void GetUser_Success()
    {
        var userListResponse = Client.GetUser(2);
        Assert.That(userListResponse.Data.Id, Is.EqualTo(2));
        Assert.That(userListResponse.Data.FirstName, Is.EqualTo("Janet"));
        
    }
    [Test]
    public void GetUsersSecondPage_Success()
    {
        var userListResponse = Client.GetUsersBePage(2);
        Assert.That(userListResponse.Data.Count, Is.EqualTo(6));
        Assert.That(userListResponse.Data[0].FirstName, Is.EqualTo("Michael"));
        
    }
}