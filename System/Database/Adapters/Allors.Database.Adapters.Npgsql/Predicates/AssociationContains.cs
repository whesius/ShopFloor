// <copyright file="AssociationContains.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Allors.Database.Adapters.Npgsql
{
    using Adapters;
    using Meta;
    using static Allors.Database.Adapters.Sql.Schema.MappingConstants;

    internal sealed class AssociationContains : Predicate
    {
        private readonly IObject allorsObject;
        private readonly IAssociationType association;

        internal AssociationContains(ExtentFiltered extent, IAssociationType association, IObject allorsObject)
        {
            extent.CheckAssociation(association);
            PredicateAssertions.AssertAssociationContains(association, allorsObject);
            this.association = association;
            this.allorsObject = allorsObject;
        }

        internal override bool BuildWhere(ExtentStatement statement, string alias)
        {
            var mapping = statement.Mapping;
            if ((this.association.IsMany && this.association.RoleType.IsMany) || !this.association.RelationType.ExistExclusiveDatabaseClasses)
            {
                statement.Append("\n");
                statement.Append("EXISTS(\n");
                statement.Append("SELECT " + alias + "." + ColumnNameForObject + "\n");
                statement.Append("FROM " + mapping.TableNameForRelationByRelationType[this.association.RelationType] + "\n");
                statement.Append("WHERE " + ColumnNameForAssociation + "=" + this.allorsObject.Strategy.ObjectId + "\n");
                statement.Append("AND " + ColumnNameForRole + "=" + alias + "." + ColumnNameForObject + "\n");
                statement.Append(")");
            }
            else
            {
                statement.Append(" " + mapping.AssociationJoinAlias(this.association) + "." + ColumnNameForObject + " = " + this.allorsObject.Strategy.ObjectId);
            }

            return this.Include;
        }

        internal override void Setup(ExtentStatement statement) => statement.UseAssociation(this.association);
    }
}
