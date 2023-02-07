using Alba;

namespace WebApp.IntegrationTests
{
  public class UnitTest1
  {
    [Fact]
    public async Task Test1()
    {
      await using var host = await AlbaHost.For<global::Program>();

      // This runs an HTTP request and makes an assertion
      // about the expected content of the response
      await host.Scenario(
        _ =>
        {
          _.Get.Url("/");
          _.ContentShouldBe("Hello World!");
          _.StatusCodeShouldBeOk();
        }
      );
    }
  }
}
