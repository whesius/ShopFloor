// <copyright file="RoleContains.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>
// <summary>
//   Defines the AllorsPredicateRoleContainsSql type.
// </summary>

namespace Allors.Database.Adapters.Npgsql
{
    using Adapters;
    using Meta;
    using static Allors.Database.Adapters.Sql.Schema.MappingConstants;

    internal sealed class RoleContains : Predicate
    {
        private readonly IObject allorsObject;
        private readonly IRoleType role;

        internal RoleContains(ExtentFiltered extent, IRoleType role, IObject allorsObject)
        {
            extent.CheckRole(role);
            PredicateAssertions.ValidateRoleContains(role, allorsObject);
            this.role = role;
            this.allorsObject = allorsObject;
        }

        internal override bool BuildWhere(ExtentStatement statement, string alias)
        {
            var mapping = statement.Mapping;
            if ((this.role.IsMany && this.role.RelationType.AssociationType.IsMany) || !this.role.RelationType.ExistExclusiveDatabaseClasses)
            {
                statement.Append("\n");
                statement.Append("EXISTS(\n");
                statement.Append("SELECT " + alias + "." + ColumnNameForObject + "\n");
                statement.Append("FROM " + mapping.TableNameForRelationByRelationType[this.role.RelationType] + "\n");
                statement.Append("WHERE   " + ColumnNameForAssociation + "=" + alias + "." + ColumnNameForObject + "\n");
                statement.Append("AND " + ColumnNameForRole + "=" + this.allorsObject.Strategy.ObjectId + "\n");
                statement.Append(")\n");
            }
            else
            {
                // This join is not possible because of the 3VL (Three Valued Logic).
                // It should work for normal queries, but it fails when wrapped in a NOT( ... ) predicate.
                // The rows with NULL values should then return TRUE and not UNKNOWN.
                statement.Append("\n");
                statement.Append("EXISTS(\n");
                statement.Append("SELECT " + ColumnNameForObject + "\n");
                statement.Append("FROM " + mapping.TableNameForObjectByClass[((IComposite)this.role.ObjectType).ExclusiveDatabaseClass] + "\n");
                statement.Append("WHERE " + ColumnNameForObject + "=" + this.allorsObject.Strategy.ObjectId + "\n");
                statement.Append("AND " + mapping.ColumnNameByRelationType[this.role.RelationType] + "=" + alias + "." + ColumnNameForObject + "\n");
                statement.Append(")\n");
            }

            return this.Include;
        }

        internal override void Setup(ExtentStatement statement)
        {
            // extent.UseRole(role);
        }
    }
}
