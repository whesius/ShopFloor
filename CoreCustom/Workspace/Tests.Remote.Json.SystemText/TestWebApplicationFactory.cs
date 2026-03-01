namespace Tests.Workspace.Remote
{
    using System.Collections.Generic;
    using Allors.Server;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc.Testing;
    using Microsoft.Extensions.Configuration;

    public class TestWebApplicationFactory : WebApplicationFactory<Program>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.UseEnvironment("Development");

            builder.ConfigureAppConfiguration((context, config) =>
            {
                config.AddInMemoryCollection(new Dictionary<string, string>
                {
                    ["Cors:AllowedOrigins:0"] = "http://localhost",
                    ["JwtToken:Key"] = "TestSecretKeyForDevelopmentOnly1234567890",
                    ["Adapter"] = "Memory",
                });
            });
        }
    }
}
