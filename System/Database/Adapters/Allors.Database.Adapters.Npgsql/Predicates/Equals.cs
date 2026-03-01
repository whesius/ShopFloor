// <copyright file="Equals.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Allors.Database.Adapters.Npgsql
{
    using Adapters;
    using static Allors.Database.Adapters.Sql.Schema.MappingConstants;

    internal sealed class Equals : Predicate
    {
        private readonly IObject obj;

        internal Equals(IObject obj)
        {
            PredicateAssertions.ValidateEquals(obj);
            this.obj = obj;
        }

        internal override void Setup(ExtentStatement statement)
        {
        }

        internal override bool BuildWhere(ExtentStatement statement, string alias)
        {
            statement.Append(" (" + alias + "." + ColumnNameForObject + "=" + statement.AddParameter(this.obj) + ") ");
            return this.Include;
        }
    }
}
