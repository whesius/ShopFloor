namespace Allors.Database.Domain
{
    public abstract partial class ObjectsBase<T>
    {
        protected virtual void ShopFloorPrepare(Setup setup)
        {
        }

        protected virtual void ShopFloorSetup(Setup setup)
        {
        }

        protected virtual void ShopFloorPrepare(Security security)
        {
        }

        protected virtual void ShopFloorSecure(Security security)
        {
        }
    }
}
