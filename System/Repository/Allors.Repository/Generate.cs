// -------------------------------------------------------------------------------------------------
// <copyright file="Generate.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>
// -------------------------------------------------------------------------------------------------

namespace Allors.Repository.Roslyn
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Domain;
    using Generation;
    using Microsoft.Build.Locator;
    using Microsoft.CodeAnalysis.MSBuild;

    public class Generate
    {
        public static void Execute(string projectPath, string template, string output)
        {
            // Register MSBuild instance (required for MSBuildWorkspace)
            if (!MSBuildLocator.IsRegistered)
            {
                MSBuildLocator.RegisterDefaults();
            }

            // Create MSBuild workspace and load the project
            using var workspace = MSBuildWorkspace.Create();
            var project = workspace.OpenProjectAsync(projectPath).Result;
            var repository = new Repository(project);

            if (repository.Exceptions.Count != 0)
            {
                throw new AggregateException(repository.Exceptions);
            }

            var templateFileInfo = new System.IO.FileInfo(template);
            var stringTemplate = new StringTemplate(templateFileInfo);
            var outputDirectoryInfo = new System.IO.DirectoryInfo(output);

            stringTemplate.Generate(repository, outputDirectoryInfo);
        }
    }
}
