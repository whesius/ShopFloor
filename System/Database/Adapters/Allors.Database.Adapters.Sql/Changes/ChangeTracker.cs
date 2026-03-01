// <copyright file="ChangeSet.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>
// <summary>
//   Defines the AllorsChangeSetMemory type.
// </summary>

namespace Allors.Database.Adapters.Sql
{
    using Ranges;

    public struct ChangeTracker
    {
        public IRange<long> Add { get; set; }

        public IRange<long> Remove { get; set; }
    }
}
