// <copyright file="DatabaseBuilder.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>
// <summary>
//   Defines the AllorsStrategySql type.
// </summary>

namespace Allors.Database.Adapters
{
    using System;
    using System.Data;
    using Microsoft.Extensions.Configuration;

    public class DatabaseBuilder
    {
        private readonly IDatabaseServices scope;
        private readonly IConfiguration configuration;
        private readonly string adapter;
        private readonly string connectionString;
        private readonly ObjectFactory objectFactory;
        private readonly IsolationLevel? isolationLevel;
        private readonly int? commandTimeout;

        public DatabaseBuilder(IDatabaseServices scope, IConfiguration configuration, ObjectFactory objectFactory, IsolationLevel? isolationLevel = null, int? commandTimeout = null)
        {
            this.scope = scope;
            this.configuration = configuration;
            this.objectFactory = objectFactory;
            this.isolationLevel = isolationLevel;
            this.commandTimeout = commandTimeout;
        }

        public DatabaseBuilder(IDatabaseServices scope, string adapter, string connectionString, ObjectFactory objectFactory, IsolationLevel? isolationLevel = null, int? commandTimeout = null)
        {
            this.scope = scope;
            this.adapter = adapter;
            this.connectionString = connectionString;
            this.objectFactory = objectFactory;
            this.isolationLevel = isolationLevel;
            this.commandTimeout = commandTimeout;
        }

        public IDatabase Build()
        {
            // Use directly provided values if available (from new constructor), otherwise read from configuration
            var adapter = (this.adapter ?? this.configuration?["Adapter"])?.Trim().ToUpperInvariant();
            var connectionString = this.connectionString ?? this.configuration?["ConnectionStrings:DefaultConnection"];

            return adapter switch
            {
                "MEMORY" => new Memory.Database(this.scope,
                    new Memory.Configuration
                    {
                        ObjectFactory = this.objectFactory,
                    }),
                "NPGSQL" => new Npgsql.Database(this.scope,
                    new Npgsql.Configuration
                    {
                        ObjectFactory = this.objectFactory,
                        ConnectionString = connectionString,
                        IsolationLevel = this.isolationLevel,
                        CommandTimeout = this.commandTimeout,
                    }),
                "SQLCLIENT" => new SqlClient.Database(this.scope,
                    new SqlClient.Configuration
                    {
                        ObjectFactory = this.objectFactory,
                        ConnectionString = connectionString,
                        IsolationLevel = this.isolationLevel,
                        CommandTimeout = this.commandTimeout,
                    }),
                _ => throw new ArgumentOutOfRangeException(adapter)
            };
        }
    }
}
