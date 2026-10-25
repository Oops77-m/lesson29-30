using Lesson_API_29_30.APIClient;

namespace Lesson_API_29_30.API;

public class UserDeleteTest_DELETE : BaseTestApi
{
    public UserClient Client { get; set; }
    [OneTimeSetUp]
    public void SetUp()
    {
        Client = new UserClient("https://reqres.in/");
    }

    [Test]
    public void DeleteUser()
    {
        var userDeleteResponse = Client.Delete("api/users/2");
        Assert.That((int)userDeleteResponse.StatusCode, Is.EqualTo(204));
    }
}