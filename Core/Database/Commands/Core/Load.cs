// <copyright file="Import.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Commands
{
    using System.IO;
    using System.Xml;

    public static class Load
    {
        public static int Execute(IProgramContext context, string? fileName)
        {
            var file = fileName ?? context.Configuration["populationFile"] ?? "population.xml";
            var fileInfo = new FileInfo(file);

            using (var reader = XmlReader.Create(fileInfo.FullName))
            {
                context.Database.Load(reader);
            }

            return ExitCode.Success;
        }
    }
}
