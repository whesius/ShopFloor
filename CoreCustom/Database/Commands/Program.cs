// <copyright file="Commands.cs" company="Allors bvba">
// Copyright (c) Allors bvba. All rights reserved.
// Licensed under the LGPL license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Commands
{
    using System;
    using System.CommandLine;
    using System.Data;
    using System.IO;
    using Allors.Database;
    using Allors.Database.Adapters;
    using Allors.Database.Configuration;
    using Allors.Database.Configuration.Derivations.Default;
    using Allors.Database.Domain;
    using Allors.Database.Meta;
    using Allors.Database.Meta.Configuration;
    using Allors.Database.Services;
    using Allors.Configuration;
    using Microsoft.Extensions.Configuration;
    using ObjectFactory = Allors.Database.ObjectFactory;
    using Path = System.IO.Path;
    using User = Allors.Database.Domain.User;

    public class Program
    {
        public static int Main(string[] args)
        {
            try
            {
                var rootCommand = new RootCommand("Allors Core Commands");

                // Create context factory
                Func<ProgramContext> contextFactory = () => new ProgramContext();

                // Register subcommands
                rootCommand.Subcommands.Add(CreateResetCommand(contextFactory));
                rootCommand.Subcommands.Add(CreateSaveCommand(contextFactory));
                rootCommand.Subcommands.Add(CreateLoadCommand(contextFactory));
                rootCommand.Subcommands.Add(CreateUpgradeCommand(contextFactory));
                rootCommand.Subcommands.Add(CreatePopulateCommand(contextFactory));

                var parseResult = rootCommand.Parse(args);
                return parseResult.Invoke();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return ExitCode.Error;
            }
        }

        private static Command CreateSaveCommand(Func<ProgramContext> contextFactory)
        {
            var fileOption = new Option<string>("--file", "-f")
            {
                Description = "File to save",
                DefaultValueFactory = _ => "population.xml"
            };

            var saveCommand = new Command("save", "Save the population to file");
            saveCommand.Options.Add(fileOption);

            saveCommand.SetAction(parseResult =>
            {
                var fileName = parseResult.GetValue(fileOption);
                var programContext = contextFactory();
                return Save.Execute(programContext, fileName);
            });

            return saveCommand;
        }

        private static Command CreateLoadCommand(Func<ProgramContext> contextFactory)
        {
            var fileOption = new Option<string?>("--file", "-f")
            {
                Description = "File to load (default is population.xml)"
            };

            var loadCommand = new Command("load", "Import the population from file");
            loadCommand.Options.Add(fileOption);

            loadCommand.SetAction(parseResult =>
            {
                var fileName = parseResult.GetValue(fileOption);
                var programContext = contextFactory();
                return Load.Execute(programContext, fileName);
            });

            return loadCommand;
        }

        private static Command CreateUpgradeCommand(Func<ProgramContext> contextFactory)
        {
            var fileOption = new Option<string>("--file", "-f")
            {
                Description = "File to load",
                DefaultValueFactory = _ => "population.xml"
            };

            var upgradeCommand = new Command("upgrade", "Add file contents to the index");
            upgradeCommand.Options.Add(fileOption);

            upgradeCommand.SetAction(parseResult =>
            {
                var fileName = parseResult.GetValue(fileOption);
                var programContext = contextFactory();
                return Upgrade.Execute(programContext, fileName);
            });

            return upgradeCommand;
        }

        private static Command CreatePopulateCommand(Func<ProgramContext> contextFactory)
        {
            var populateCommand = new Command("populate", "Add file contents to the index");

            populateCommand.SetAction(parseResult =>
            {
                var programContext = contextFactory();
                return Populate.Execute(programContext);
            });

            return populateCommand;
        }

        private static Command CreateResetCommand(Func<ProgramContext> contextFactory)
        {
            var resetCommand = new Command("reset", "Reset the database (drop and recreate)");

            resetCommand.SetAction(parseResult =>
            {
                var programContext = contextFactory();
                return Reset.Execute(programContext);
            });

            return resetCommand;
        }
    }

    public class ProgramContext : IProgramContext
    {
        private IConfigurationRoot configuration;
        private IDatabase database;

        public IConfigurationRoot Configuration
        {
            get
            {
                if (this.configuration == null)
                {
                    var configurationBuilder = new ConfigurationBuilder();
                    configurationBuilder.AddAllorsConfiguration("core", "commands");

                    this.configuration = configurationBuilder.Build();
                }

                return this.configuration;
            }
        }

        public DirectoryInfo DataPath => new DirectoryInfo(".").GetAncestorSibling(this.Configuration["DataPath"]);

        public IDatabase Database
        {
            get
            {
                if (this.database == null)
                {
                    var metaPopulation = new MetaBuilder().Build();
                    var engine = new Engine(Rules.Create(metaPopulation));
                    var objectFactory = new ObjectFactory(metaPopulation, typeof(User));
                    var databaseBuilder = new DatabaseBuilder(new DefaultDatabaseServices(engine), this.Configuration, objectFactory);
                    this.database = databaseBuilder.Build();
                }

                return this.database;
            }
        }

        public M M => this.Database.Services.Get<M>();
    }
}
