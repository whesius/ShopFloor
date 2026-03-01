// <copyright file="IPropertyType.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>
// <summary>Defines the RoleType type.</summary>

namespace Allors.Database.Meta
{
    /// <summary>
    /// A <see cref="ISchemaType"/> is identified in a schema by its schema name..
    /// </summary>
    public interface ISchemaType : IMetaObject
    {
        string SchemaName { get; }
    }
}
