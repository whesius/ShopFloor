namespace Allors.Repository
{
    using System;

    using Attributes;
    using static Workspaces;

    #region Allors
    [Id("a1b2c3d4-0005-4000-8000-000000000001")]
    #endregion
    public partial class EquipmentProperty : UniquelyIdentifiable, Deletable
    {
        #region inherited properties
        public Guid UniqueId { get; set; }

        public Revocation[] Revocations { get; set; }

        public SecurityToken[] SecurityTokens { get; set; }

        #endregion

        #region Allors
        [Id("a1b2c3d4-0005-4000-8000-000000000011")]
        #endregion
        [Required]
        [Size(256)]
        [Workspace(Default)]
        public string Name { get; set; }

        #region Allors
        [Id("a1b2c3d4-0005-4000-8000-000000000012")]
        #endregion
        [Size(1024)]
        [Workspace(Default)]
        public string Description { get; set; }

        #region Allors
        [Id("a1b2c3d4-0005-4000-8000-000000000013")]
        #endregion
        [Size(1024)]
        [Workspace(Default)]
        public string Value { get; set; }

        #region Allors
        [Id("a1b2c3d4-0005-4000-8000-000000000014")]
        #endregion
        [Multiplicity(Multiplicity.ManyToOne)]
        [Indexed]
        [Workspace(Default)]
        public EquipmentClassProperty EquipmentClassProperty { get; set; }

        #region Allors
        [Id("a1b2c3d4-0005-4000-8000-000000000015")]
        #endregion
        [Multiplicity(Multiplicity.OneToMany)]
        [Indexed]
        [Workspace(Default)]
        public EquipmentProperty[] EquipmentPropertyChildren { get; set; }

        #region inherited methods
        public void OnBuild() { }

        public void OnPostBuild() { }

        public void OnInit() { }

        public void OnPostDerive() { }

        public void Delete() { }
        #endregion
    }
}
