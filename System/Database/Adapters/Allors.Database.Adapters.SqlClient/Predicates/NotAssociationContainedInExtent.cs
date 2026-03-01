// <copyright file="NotAssociationContainedInExtent.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Allors.Database.Adapters.SqlClient
{
    using Adapters;

    using Meta;
    using static Allors.Database.Adapters.Sql.Schema.MappingConstants;

    internal sealed class NotAssociationContainedInExtent : ContainedIn
    {
        private readonly IAssociationType association;
        private readonly SqlExtent inExtent;

        internal NotAssociationContainedInExtent(ExtentFiltered extent, IAssociationType association, Allors.Database.Extent inExtent)
        {
            extent.CheckAssociation(association);
            PredicateAssertions.AssertAssociationContainedIn(association, inExtent);
            this.association = association;
            this.inExtent = ((Extent)inExtent).ContainedInExtent;
        }

        internal override bool IsNotFilter => true;

        internal override bool BuildWhere(ExtentStatement statement, string alias)
        {
            var mapping = statement.Mapping;
            var inStatement = statement.CreateChild(this.inExtent, this.association);

            inStatement.UseRole(this.association.RoleType);

            if ((this.association.IsMany && this.association.RoleType.IsMany) || !this.association.RelationType.ExistExclusiveDatabaseClasses)
            {
                statement.Append(" (" + mapping.AssociationJoinAlias(this.association) + "." + ColumnNameForRole + " IS NULL OR");
                statement.Append(" NOT " + mapping.AssociationJoinAlias(this.association) + "." + ColumnNameForRole + " IN (\n");
                statement.Append(" SELECT " + ColumnNameForRole + " FROM " + mapping.TableNameForRelationByRelationType[this.association.RelationType] + " WHERE " + ColumnNameForAssociation + " IN (");
                this.inExtent.BuildSql(inStatement);
                statement.Append(" )))\n");
            }
            else if (this.association.RoleType.IsMany)
            {
                statement.Append(" (" + alias + "." + mapping.ColumnNameByRelationType[this.association.RelationType] + " IS NULL OR ");
                statement.Append(" NOT " + alias + "." + mapping.ColumnNameByRelationType[this.association.RelationType] + " IN (\n");
                this.inExtent.BuildSql(inStatement);
                statement.Append(" ))\n");
            }
            else
            {
                statement.Append(" (" + mapping.AssociationJoinAlias(this.association) + "." + ColumnNameForObject + " IS NULL OR ");
                statement.Append(" NOT " + mapping.AssociationJoinAlias(this.association) + "." + ColumnNameForObject + " IN (\n");
                this.inExtent.BuildSql(inStatement);
                statement.Append(" ))\n");
            }

            return this.Include;
        }

        internal override void Setup(ExtentStatement statement) => statement.UseAssociation(this.association);
    }
}
