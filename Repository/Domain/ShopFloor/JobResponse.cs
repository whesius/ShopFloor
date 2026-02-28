namespace Allors.Repository
{
    using System;

    using Attributes;
    using static Workspaces;

    #region Allors
    [Id("a1b2c3d4-0013-4000-8000-000000000001")]
    #endregion
    public partial class JobResponse : UniquelyIdentifiable, Deletable
    {
        #region inherited properties
        public Guid UniqueId { get; set; }

        public Revocation[] Revocations { get; set; }

        public SecurityToken[] SecurityTokens { get; set; }

        #endregion

        #region Allors
        [Id("a1b2c3d4-0013-4000-8000-000000000011")]
        #endregion
        [Size(2048)]
        [Workspace(Default)]
        public string Description { get; set; }

        #region Allors
        [Id("a1b2c3d4-0013-4000-8000-000000000012")]
        #endregion
        [Multiplicity(Multiplicity.ManyToOne)]
        [Indexed]
        [Workspace(Default)]
        public OperationsType WorkType { get; set; }

        #region Allors
        [Id("a1b2c3d4-0013-4000-8000-000000000013")]
        #endregion
        [Multiplicity(Multiplicity.ManyToOne)]
        [Indexed]
        [Required]
        [Workspace(Default)]
        public JobOrder JobOrder { get; set; }

        #region Allors
        [Id("a1b2c3d4-0013-4000-8000-000000000014")]
        #endregion
        [Workspace(Default)]
        public DateTime StartTime { get; set; }

        #region Allors
        [Id("a1b2c3d4-0013-4000-8000-000000000015")]
        #endregion
        [Workspace(Default)]
        public DateTime EndTime { get; set; }

        #region Allors
        [Id("a1b2c3d4-0013-4000-8000-000000000016")]
        #endregion
        [Size(64)]
        [Workspace(Default)]
        public string JobState { get; set; }

        #region Allors
        [Id("a1b2c3d4-0013-4000-8000-000000000017")]
        #endregion
        [Multiplicity(Multiplicity.OneToMany)]
        [Indexed]
        [Workspace(Default)]
        public PersonnelActual[] PersonnelActuals { get; set; }

        #region Allors
        [Id("a1b2c3d4-0013-4000-8000-000000000018")]
        #endregion
        [Multiplicity(Multiplicity.OneToMany)]
        [Indexed]
        [Workspace(Default)]
        public EquipmentActual[] EquipmentActuals { get; set; }

        #region Allors
        [Id("a1b2c3d4-0013-4000-8000-000000000019")]
        #endregion
        [Multiplicity(Multiplicity.OneToMany)]
        [Indexed]
        [Workspace(Default)]
        public MaterialActual[] MaterialActuals { get; set; }

        #region inherited methods
        public void OnBuild() { }

        public void OnPostBuild() { }

        public void OnInit() { }

        public void OnPostDerive() { }

        public void Delete() { }
        #endregion
    }
}
