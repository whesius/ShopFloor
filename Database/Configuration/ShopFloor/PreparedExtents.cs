namespace Allors.Database.Configuration
{
    using System;
    using System.Collections.Concurrent;
    using Data;
    using Meta;
    using Services;

    public class PreparedExtents : IPreparedExtents
    {
        public PreparedExtents(M m)
        {
            this.M = m;
            this.ExtentById = new ConcurrentDictionary<Guid, IExtent>();
        }

        public M M { get; }

        public ConcurrentDictionary<Guid, IExtent> ExtentById { get; }

        public IExtent Get(Guid id)
        {
            this.ExtentById.TryGetValue(id, out var extent);
            return extent;
        }
    }
}
