namespace Allors.Repository
{
    using System;

    using Attributes;
    using static Workspaces;

    #region Allors
    [Id("a1b2c3d4-0010-4000-8000-000000000001")]
    #endregion
    public partial class WorkMaster : UniquelyIdentifiable, Deletable
    {
        #region inherited properties
        public Guid UniqueId { get; set; }

        public Revocation[] Revocations { get; set; }

        public SecurityToken[] SecurityTokens { get; set; }

        #endregion

        #region Allors
        [Id("a1b2c3d4-0010-4000-8000-000000000011")]
        #endregion
        [Indexed]
        [Required]
        [Size(256)]
        [Workspace(Default)]
        public string Name { get; set; }

        #region Allors
        [Id("a1b2c3d4-0010-4000-8000-000000000012")]
        #endregion
        [Size(2048)]
        [Workspace(Default)]
        public string Description { get; set; }

        #region Allors
        [Id("a1b2c3d4-0010-4000-8000-000000000013")]
        #endregion
        [Size(64)]
        [Workspace(Default)]
        public string Version { get; set; }

        #region Allors
        [Id("a1b2c3d4-0010-4000-8000-000000000014")]
        #endregion
        [Multiplicity(Multiplicity.ManyToOne)]
        [Indexed]
        [Required]
        [Workspace(Default)]
        public OperationsType WorkType { get; set; }

        #region Allors
        [Id("a1b2c3d4-0010-4000-8000-000000000015")]
        #endregion
        [Workspace(Default)]
        public int Duration { get; set; }

        #region Allors
        [Id("a1b2c3d4-0010-4000-8000-000000000016")]
        #endregion
        [Multiplicity(Multiplicity.ManyToOne)]
        [Indexed]
        [Workspace(Default)]
        public OperationsDefinition OperationsDefinition { get; set; }

        #region Allors
        [Id("a1b2c3d4-0010-4000-8000-000000000017")]
        #endregion
        [Multiplicity(Multiplicity.OneToMany)]
        [Indexed]
        [Workspace(Default)]
        public PersonnelRequirement[] PersonnelSpecifications { get; set; }

        #region Allors
        [Id("a1b2c3d4-0010-4000-8000-000000000018")]
        #endregion
        [Multiplicity(Multiplicity.OneToMany)]
        [Indexed]
        [Workspace(Default)]
        public EquipmentRequirement[] EquipmentSpecifications { get; set; }

        #region Allors
        [Id("a1b2c3d4-0010-4000-8000-000000000019")]
        #endregion
        [Multiplicity(Multiplicity.OneToMany)]
        [Indexed]
        [Workspace(Default)]
        public MaterialRequirement[] MaterialSpecifications { get; set; }

        #region Allors
        [Id("a1b2c3d4-0010-4000-8000-00000000001a")]
        #endregion
        [Multiplicity(Multiplicity.OneToMany)]
        [Indexed]
        [Workspace(Default)]
        public WorkMaster[] WorkMasterChildren { get; set; }

        #region inherited methods
        public void OnBuild() { }

        public void OnPostBuild() { }

        public void OnInit() { }

        public void OnPostDerive() { }

        public void Delete() { }
        #endregion
    }
}
