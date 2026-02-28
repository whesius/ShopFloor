namespace Allors.Database.Domain
{
    public abstract partial class ObjectsBase<T> where T : IObject
    {
        public void Prepare(Setup setup)
        {
            this.CorePrepare(setup);
            this.ShopFloorPrepare(setup);
        }

        public void Setup(Setup setup)
        {
            this.CoreSetup(setup);
            this.ShopFloorSetup(setup);
        }

        public void Prepare(Security setup)
        {
            this.CorePrepare(setup);
            this.ShopFloorPrepare(setup);
        }

        public void Secure(Security security)
        {
            this.CoreSecure(security);
            this.ShopFloorSecure(security);
        }
    }
}
