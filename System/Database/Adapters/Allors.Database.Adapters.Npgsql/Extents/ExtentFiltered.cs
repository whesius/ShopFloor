// <copyright file="ExtentFiltered.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Allors.Database.Adapters.Npgsql
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Meta;
    using static Allors.Database.Adapters.Sql.Schema.MappingConstants;

    internal class ExtentFiltered : SqlExtent
    {
        private readonly Transaction transaction;
        private readonly IComposite objectType;

        private AndPredicate filter;

        internal ExtentFiltered(Transaction transaction, Strategy strategy, IRoleType roleType)
            : this(transaction, (IComposite)roleType.ObjectType)
        {
            this.Strategy = strategy;
            this.RoleType = roleType;
        }

        internal ExtentFiltered(Transaction transaction, Strategy strategy, IAssociationType associationType)
            : this(transaction, associationType.ObjectType)
        {
            this.Strategy = strategy;
            this.AssociationType = associationType;
        }

        internal ExtentFiltered(Transaction transaction, IComposite objectType)
        {
            this.transaction = transaction;
            this.objectType = objectType;
        }

        public override ICompositePredicate Filter
        {
            get
            {
                this.LazyLoadFilter();
                return this.filter;
            }
        }

        internal Mapping Mapping => this.transaction.Database.Mapping;

        public override IComposite ObjectType => this.objectType;

        internal override Transaction Transaction => this.transaction;

        internal IAssociationType AssociationType { get; private set; }

        internal IRoleType RoleType { get; private set; }

        internal Strategy Strategy { get; private set; }

        internal override string BuildSql(ExtentStatement statement)
        {
            this.LazyLoadFilter();
            this.filter.Setup(statement);

            if (this.objectType.ExistDatabaseClass)
            {
                if (this.objectType.ExistExclusiveDatabaseClass)
                {
                    return this.BuildSqlWithExclusiveClass(statement);
                }

                return this.BuildSqlWithClasses(statement);
            }

            return null;
        }

        internal void CheckAssociation(IAssociationType associationType)
        {
            if (!this.objectType.ExistAssociationType(associationType))
            {
                throw new ArgumentException("Extent does not have association " + associationType);
            }
        }

        internal void CheckRole(IRoleType roleType)
        {
            if (!this.objectType.ExistRoleType(roleType))
            {
                throw new ArgumentException("Extent does not have role " + roleType.SingularName);
            }
        }

        protected override IList<long> GetObjectIds()
        {
            if (this.Strategy != null)
            {
                if (this.AssociationType != null)
                {
                    return this.Strategy.ExtentGetCompositeAssociations(this.AssociationType);
                }

                return this.Strategy.GetCompositesRole(this.RoleType).ToList();
            }

            this.transaction.State.Flush();

            var statement = new ExtentStatementRoot(this);
            var objectIds = new List<long>();

            var alias = this.BuildSql(statement);

            using var command = statement.CreateDbCommand(alias);
            if (command == null)
            {
                return objectIds;
            }

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var objectId = this.transaction.State.GetObjectIdForExistingObject(reader.GetValue(0).ToString());
                objectIds.Add(objectId);
            }

            return objectIds;
        }

        /// <summary>
        /// Lazy loads the filter.
        /// Should also be used to upgrade from a strategy extent to a full extent.
        /// </summary>
        protected override void LazyLoadFilter()
        {
            if (this.filter == null)
            {
                this.filter = new AndPredicate(this);
                this.Strategy = null;
                this.AssociationType = null;
                this.RoleType = null;
                this.FlushCache();
            }
        }

        private string BuildSqlWithExclusiveClass(ExtentStatement statement)
        {
            var alias = statement.CreateAlias();
            var rootClass = this.objectType.ExclusiveDatabaseClass;

            if (statement.IsRoot)
            {
                statement.Append("SELECT DISTINCT " + alias + "." + ColumnNameForObject);
                statement.Sorter?.BuildSelect(statement, alias);

                statement.Append(" FROM " + this.Mapping.TableNameForObjectByClass[rootClass] + " " + alias);
                statement.AddJoins(rootClass, alias);
                statement.AddWhere(rootClass, alias);
                this.filter?.BuildWhere(statement, alias);
            }
            else
            {
                // ContainedIn
                var inStatement = (ExtentStatementChild)statement;

                if (inStatement.RoleType != null)
                {
                    var inRole = inStatement.RoleType;
                    var inIRelationType = inRole.RelationType;
                    if (inIRelationType.Multiplicity == Multiplicity.ManyToMany || !inIRelationType.ExistExclusiveDatabaseClasses)
                    {
                        statement.Append("SELECT " + this.Mapping.AssociationJoinAlias(inRole.AssociationType) + "." + ColumnNameForAssociation);
                    }
                    else if (inRole.IsMany)
                    {
                        statement.Append("SELECT " + alias + "." + ColumnNameForObject);
                    }
                    else
                    {
                        statement.Append("SELECT " + this.Mapping.AssociationJoinAlias(inRole.AssociationType) + "." + this.Mapping.ColumnNameByRelationType[inRole.RelationType]);
                    }

                    statement.Append(" FROM " + this.Mapping.TableNameForObjectByClass[rootClass] + " " + alias);
                    statement.AddJoins(rootClass, alias);

                    var wherePresent = statement.AddWhere(rootClass, alias);
                    var filterUsed = false;
                    if (this.filter != null)
                    {
                        filterUsed = this.filter.BuildWhere(statement, alias);
                    }

                    if (wherePresent || filterUsed)
                    {
                        statement.Append(" AND ");
                    }
                    else
                    {
                        statement.Append(" WHERE ");
                    }

                    if (inIRelationType.Multiplicity == Multiplicity.ManyToMany || !inIRelationType.ExistExclusiveDatabaseClasses)
                    {
                        statement.Append(this.Mapping.AssociationJoinAlias(inRole.AssociationType) + "." + ColumnNameForAssociation + " IS NOT NULL ");
                    }
                    else if (inRole.IsMany)
                    {
                        statement.Append(alias + "." + this.Mapping.ColumnNameByRelationType[inRole.RelationType] + " IS NOT NULL ");
                    }
                    else
                    {
                        statement.Append(this.Mapping.AssociationJoinAlias(inRole.AssociationType) + "." + this.Mapping.ColumnNameByRelationType[inRole.RelationType] + " IS NOT NULL ");
                    }
                }
                else
                {
                    if (statement.IsRoot)
                    {
                        statement.Append("SELECT " + alias + "." + ColumnNameForObject);
                        if (statement.Sorter != null)
                        {
                            statement.Sorter.BuildSelect(statement);
                        }
                    }
                    else
                    {
                        statement.Append("SELECT " + alias + "." + ColumnNameForObject);
                    }

                    statement.Append(" FROM " + this.Mapping.TableNameForObjectByClass[rootClass] + " " + alias);

                    statement.AddJoins(rootClass, alias);
                    statement.AddWhere(rootClass, alias);

                    if (this.filter != null)
                    {
                        this.filter.BuildWhere(statement, alias);
                    }
                }
            }

            return alias;
        }

        private string BuildSqlWithClasses(ExtentStatement statement)
        {
            if (statement.IsRoot)
            {
                var databaseClasses = this.objectType.DatabaseClasses.ToArray();
                for (var i = 0; i < databaseClasses.Length; i++)
                {
                    var alias = statement.CreateAlias();
                    var rootClass = databaseClasses[i];

                    statement.Append("SELECT " + alias + "." + ColumnNameForObject);
                    if (statement.Sorter != null)
                    {
                        statement.Sorter.BuildSelect(statement);
                    }

                    statement.Append(" FROM " + this.Mapping.TableNameForObjectByClass[rootClass] + " " + alias);

                    statement.AddJoins(rootClass, alias);
                    statement.AddWhere(rootClass, alias);

                    if (this.filter != null)
                    {
                        this.filter.BuildWhere(statement, alias);
                    }

                    if (i < databaseClasses.Length - 1)
                    {
                        statement.Append("\nUNION\n");
                    }
                }
            }
            else
            {
                var inStatement = (ExtentStatementChild)statement;

                if (inStatement.RoleType != null)
                {
                    var useUnion = false;
                    foreach (var rootClass in this.objectType.DatabaseClasses)
                    {
                        var inRole = inStatement.RoleType;
                        var inIRelationType = inRole.RelationType;

                        if (!((IComposite)inRole.ObjectType).DatabaseClasses.Contains(rootClass))
                        {
                            continue;
                        }

                        if (useUnion)
                        {
                            statement.Append("\nUNION\n");
                        }
                        else
                        {
                            useUnion = true;
                        }

                        var alias = statement.CreateAlias();

                        if (inIRelationType.Multiplicity == Multiplicity.ManyToMany || !inIRelationType.ExistExclusiveDatabaseClasses)
                        {
                            statement.Append("SELECT " + this.Mapping.AssociationJoinAlias(inRole.AssociationType) + "." + ColumnNameForAssociation);
                        }
                        else if (inRole.IsMany)
                        {
                            statement.Append("SELECT " + alias + "." + ColumnNameForObject);
                        }
                        else
                        {
                            statement.Append("SELECT " + this.Mapping.AssociationJoinAlias(inRole.AssociationType) + "." + this.Mapping.ColumnNameByRelationType[inRole.RelationType]);
                        }

                        statement.Append(" FROM " + this.Mapping.TableNameForObjectByClass[rootClass] + " " + alias);

                        statement.AddJoins(rootClass, alias);

                        var wherePresent = statement.AddWhere(rootClass, alias);
                        var filterUsed = false;
                        if (this.filter != null)
                        {
                            filterUsed = this.filter.BuildWhere(statement, alias);
                        }

                        if (wherePresent || filterUsed)
                        {
                            statement.Append(" AND ");
                        }
                        else
                        {
                            statement.Append(" WHERE ");
                        }

                        if (inIRelationType.Multiplicity == Multiplicity.ManyToMany || !inIRelationType.ExistExclusiveDatabaseClasses)
                        {
                            statement.Append(this.Mapping.AssociationJoinAlias(inRole.AssociationType) + "." + ColumnNameForAssociation + " IS NOT NULL ");
                        }
                        else if (inRole.IsMany)
                        {
                            statement.Append(alias + "." + this.Mapping.ColumnNameByRelationType[inRole.RelationType] + " IS NOT NULL ");
                        }
                        else
                        {
                            statement.Append(this.Mapping.AssociationJoinAlias(inRole.AssociationType) + "." + this.Mapping.ColumnNameByRelationType[inRole.RelationType] + " IS NOT NULL ");
                        }
                    }
                }
                else
                {
                    var databaseClasses = this.objectType.DatabaseClasses.ToArray();
                    for (var i = 0; i < databaseClasses.Length; i++)
                    {
                        var alias = statement.CreateAlias();
                        var rootClass = databaseClasses[i];

                        if (statement.IsRoot)
                        {
                            statement.Append("SELECT " + alias + "." + ColumnNameForObject);
                            statement.Sorter?.BuildSelect(statement);
                        }
                        else
                        {
                            statement.Append("SELECT " + alias + "." + ColumnNameForObject);
                        }

                        statement.Append(" FROM " + this.Mapping.TableNameForObjectByClass[rootClass] + " " + alias);

                        statement.AddJoins(rootClass, alias);
                        statement.AddWhere(rootClass, alias);

                        this.filter?.BuildWhere(statement, alias);

                        if (i < databaseClasses.Length - 1)
                        {
                            statement.Append("\nUNION\n");
                        }
                    }
                }
            }

            return null;
        }
    }
}
