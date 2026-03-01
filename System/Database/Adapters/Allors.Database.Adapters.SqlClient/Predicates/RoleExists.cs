// <copyright file="RoleExists.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Allors.Database.Adapters.SqlClient
{
    using Adapters;
    using Meta;
    using static Allors.Database.Adapters.Sql.Schema.MappingConstants;

    internal sealed class RoleExists : Predicate
    {
        private readonly IRoleType role;

        internal RoleExists(ExtentFiltered extent, IRoleType role)
        {
            extent.CheckRole(role);
            PredicateAssertions.ValidateRoleExists(role);
            this.role = role;
        }

        internal override bool BuildWhere(ExtentStatement statement, string alias)
        {
            var mapping = statement.Mapping;
            if (this.role.ObjectType.IsUnit)
            {
                statement.Append(" " + alias + "." + mapping.ColumnNameByRelationType[this.role.RelationType] + " IS NOT NULL");
            }
            else if ((this.role.IsMany && this.role.RelationType.AssociationType.IsMany) || !this.role.RelationType.ExistExclusiveDatabaseClasses)
            {
                statement.Append(" " + mapping.RoleJoinAlias(this.role) + "." + ColumnNameForRole + " IS NOT NULL");
            }
            else if (this.role.IsMany)
            {
                statement.Append(" " + mapping.RoleJoinAlias(this.role) + "." + ColumnNameForObject + " IS NOT NULL");
            }
            else
            {
                statement.Append(" " + alias + "." + mapping.ColumnNameByRelationType[this.role.RelationType] + " IS NOT NULL");
            }

            return this.Include;
        }

        internal override void Setup(ExtentStatement statement) => statement.UseRole(this.role);
    }
}
