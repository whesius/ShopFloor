// <copyright file="Save.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Commands
{
    using System.IO;
    using System.Xml;

    public static class Save
    {
        public static int Execute(IProgramContext context, string fileName)
        {
            var file = fileName ?? context.Configuration["populationFile"];
            var fileInfo = new FileInfo(file);

            using (var stream = File.Create(fileInfo.FullName))
            {
                using (var writer = XmlWriter.Create(stream))
                {
                    context.Database.Save(writer);
                }
            }

            return ExitCode.Success;
        }
    }
}
