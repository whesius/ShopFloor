// <copyright file="TestPopulationTests.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Allors.Database.Domain.Tests
{
    using Xunit;

    public class TestPopulationTests : IClassFixture<Fixture>
    {
        private readonly Fixture fixture;

        public TestPopulationTests(Fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void TestPopulationDoesNotThrow()
        {
            using var test = new DomainTest(this.fixture);
        }
    }
}
