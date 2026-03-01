// <copyright file="ApiTest.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>
// <summary>Defines the DomainTest type.</summary>

namespace Allors.Server.Tests
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Reflection;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;
    using Database;
    using Database.Domain;
    using Database.Meta;
    using Database.Meta.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Protocol.Json.Auth;
    using Services;
    using User = Database.Domain.User;

    public abstract class ApiTest : IDisposable
    {
        public const string LoginUrl = "TestAuthentication/Token";

        protected ApiTest(TestWebApplicationFactory factory)
        {
            this.HttpClient = factory.CreateClient();
            this.HttpClient.BaseAddress = new Uri(this.HttpClient.BaseAddress!, "allors/");
            this.HttpClient.DefaultRequestHeaders.Accept.Clear();
            this.HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var databaseService = factory.Services.GetRequiredService<IDatabaseService>();
            databaseService.Restart();
            var database = databaseService.Database;
            this.Setup(database);

            this.Transaction = database.CreateTransaction();
        }

        public MetaPopulation M => this.Transaction.Database.Services.Get<MetaPopulation>();

        public virtual Config Config { get; } = new Config { SetupSecurity = true };

        protected ITransaction Transaction { get; private set; }

        protected HttpClient HttpClient { get; set; }

        protected User Administrator => new Users(this.Transaction).FindBy(this.M.User.UserName, "jane@example.com");

        public void Dispose()
        {
            this.Transaction.Rollback();
            this.Transaction = null;

            this.HttpClient.Dispose();
            this.HttpClient = null;
        }

        protected void Setup(IDatabase database)
        {
            database.Init();

            new Setup(database, this.Config).Apply();

            using var transaction = database.CreateTransaction();
            transaction.Commit();

            new TestPopulation(transaction).Apply();
            transaction.Commit();
        }

        protected async Task SignIn(User user)
        {
            var args = new AuthenticationTokenRequest
            {
                l = user.UserName,
            };

            var uri = new Uri(LoginUrl, UriKind.Relative);
            var response = await this.PostAsJsonAsync(uri, args);
            var signInResponse = await this.ReadAsAsync<AuthenticationTokenResponse>(response);
            this.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", signInResponse.t);
        }

        protected void SignOut() => this.HttpClient.DefaultRequestHeaders.Authorization = null;

        protected Stream GetResource(string name)
        {
            var assembly = this.GetType().GetTypeInfo().Assembly;
            return assembly.GetManifestResourceStream(name);
        }

        protected async Task<HttpResponseMessage> PostAsJsonAsync(Uri uri, object args)
        {
            var json = JsonSerializer.Serialize(args);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            return await this.HttpClient.PostAsync(uri, content);
        }

        protected async Task<T> ReadAsAsync<T>(HttpResponseMessage response)
        {
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
