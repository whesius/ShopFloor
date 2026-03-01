// <copyright file="IMapping.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Allors.Database.Adapters.Sql.Schema
{
    using System.Collections.Generic;
    using Meta;

    public interface IMapping
    {
        string StringCollation { get; }

        string TableNameForObjects { get; }

        IDictionary<IClass, string> TableNameForObjectByClass { get; }

        IDictionary<IRelationType, string> TableNameForRelationByRelationType { get; }

        IDictionary<IRelationType, string> ColumnNameByRelationType { get; }

        string ParamInvocationFormat { get; }

        string ParamInvocationNameForObject { get; }

        string ParamInvocationNameForClass { get; }

        string ParamInvocationNameForCount { get; }

        string ParamInvocationNameForAssociation { get; }

        string ParamInvocationNameForCompositeRole { get; }

        IDictionary<IRoleType, string> ParamInvocationNameByRoleType { get; }

        string ObjectArrayParamInvocationName { get; }

        string CompositeRoleArrayParamInvocationName { get; }

        string Ascending { get; }

        string Descending { get; }

        IDictionary<IClass, string> ProcedureNameForDeleteObjectByClass { get; }

        IDictionary<IClass, string> ProcedureNameForGetUnitRolesByClass { get; }

        IDictionary<IClass, string> ProcedureNameForCreateObjectByClass { get; }

        IDictionary<IClass, string> ProcedureNameForCreateObjectsByClass { get; }

        IDictionary<IClass, IDictionary<IRelationType, string>> ProcedureNameForSetUnitRoleByRelationTypeByClass { get; }

        IDictionary<IRelationType, string> ProcedureNameForGetRoleByRelationType { get; }

        IDictionary<IRelationType, string> ProcedureNameForSetRoleByRelationType { get; }

        IDictionary<IRelationType, string> ProcedureNameForAddRoleByRelationType { get; }

        IDictionary<IRelationType, string> ProcedureNameForRemoveRoleByRelationType { get; }

        IDictionary<IRelationType, string> ProcedureNameForClearRoleByRelationType { get; }

        IDictionary<IRelationType, string> ProcedureNameForGetAssociationByRelationType { get; }

        string ProcedureNameForInstantiate { get; }

        string ProcedureNameForGetVersion { get; }

        string ProcedureNameForUpdateVersion { get; }

        IDictionary<IClass, string> ProcedureNameForPrefetchUnitRolesByClass { get; }

        IDictionary<IRelationType, string> ProcedureNameForPrefetchRoleByRelationType { get; }

        IDictionary<IRelationType, string> ProcedureNameForPrefetchAssociationByRelationType { get; }

        string RoleJoinAlias(IRoleType role);

        string AssociationJoinAlias(IAssociationType association);

        string RoleInstanceJoinAlias(IRoleType role);

        string AssociationInstanceJoinAlias(IAssociationType association);
    }
}
