// <copyright file="Profile.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Tests.Workspace.Remote
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Allors.Ranges;
    using Allors.Services;
    using Allors.Workspace;
    using Allors.Workspace.Adapters;
    using Allors.Workspace.Derivations;
    using Allors.Workspace.Domain;
    using Allors.Workspace.Meta;
    using Allors.Workspace.Meta.Lazy;
    using Microsoft.Extensions.DependencyInjection;
    using Xunit;
    using Configuration = Allors.Workspace.Adapters.Remote.Configuration;
    using DatabaseConnection = Allors.Workspace.Adapters.Remote.SystemText.DatabaseConnection;
    using IWorkspaceServices = Allors.Workspace.IWorkspaceServices;

    public class Profile : IProfile
    {
        public const string SetupUrl = "Test/Setup?population=full";
        public const string LoginUrl = "TestAuthentication/Token";

        private readonly Func<IWorkspaceServices> servicesBuilder;
        private readonly IdGenerator idGenerator;
        private readonly DefaultRanges<long> defaultRanges;
        private readonly Configuration configuration;
        private readonly Fixture fixture;

        private HttpClient httpClient;

        public Profile(Fixture fixture)
        {
            this.fixture = fixture;
            this.servicesBuilder = () => new WorkspaceServices();
            this.idGenerator = new IdGenerator();
            this.defaultRanges = new DefaultStructRanges<long>();

            var metaPopulation = new MetaBuilder().Build();
            var objectFactory = new ReflectionObjectFactory(metaPopulation, typeof(Allors.Workspace.Domain.Person));
            var rules = new IRule[] { new PersonSessionFullNameRule(metaPopulation) };
            this.configuration = new Configuration("Default", metaPopulation, objectFactory, rules);
        }

        IWorkspace IProfile.Workspace => this.Workspace;

        public DatabaseConnection DatabaseConnection { get; private set; }

        public IWorkspace Workspace { get; private set; }

        public M M => ((IWorkspaceServices)this.Workspace.Services).Get<M>();

        public async Task InitializeAsync()
        {
            var databaseService = this.fixture.Factory.Services.GetRequiredService<IDatabaseService>();
            databaseService.Restart();

            this.httpClient = this.fixture.Factory.CreateClient();
            this.httpClient.BaseAddress = new Uri("http://localhost/allors/");
            this.httpClient.Timeout = TimeSpan.FromMinutes(30);

            var response = await this.httpClient.GetAsync(SetupUrl);
            Assert.True(response.IsSuccessStatusCode);

            this.DatabaseConnection = new DatabaseConnection(this.configuration, this.servicesBuilder, this.httpClient, this.idGenerator, this.defaultRanges);
            this.Workspace = this.DatabaseConnection.CreateWorkspace();

            await this.Login("administrator");
        }

        public Task DisposeAsync() => Task.CompletedTask;

        public IWorkspace CreateExclusiveWorkspace()
        {
            var database = new DatabaseConnection(this.configuration, this.servicesBuilder, this.httpClient, this.idGenerator, this.defaultRanges);
            return database.CreateWorkspace();
        }

        public IWorkspace CreateWorkspace() => this.DatabaseConnection.CreateWorkspace();

        public async Task Login(string user)
        {
            var uri = new Uri(LoginUrl, UriKind.Relative);
            var response = await this.DatabaseConnection.Login(uri, user);
            Assert.True(response);
        }
    }
}
