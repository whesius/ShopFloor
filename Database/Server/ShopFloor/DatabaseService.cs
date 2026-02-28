namespace Allors.Services
{
    using Database;

    public class DatabaseService : IDatabaseService
    {
        public DatabaseService(IDatabase database) => this.Database = database;

        public IDatabase Database { get; private set; }

        public void Restart() => this.Database = null;
    }
}
