namespace Allors.Database.Domain
{
    public partial class Security
    {
        private void OnPreSetup()
        {
            this.CoreOnPreSetup();
            this.ShopFloorOnPreSetup();
        }

        private void OnPostSetup()
        {
            this.CoreOnPostSetup();
            this.ShopFloorOnPostSetup();
        }
    }
}
