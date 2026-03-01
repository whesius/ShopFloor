// <copyright file="ExtentStatement.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Allors.Database.Adapters.Npgsql
{
    using System.Collections.Generic;
    using Meta;
    using static Allors.Database.Adapters.Sql.Schema.MappingConstants;

    internal abstract class ExtentStatement
    {
        private readonly List<IAssociationType> referenceAssociationInstances;
        private readonly List<IAssociationType> referenceAssociations;
        private readonly List<IRoleType> referenceRoleInstances;
        private readonly List<IRoleType> referenceRoles;

        protected ExtentStatement(SqlExtent extent)
        {
            this.Extent = extent;

            this.referenceRoles = new List<IRoleType>();
            this.referenceAssociations = new List<IAssociationType>();

            this.referenceRoleInstances = new List<IRoleType>();
            this.referenceAssociationInstances = new List<IAssociationType>();
        }

        internal Mapping Mapping => this.Transaction.Database.Mapping;

        internal ExtentSort Sorter => this.Extent.Sorter;

        protected Transaction Transaction => this.Extent.Transaction;

        internal SqlExtent Extent { get; }

        internal abstract bool IsRoot { get; }

        protected IObjectType Type => this.Extent.ObjectType;

        internal void AddJoins(IObjectType rootClass, string alias)
        {
            foreach (var role in this.referenceRoles)
            {
                var relationType = role.RelationType;
                var association = relationType.AssociationType;

                if (!role.ObjectType.IsUnit)
                {
                    if ((association.IsMany && role.IsMany) || !relationType.ExistExclusiveDatabaseClasses)
                    {
                        var roleAlias = this.Mapping.RoleJoinAlias(role);
                        this.Append(" LEFT OUTER JOIN " + this.Mapping.TableNameForRelationByRelationType[relationType] + " " + roleAlias);
                        this.Append(" ON " + alias + "." + ColumnNameForObject + "=" + roleAlias + "." + ColumnNameForAssociation);
                    }
                    else if (role.IsMany)
                    {
                        var roleAlias = this.Mapping.RoleJoinAlias(role);
                        this.Append(" LEFT OUTER JOIN " + this.Mapping.TableNameForObjectByClass[((IComposite)role.ObjectType).ExclusiveDatabaseClass] + " " + roleAlias);
                        this.Append(" ON " + alias + "." + ColumnNameForObject + "=" + roleAlias + "." + this.Mapping.ColumnNameByRelationType[relationType]);
                    }
                }
            }

            foreach (var role in this.referenceRoleInstances)
            {
                var relationType = role.RelationType;

                if (!role.ObjectType.IsUnit && role.IsOne)
                {
                    var roleInstanceAlias = this.Mapping.RoleInstanceJoinAlias(role);
                    var roleAlias = this.Mapping.RoleJoinAlias(role);
                    if (!relationType.ExistExclusiveDatabaseClasses)
                    {
                        this.Append(" LEFT OUTER JOIN " + this.Mapping.TableNameForObjects + " " + roleInstanceAlias);
                        this.Append(" ON " + roleInstanceAlias + "." + ColumnNameForObject + "=" + roleAlias + "." + ColumnNameForRole + " ");
                    }
                    else
                    {
                        this.Append(" LEFT OUTER JOIN " + this.Mapping.TableNameForObjects + " " + roleInstanceAlias);
                        this.Append(" ON " + roleInstanceAlias + "." + ColumnNameForObject + "=" + alias + "." + this.Mapping.ColumnNameByRelationType[relationType] + " ");
                    }
                }
            }

            foreach (var association in this.referenceAssociations)
            {
                var relationType = association.RelationType;
                var role = relationType.RoleType;

                if ((association.IsMany && role.IsMany) || !relationType.ExistExclusiveDatabaseClasses)
                {
                    var assocAlias = this.Mapping.AssociationJoinAlias(association);
                    this.Append(" LEFT OUTER JOIN " + this.Mapping.TableNameForRelationByRelationType[relationType] + " " + assocAlias);
                    this.Append(" ON " + alias + "." + ColumnNameForObject + "=" + assocAlias + "." + ColumnNameForRole);
                }
                else if (!role.IsMany)
                {
                    var assocAlias = this.Mapping.AssociationJoinAlias(association);
                    this.Append(" LEFT OUTER JOIN " + this.Mapping.TableNameForObjectByClass[association.ObjectType.ExclusiveDatabaseClass] + " " + assocAlias);
                    this.Append(" ON " + alias + "." + ColumnNameForObject + "=" + assocAlias + "." + this.Mapping.ColumnNameByRelationType[relationType]);
                }
            }

            foreach (var association in this.referenceAssociationInstances)
            {
                var relationType = association.RelationType;
                var role = relationType.RoleType;

                if (!association.ObjectType.IsUnit && association.IsOne)
                {
                    var assocInstanceAlias = this.Mapping.AssociationInstanceJoinAlias(association);
                    var assocAlias = this.Mapping.AssociationJoinAlias(association);
                    if (!relationType.ExistExclusiveDatabaseClasses)
                    {
                        this.Append(" LEFT OUTER JOIN " + this.Mapping.TableNameForObjects + " " + assocInstanceAlias);
                        this.Append(" ON " + assocInstanceAlias + "." + ColumnNameForObject + "=" + assocAlias + "." + ColumnNameForAssociation + " ");
                    }
                    else if (role.IsOne)
                    {
                        this.Append(" LEFT OUTER JOIN " + this.Mapping.TableNameForObjects + " " + assocInstanceAlias);
                        this.Append(" ON " + assocInstanceAlias + "." + ColumnNameForObject + "=" + assocAlias + "." + ColumnNameForObject + " ");
                    }
                    else
                    {
                        this.Append(" LEFT OUTER JOIN " + this.Mapping.TableNameForObjects + " " + assocInstanceAlias);
                        this.Append(" ON " + assocInstanceAlias + "." + ColumnNameForObject + "=" + alias + "." + this.Mapping.ColumnNameByRelationType[relationType] + " ");
                    }
                }
            }
        }

        internal abstract string AddParameter(object obj);

        internal bool AddWhere(IObjectType rootClass, string alias)
        {
            var useWhere = !this.Extent.ObjectType.ExistExclusiveDatabaseClass;

            if (useWhere)
            {
                this.Append(" WHERE ( ");
                if (!this.Type.IsInterface)
                {
                    this.Append(" " + alias + "." + ColumnNameForClass + "=" + this.AddParameter(this.Type.Id));
                }
                else
                {
                    var first = true;
                    foreach (var subClass in ((IInterface)this.Type).DatabaseClasses)
                    {
                        if (first)
                        {
                            first = false;
                        }
                        else
                        {
                            this.Append(" OR ");
                        }

                        this.Append(" " + alias + "." + ColumnNameForClass + "=" + this.AddParameter(subClass.Id));
                    }
                }

                this.Append(" ) ");
            }

            return useWhere;
        }

        internal abstract void Append(string part);

        internal abstract string CreateAlias();

        internal abstract ExtentStatement CreateChild(SqlExtent extent, IAssociationType association);

        internal abstract ExtentStatement CreateChild(SqlExtent extent, IRoleType role);

        internal string GetJoinName(IAssociationType association) => this.Mapping.AssociationInstanceJoinAlias(association);

        internal string GetJoinName(IRoleType role) => this.Mapping.RoleInstanceJoinAlias(role);

        internal void UseAssociation(IAssociationType association)
        {
            if (!association.ObjectType.IsUnit && !this.referenceAssociations.Contains(association))
            {
                this.referenceAssociations.Add(association);
            }
        }

        internal void UseAssociationInstance(IAssociationType association)
        {
            if (!this.referenceAssociationInstances.Contains(association))
            {
                this.referenceAssociationInstances.Add(association);
            }
        }

        internal void UseRole(IRoleType role)
        {
            if (!role.ObjectType.IsUnit && !this.referenceRoles.Contains(role))
            {
                this.referenceRoles.Add(role);
            }
        }

        internal void UseRoleInstance(IRoleType role)
        {
            if (!this.referenceRoleInstances.Contains(role))
            {
                this.referenceRoleInstances.Add(role);
            }
        }
    }
}
