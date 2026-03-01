namespace Allors.Server.Tests
{
    using Xunit;

    [CollectionDefinition("Api")]
    public class ApiCollection : ICollectionFixture<TestWebApplicationFactory>
    {
    }
}
