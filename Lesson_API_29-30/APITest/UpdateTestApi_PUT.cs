using Lesson_API_29_30.APIClient;
using Lesson_API_29_30.Models.Requests;
using Lesson_API_29_30.Models.Responses;

namespace Lesson_API_29_30.API;

public class UpdateTestApi_PUT : BaseTestApi
{
    private UpdateClient PutClient { get; set; }

    [OneTimeSetUp]
    public void SetUp()
    {
        PutClient = new UpdateClient("https://reqres.in/");
    }

    [Test]
    public void UpdatePut()
    {
        UserUpdate request = new UserUpdate()
        {
            Name = "morpheus",
            Job = "zion resident"
        };
        var response = PutClient.PutClient<UserUpdateResponse>(request);
        Assert.That(response.UpdatedAt, Is.Not.Null);
        Assert.That(response.Name, Is.EqualTo("morpheus"));
    }
}