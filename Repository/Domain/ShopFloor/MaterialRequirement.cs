namespace Allors.Repository
{
    using System;

    using Attributes;
    using static Workspaces;

    #region Allors
    [Id("a1b2c3d4-0016-4000-8000-000000000001")]
    #endregion
    public partial class MaterialRequirement : UniquelyIdentifiable, Deletable
    {
        #region inherited properties
        public Guid UniqueId { get; set; }

        public Revocation[] Revocations { get; set; }

        public SecurityToken[] SecurityTokens { get; set; }

        #endregion

        #region Allors
        [Id("a1b2c3d4-0016-4000-8000-000000000011")]
        #endregion
        [Required]
        [Size(256)]
        [Workspace(Default)]
        public string Name { get; set; }

        #region Allors
        [Id("a1b2c3d4-0016-4000-8000-000000000012")]
        #endregion
        [Workspace(Default)]
        public int Quantity { get; set; }

        #region Allors
        [Id("a1b2c3d4-0016-4000-8000-000000000013")]
        #endregion
        [Size(1024)]
        [Workspace(Default)]
        public string Description { get; set; }

        #region inherited methods
        public void OnBuild() { }

        public void OnPostBuild() { }

        public void OnInit() { }

        public void OnPostDerive() { }

        public void Delete() { }
        #endregion
    }
}
