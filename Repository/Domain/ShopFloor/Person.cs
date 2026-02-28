namespace Allors.Repository
{
    using System;

    using Attributes;
    using static Workspaces;

    #region Allors
    [Id("a1b2c3d4-000b-4000-8000-000000000001")]
    #endregion
    public partial class Person : UniquelyIdentifiable, Deletable
    {
        #region inherited properties
        public Guid UniqueId { get; set; }

        public Revocation[] Revocations { get; set; }

        public SecurityToken[] SecurityTokens { get; set; }

        #endregion

        #region Allors
        [Id("a1b2c3d4-000b-4000-8000-000000000011")]
        #endregion
        [Size(256)]
        [Workspace(Default)]
        public string FirstName { get; set; }

        #region Allors
        [Id("a1b2c3d4-000b-4000-8000-000000000012")]
        #endregion
        [Size(256)]
        [Workspace(Default)]
        public string LastName { get; set; }

        #region Allors
        [Id("a1b2c3d4-000b-4000-8000-000000000013")]
        #endregion
        [Multiplicity(Multiplicity.OneToOne)]
        [Indexed]
        [Workspace(Default)]
        public User User { get; set; }

        #region Allors
        [Id("a1b2c3d4-000b-4000-8000-000000000014")]
        #endregion
        [Multiplicity(Multiplicity.ManyToMany)]
        [Indexed]
        [Workspace(Default)]
        public PersonnelClass[] PersonnelClasses { get; set; }

        #region Allors
        [Id("a1b2c3d4-000b-4000-8000-000000000015")]
        #endregion
        [Multiplicity(Multiplicity.OneToMany)]
        [Indexed]
        [Workspace(Default)]
        public PersonProperty[] PersonProperties { get; set; }

        #region Allors
        [Id("a1b2c3d4-000b-4000-8000-000000000016")]
        #endregion
        [Size(512)]
        [Derived]
        [Workspace(Default)]
        public string DisplayName { get; set; }

        #region inherited methods
        public void OnBuild() { }

        public void OnPostBuild() { }

        public void OnInit() { }

        public void OnPostDerive() { }

        public void Delete() { }
        #endregion
    }
}
