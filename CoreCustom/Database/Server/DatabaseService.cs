// <copyright file="DatabaseService.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Allors.Services
{
    using System;
    using Database;
    using Database.Adapters;
    using Database.Configuration;
    using Database.Configuration.Derivations.Default;
    using Database.Domain;
    using Database.Meta.Configuration;
    using Microsoft.Extensions.Configuration;

    public class DatabaseService : IDatabaseService
    {
        private IDatabase database;

        public DatabaseService(ConfigurationManager configuration)
        {
            var metaBuilder = new MetaBuilder();

            this.Build = () =>
            {
                var adapter = configuration["Adapter"]
                              ?? throw new InvalidOperationException("Adapter configuration is required");
                var connectionString = configuration["ConnectionStrings:DefaultConnection"];

                var metaPopulation = metaBuilder.Build();
                var engine = new Engine(Rules.Create(metaPopulation));
                var objectFactory = new ObjectFactory(metaPopulation, typeof(Allors.Database.Domain.User));
                var databaseScope = new DefaultDatabaseServices(engine);
                var databaseBuilder = new DatabaseBuilder(
                    databaseScope,
                    adapter,
                    connectionString,
                    objectFactory,
                    isolationLevel: null,
                    commandTimeout: 60);

                return databaseBuilder.Build();
            };
        }

        public Func<IDatabase> Build { get;  }

        public IDatabase Database => this.database ??= this.Build();

        public void Restart() => this.database = null;
    }
}
