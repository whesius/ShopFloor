// <copyright file="ISqlDatabase.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Allors.Database.Adapters.Sql
{
    using System;
    using Allors.Database.Tracing;
    using Allors.Ranges;
    using Caching;
    using Meta;
    using Schema;

    public interface ISqlDatabase : IDatabase
    {
        IObjectFactory ObjectFactory { get; }

        ICache Cache { get; }

        IRanges<long> Ranges { get; }

        ISink Sink { get; set; }

        IMapping Mapping { get; }

        string SchemaName { get; }

        int? CommandTimeout { get; }

        bool ContainsClass(IObjectType container, IObjectType containee);

        IRoleType[] GetSortedUnitRolesByObjectType(IObjectType objectType);

        Type GetDomainType(IObjectType objectType);
    }
}
