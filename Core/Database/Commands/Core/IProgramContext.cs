// <copyright file="Commands.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Commands
{
    using System.IO;
    using Allors.Database;
    using Allors.Database.Meta;
    using Microsoft.Extensions.Configuration;


    public interface IProgramContext
    {
        IConfigurationRoot Configuration { get; }
        IDatabase Database { get; }
        M M { get; }
        DirectoryInfo DataPath { get; }
    }
}
