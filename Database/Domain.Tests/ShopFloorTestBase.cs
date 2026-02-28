namespace Allors.Database.Domain.Tests
{
    using System;
    using Adapters.Memory;
    using Configuration;
    using Configuration.Derivations.Default;
    using Meta;
    using Meta.Configuration;

    public abstract class ShopFloorTestBase : IDisposable
    {
        protected IDatabase Database { get; }
        protected ITransaction Transaction { get; private set; }
        protected M M { get; }

        protected ShopFloorTestBase()
        {
            var metaPopulation = new MetaBuilder().Build();
            var engine = new Engine(Rules.Create(metaPopulation));
            var objectFactory = new ObjectFactory(metaPopulation, typeof(Allors.Database.Domain.User));

            this.Database = new Database(
                new DefaultDatabaseServices(engine),
                new Allors.Database.Adapters.Memory.Configuration
                {
                    ObjectFactory = objectFactory,
                });

            this.Database.Init();

            var config = new Config();
            new Setup(this.Database, config).Apply();

            this.Transaction = this.Database.CreateTransaction();
            this.M = this.Transaction.Database.Services.Get<M>();
        }

        public void Dispose()
        {
            this.Transaction?.Dispose();
        }
    }
}
