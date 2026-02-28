namespace Allors.Database.Domain
{
    public partial class Setup
    {
        private void OnPrePrepare()
        {
            this.CoreOnPrePrepare();
            this.ShopFloorOnPrePrepare();
        }

        private void OnPostPrepare()
        {
            this.CoreOnPostPrepare();
            this.ShopFloorOnPostPrepare();
        }

        private void OnPreSetup()
        {
            this.CoreOnPreSetup();
            this.ShopFloorOnPreSetup();
        }

        private void OnPostSetup(Config config)
        {
            this.CoreOnPostSetup(config);
            this.ShopFloorOnPostSetup(config);
        }
    }
}
