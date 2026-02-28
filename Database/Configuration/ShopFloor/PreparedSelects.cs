namespace Allors.Database.Configuration
{
    using System;
    using System.Collections.Concurrent;
    using Data;
    using Meta;

    public class PreparedSelects : IPreparedSelects
    {
        public PreparedSelects(M m)
        {
            this.M = m;
            this.SelectById = new ConcurrentDictionary<Guid, Select>();
        }

        public M M { get; }

        public ConcurrentDictionary<Guid, Select> SelectById { get; }

        public Select Get(Guid id)
        {
            this.SelectById.TryGetValue(id, out var @select);
            return @select;
        }
    }
}
