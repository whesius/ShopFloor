namespace Allors.Repository
{
    using System;

    using Attributes;
    using static Workspaces;

    #region Allors
    [Id("a1b2c3d4-0012-4000-8000-000000000001")]
    #endregion
    public partial class JobOrder : UniquelyIdentifiable, Deletable
    {
        #region inherited properties
        public Guid UniqueId { get; set; }

        public Revocation[] Revocations { get; set; }

        public SecurityToken[] SecurityTokens { get; set; }

        #endregion

        #region Allors
        [Id("a1b2c3d4-0012-4000-8000-000000000011")]
        #endregion
        [Indexed]
        [Required]
        [Size(256)]
        [Workspace(Default)]
        public string Name { get; set; }

        #region Allors
        [Id("a1b2c3d4-0012-4000-8000-000000000012")]
        #endregion
        [Size(2048)]
        [Workspace(Default)]
        public string Description { get; set; }

        #region Allors
        [Id("a1b2c3d4-0012-4000-8000-000000000013")]
        #endregion
        [Multiplicity(Multiplicity.ManyToOne)]
        [Indexed]
        [Required]
        [Workspace(Default)]
        public OperationsType WorkType { get; set; }

        #region Allors
        [Id("a1b2c3d4-0012-4000-8000-000000000014")]
        #endregion
        [Multiplicity(Multiplicity.ManyToOne)]
        [Indexed]
        [Workspace(Default)]
        public WorkMaster WorkMaster { get; set; }

        #region Allors
        [Id("a1b2c3d4-0012-4000-8000-000000000015")]
        #endregion
        [Multiplicity(Multiplicity.ManyToOne)]
        [Indexed]
        [Workspace(Default)]
        public Equipment Equipment { get; set; }

        #region Allors
        [Id("a1b2c3d4-0012-4000-8000-000000000016")]
        #endregion
        [Workspace(Default)]
        public int Priority { get; set; }

        #region Allors
        [Id("a1b2c3d4-0012-4000-8000-000000000017")]
        #endregion
        [Multiplicity(Multiplicity.ManyToOne)]
        [Indexed]
        [Required]
        [Workspace(Default)]
        public DispatchStatus DispatchStatus { get; set; }

        #region Allors
        [Id("a1b2c3d4-0012-4000-8000-000000000018")]
        #endregion
        [Workspace(Default)]
        public DateTime StartTime { get; set; }

        #region Allors
        [Id("a1b2c3d4-0012-4000-8000-000000000019")]
        #endregion
        [Workspace(Default)]
        public DateTime EndTime { get; set; }

        #region Allors
        [Id("a1b2c3d4-0012-4000-8000-00000000001a")]
        #endregion
        [Multiplicity(Multiplicity.ManyToOne)]
        [Indexed]
        [Workspace(Default)]
        public HierarchyScope HierarchyScope { get; set; }

        #region Allors
        [Id("a1b2c3d4-0012-4000-8000-00000000001b")]
        #endregion
        [Multiplicity(Multiplicity.OneToMany)]
        [Indexed]
        [Workspace(Default)]
        public PersonnelRequirement[] PersonnelRequirements { get; set; }

        #region Allors
        [Id("a1b2c3d4-0012-4000-8000-00000000001c")]
        #endregion
        [Multiplicity(Multiplicity.OneToMany)]
        [Indexed]
        [Workspace(Default)]
        public EquipmentRequirement[] EquipmentRequirements { get; set; }

        #region Allors
        [Id("a1b2c3d4-0012-4000-8000-00000000001d")]
        #endregion
        [Multiplicity(Multiplicity.OneToMany)]
        [Indexed]
        [Workspace(Default)]
        public MaterialRequirement[] MaterialRequirements { get; set; }

        #region Allors
        [Id("a1b2c3d4-0012-4000-8000-00000000001e")]
        #endregion
        [Multiplicity(Multiplicity.ManyToOne)]
        [Indexed]
        [Workspace(Default)]
        public Person AssignedTo { get; set; }

        #region Allors
        [Id("a1b2c3d4-0012-4000-8000-00000000001f")]
        #endregion
        [Multiplicity(Multiplicity.OneToOne)]
        [Indexed]
        [Workspace(Default)]
        public JobResponse Response { get; set; }

        #region inherited methods
        public void OnBuild() { }

        public void OnPostBuild() { }

        public void OnInit() { }

        public void OnPostDerive() { }

        public void Delete() { }
        #endregion
    }
}
