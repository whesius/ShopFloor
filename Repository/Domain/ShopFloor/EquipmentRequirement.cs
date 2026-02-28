namespace Allors.Repository
{
    using System;

    using Attributes;
    using static Workspaces;

    #region Allors
    [Id("a1b2c3d4-0015-4000-8000-000000000001")]
    #endregion
    public partial class EquipmentRequirement : UniquelyIdentifiable, Deletable
    {
        #region inherited properties
        public Guid UniqueId { get; set; }

        public Revocation[] Revocations { get; set; }

        public SecurityToken[] SecurityTokens { get; set; }

        #endregion

        #region Allors
        [Id("a1b2c3d4-0015-4000-8000-000000000011")]
        #endregion
        [Multiplicity(Multiplicity.ManyToOne)]
        [Indexed]
        [Workspace(Default)]
        public EquipmentClass EquipmentClass { get; set; }

        #region Allors
        [Id("a1b2c3d4-0015-4000-8000-000000000012")]
        #endregion
        [Multiplicity(Multiplicity.ManyToOne)]
        [Indexed]
        [Workspace(Default)]
        public Equipment Equipment { get; set; }

        #region Allors
        [Id("a1b2c3d4-0015-4000-8000-000000000013")]
        #endregion
        [Workspace(Default)]
        public int Quantity { get; set; }

        #region Allors
        [Id("a1b2c3d4-0015-4000-8000-000000000014")]
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
