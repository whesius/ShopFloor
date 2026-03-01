// <copyright file="Program.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Allors.Tools.Cmd
{
    using System;
    using System.IO;
    using Repository;
    using Repository.Roslyn;

    public class Program
    {
        public static int Main(string[] args)
        {
            try
            {
                if (args.Length < 3)
                {
                    Console.Error.WriteLine("missing required arguments");
                }

                RepositoryGenerate(args);
            }
            catch (RepositoryException e)
            {
                Console.Error.WriteLine(e.Message);
                return 1;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                Console.WriteLine("Finished with errors");
                return 1;
            }

            Console.WriteLine("Finished");
            return 0;
        }

        private static void RepositoryGenerate(string[] args)
        {
            var projectPath = args[0];
            var template = args[1];
            var output = args[2];

            var fileInfo = new FileInfo(projectPath);

            Console.WriteLine(
                $"{fileInfo.FullName} + {new FileInfo(template).Name} -> {new FileInfo(output).FullName}");
            Generate.Execute(fileInfo.FullName, template, output);
        }
    }
}
