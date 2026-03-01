// <copyright file="DefaultConnectionFactory.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Allors.Database.Adapters.Npgsql.Npgsql
{
    using Sql;

    public sealed class ConnectionFactory : IConnectionFactory
    {
        private readonly Database database;

        public ConnectionFactory(Database database) => this.database = database;

        public Connection Create() => new Connection(this.database);

        IConnection IConnectionFactory.Create() => this.Create();
    }
}
