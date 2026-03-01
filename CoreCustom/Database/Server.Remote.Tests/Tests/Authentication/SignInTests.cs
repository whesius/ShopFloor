// <copyright file="SignInTests.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Allors.Server.Tests
{
    using System;

    using Database.Domain;
    using Protocol.Json.Auth;
    using Xunit;

    [Collection("Api")]

    public class SignInTests : ApiTest
    {
        public SignInTests(TestWebApplicationFactory factory) : base(factory)
        {
            new PersonBuilder(this.Transaction).WithUserName("John").Build();
            new PersonBuilder(this.Transaction).WithUserName("Jane").Build();
            this.Transaction.Derive();
            this.Transaction.Commit();
        }

        [Fact]
        public async void CorrectUser()
        {
            var args = new AuthenticationTokenRequest
            {
                l = "Jane",
            };

            var uri = new Uri("TestAuthentication/Token", UriKind.Relative);
            var response = await this.PostAsJsonAsync(uri, args);
            var siginInResponse = await this.ReadAsAsync<AuthenticationTokenResponse>(response);

            Assert.True(siginInResponse.a);
        }

        [Fact]
        public async void NonExistingUser()
        {
            var args = new AuthenticationTokenRequest
            {
                l = "Jeff",
            };

            var uri = new Uri("TestAuthentication/Token", UriKind.Relative);
            var response = await this.PostAsJsonAsync(uri, args);
            var siginInResponse = await this.ReadAsAsync<AuthenticationTokenResponse>(response);

            Assert.False(siginInResponse.a);
        }
    }
}
