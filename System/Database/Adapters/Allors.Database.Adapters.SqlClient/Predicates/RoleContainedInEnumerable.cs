// <copyright file="RoleContainedInEnumerable.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Allors.Database.Adapters.SqlClient
{
    using System.Collections.Generic;
    using System.Text;

    using Adapters;

    using Meta;
    using static Allors.Database.Adapters.Sql.Schema.MappingConstants;

    internal sealed class RoleContainedInEnumerable : ContainedIn
    {
        private readonly IEnumerable<IObject> enumerable;
        private readonly IRoleType role;

        internal RoleContainedInEnumerable(ExtentFiltered extent, IRoleType role, IEnumerable<IObject> enumerable)
        {
            extent.CheckRole(role);
            PredicateAssertions.ValidateRoleContainedIn(role, enumerable);
            this.role = role;
            this.enumerable = enumerable;
        }

        internal override bool BuildWhere(ExtentStatement statement, string alias)
        {
            var mapping = statement.Mapping;

            var inStatement = new StringBuilder("0");
            foreach (var inObject in this.enumerable)
            {
                inStatement.Append(",");
                inStatement.Append(inObject.Id);
            }

            if ((this.role.IsMany && this.role.RelationType.AssociationType.IsMany) || !this.role.RelationType.ExistExclusiveDatabaseClasses)
            {
                // TODO: in combination with NOT gives error
                statement.Append(" (" + mapping.RoleJoinAlias(this.role) + "." + ColumnNameForRole + " IS NOT NULL AND ");
                statement.Append(" " + mapping.RoleJoinAlias(this.role) + "." + ColumnNameForRole + " IN (");
                statement.Append(inStatement.ToString());
                statement.Append(" ))");
            }
            else if (this.role.IsMany)
            {
                statement.Append(" (" + mapping.RoleJoinAlias(this.role) + "." + ColumnNameForObject + " IS NOT NULL AND ");
                statement.Append(" " + mapping.RoleJoinAlias(this.role) + "." + ColumnNameForObject + " IN (");
                statement.Append(inStatement.ToString());
                statement.Append(" ))");
            }
            else
            {
                statement.Append(" (" + mapping.ColumnNameByRelationType[this.role.RelationType] + " IS NOT NULL AND ");
                statement.Append(" " + mapping.ColumnNameByRelationType[this.role.RelationType] + " IN (");
                statement.Append(inStatement.ToString());
                statement.Append(" ))");
            }

            return this.Include;
        }

        internal override void Setup(ExtentStatement statement) => statement.UseRole(this.role);
    }
}
