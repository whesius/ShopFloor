namespace Commands
{
    using System;
    using System.CommandLine;
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
                var rootCommand = new RootCommand("ShopFloor Commands");

                Func<ProgramContext> contextFactory = () => new ProgramContext();

                rootCommand.Subcommands.Add(CreatePopulateCommand(contextFactory));
                rootCommand.Subcommands.Add(CreateResetCommand(contextFactory));

                var parseResult = rootCommand.Parse(args);
                return parseResult.Invoke();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return ExitCode.Error;
            }
        }

        private static Command CreatePopulateCommand(Func<ProgramContext> contextFactory)
        {
            var populateCommand = new Command("populate", "Initialize database with schema and seed data");

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
                    configurationBuilder.AddAllorsConfiguration("shopfloor", "commands");

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
