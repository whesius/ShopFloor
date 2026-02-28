namespace Allors.Repository
{
    using System;

    using Attributes;
    using static Workspaces;

    #region Allors
    [Id("a1b2c3d4-000e-4000-8000-000000000001")]
    #endregion
    public partial class OperationsDefinition : UniquelyIdentifiable, Deletable
    {
        #region inherited properties
        public Guid UniqueId { get; set; }

        public Revocation[] Revocations { get; set; }

        public SecurityToken[] SecurityTokens { get; set; }

        #endregion

        #region Allors
        [Id("a1b2c3d4-000e-4000-8000-000000000011")]
        #endregion
        [Indexed]
        [Required]
        [Size(256)]
        [Workspace(Default)]
        public string Name { get; set; }

        #region Allors
        [Id("a1b2c3d4-000e-4000-8000-000000000012")]
        #endregion
        [Size(1024)]
        [Workspace(Default)]
        public string Description { get; set; }

        #region Allors
        [Id("a1b2c3d4-000e-4000-8000-000000000013")]
        #endregion
        [Size(64)]
        [Workspace(Default)]
        public string Version { get; set; }

        #region Allors
        [Id("a1b2c3d4-000e-4000-8000-000000000014")]
        #endregion
        [Multiplicity(Multiplicity.ManyToOne)]
        [Indexed]
        [Required]
        [Workspace(Default)]
        public OperationsType OperationsType { get; set; }

        #region Allors
        [Id("a1b2c3d4-000e-4000-8000-000000000015")]
        #endregion
        [Multiplicity(Multiplicity.OneToMany)]
        [Indexed]
        [Workspace(Default)]
        public OperationsSegment[] OperationsSegments { get; set; }

        #region Allors
        [Id("a1b2c3d4-000e-4000-8000-000000000016")]
        #endregion
        [Workspace(Default)]
        public DateTime EffectiveStartDate { get; set; }

        #region Allors
        [Id("a1b2c3d4-000e-4000-8000-000000000017")]
        #endregion
        [Workspace(Default)]
        public DateTime EffectiveEndDate { get; set; }

        #region Allors
        [Id("a1b2c3d4-000e-4000-8000-000000000018")]
        #endregion
        [Multiplicity(Multiplicity.ManyToOne)]
        [Indexed]
        [Workspace(Default)]
        public HierarchyScope HierarchyScope { get; set; }

        #region inherited methods
        public void OnBuild() { }

        public void OnPostBuild() { }

        public void OnInit() { }

        public void OnPostDerive() { }

        public void Delete() { }
        #endregion
    }
}
