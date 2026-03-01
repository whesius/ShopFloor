// <copyright file="Populate.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Commands
{
    using Allors.Database.Domain;

    public static class Populate
    {
        public static int Execute(ProgramContext context)
        {
            var database = context.Database;

            database.Init();

            var config = new Config { DataPath = context.DataPath };
            new Setup(database, config).Apply();

            using (var session = database.CreateTransaction())
            {
                new Allors.Database.Domain.Upgrade(session, context.DataPath).Execute();

                session.Derive();
                session.Commit();
            }

            return ExitCode.Success;
        }
    }
}
