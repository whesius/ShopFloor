// <copyright file="SchemaTest.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Allors.Database.Adapters.SqlClient.SqlClient
{
    using Xunit;

    public class SchemaTest :  IClassFixture<Fixture<SchemaTest>>
    {
        private readonly Profile profile;

        public SchemaTest() => this.profile = new Profile(this.GetType().Name);

        protected IProfile Profile => this.profile;

        public void Dispose() => this.profile.Dispose();

        protected void DropTable(string schema, string tableName) => this.profile.DropTable(schema, tableName);

        protected bool ExistTable(string schema, string table) => this.profile.ExistTable(schema, table);

        protected int ColumnCount(string schema, string table) => this.profile.ColumnCount(schema, table);

        protected bool ExistColumn(string schema, string table, string column, ColumnTypes columnType) =>
            this.profile.ExistColumn(schema, table, column, columnType);

        protected bool ExistPrimaryKey(string schema, string table, string column) =>
            this.profile.ExistPrimaryKey(schema, table, column);

        protected bool ExistProcedure(string schema, string procedure) =>
            this.profile.ExistProcedure(schema, procedure);

        protected bool ExistIndex(string schema, string table, string column) =>
            this.profile.ExistIndex(schema, table, column);

        protected void DropProcedure(string schema, string procedure) => this.profile.DropProcedure(procedure);

        [Fact(Skip = "Explicit")]
        public void Recover()
        {
            // this.InitAndCreateTransaction();

            // this.DropProcedure("_GC");

            // var repository = this.CreateDatabase();

            // var exceptionThrown = false;
            // try
            // {
            //    repository.CreateTransaction();
            // }
            // catch
            // {
            //    exceptionThrown = true;
            // }

            // Assert.True(exceptionThrown);

            // ((Database.SqlClient.Database)repository).Schema.Recover();

            // Assert.True(this.ExistProcedure("_GC"));

            // exceptionThrown = false;
            // try
            // {
            //    repository.CreateTransaction();
            // }
            // catch
            // {
            //    exceptionThrown = true;
            // }

            // Assert.False(exceptionThrown);
        }
    }
}
