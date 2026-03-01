// <copyright file="RoleType.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>
// <summary>Defines the RoleType type.</summary>

namespace Allors.Database.Meta.Configuration
{
    public abstract partial class InterfaceRoleType : RoleType, IInterfaceRoleTypeBase
    {
        protected InterfaceRoleType(IRelationTypeBase relationType) : base(relationType)
            => this.metaPopulation.OnInterfaceRoleTypeCreated(this);
    }
}
