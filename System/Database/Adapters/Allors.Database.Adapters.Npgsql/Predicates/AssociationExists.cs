// <copyright file="AssociationExists.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Allors.Database.Adapters.Npgsql
{
    using Adapters;
    using Meta;
    using static Allors.Database.Adapters.Sql.Schema.MappingConstants;

    internal sealed class AssociationExists : Predicate
    {
        private readonly IAssociationType association;

        internal AssociationExists(ExtentFiltered extent, IAssociationType association)
        {
            extent.CheckAssociation(association);
            PredicateAssertions.ValidateAssociationExists(association);
            this.association = association;
        }

        internal override bool BuildWhere(ExtentStatement statement, string alias)
        {
            var mapping = statement.Mapping;
            if ((this.association.IsMany && this.association.RelationType.RoleType.IsMany) || !this.association.RelationType.ExistExclusiveDatabaseClasses)
            {
                statement.Append(" " + mapping.AssociationJoinAlias(this.association) + "." + ColumnNameForAssociation + " IS NOT NULL");
            }
            else if (this.association.RelationType.RoleType.IsMany)
            {
                statement.Append(" " + alias + "." + mapping.ColumnNameByRelationType[this.association.RelationType] + " IS NOT NULL");
            }
            else
            {
                statement.Append(" " + mapping.AssociationJoinAlias(this.association) + "." + ColumnNameForObject + " IS NOT NULL");
            }

            return this.Include;
        }

        internal override void Setup(ExtentStatement statement) => statement.UseAssociation(this.association);
    }
}
