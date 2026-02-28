namespace Allors.Database.Meta.Configuration
{
    public partial class Deletable : Interface, Meta.Deletable {
        public Deletable(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.Deletable.M => (Meta.M)this.M;

        public Equipment AsEquipment;
        Meta.Equipment Meta.Deletable.AsEquipment => this.AsEquipment;
        public EquipmentActual AsEquipmentActual;
        Meta.EquipmentActual Meta.Deletable.AsEquipmentActual => this.AsEquipmentActual;
        public EquipmentClass AsEquipmentClass;
        Meta.EquipmentClass Meta.Deletable.AsEquipmentClass => this.AsEquipmentClass;
        public EquipmentClassProperty AsEquipmentClassProperty;
        Meta.EquipmentClassProperty Meta.Deletable.AsEquipmentClassProperty => this.AsEquipmentClassProperty;
        public EquipmentProperty AsEquipmentProperty;
        Meta.EquipmentProperty Meta.Deletable.AsEquipmentProperty => this.AsEquipmentProperty;
        public EquipmentRequirement AsEquipmentRequirement;
        Meta.EquipmentRequirement Meta.Deletable.AsEquipmentRequirement => this.AsEquipmentRequirement;
        public HierarchyScope AsHierarchyScope;
        Meta.HierarchyScope Meta.Deletable.AsHierarchyScope => this.AsHierarchyScope;
        public JobOrder AsJobOrder;
        Meta.JobOrder Meta.Deletable.AsJobOrder => this.AsJobOrder;
        public JobResponse AsJobResponse;
        Meta.JobResponse Meta.Deletable.AsJobResponse => this.AsJobResponse;
        public MaterialActual AsMaterialActual;
        Meta.MaterialActual Meta.Deletable.AsMaterialActual => this.AsMaterialActual;
        public MaterialRequirement AsMaterialRequirement;
        Meta.MaterialRequirement Meta.Deletable.AsMaterialRequirement => this.AsMaterialRequirement;
        public OperationsDefinition AsOperationsDefinition;
        Meta.OperationsDefinition Meta.Deletable.AsOperationsDefinition => this.AsOperationsDefinition;
        public OperationsSegment AsOperationsSegment;
        Meta.OperationsSegment Meta.Deletable.AsOperationsSegment => this.AsOperationsSegment;
        public Person AsPerson;
        Meta.Person Meta.Deletable.AsPerson => this.AsPerson;
        public PersonnelActual AsPersonnelActual;
        Meta.PersonnelActual Meta.Deletable.AsPersonnelActual => this.AsPersonnelActual;
        public PersonnelClass AsPersonnelClass;
        Meta.PersonnelClass Meta.Deletable.AsPersonnelClass => this.AsPersonnelClass;
        public PersonnelClassProperty AsPersonnelClassProperty;
        Meta.PersonnelClassProperty Meta.Deletable.AsPersonnelClassProperty => this.AsPersonnelClassProperty;
        public PersonnelRequirement AsPersonnelRequirement;
        Meta.PersonnelRequirement Meta.Deletable.AsPersonnelRequirement => this.AsPersonnelRequirement;
        public PersonProperty AsPersonProperty;
        Meta.PersonProperty Meta.Deletable.AsPersonProperty => this.AsPersonProperty;
        public PhysicalAsset AsPhysicalAsset;
        Meta.PhysicalAsset Meta.Deletable.AsPhysicalAsset => this.AsPhysicalAsset;
        public PhysicalAssetProperty AsPhysicalAssetProperty;
        Meta.PhysicalAssetProperty Meta.Deletable.AsPhysicalAssetProperty => this.AsPhysicalAssetProperty;
        public WorkMaster AsWorkMaster;
        Meta.WorkMaster Meta.Deletable.AsWorkMaster => this.AsWorkMaster;
        public Grant AsGrant;
        Meta.Grant Meta.Deletable.AsGrant => this.AsGrant;
        public CreatePermission AsCreatePermission;
        Meta.CreatePermission Meta.Deletable.AsCreatePermission => this.AsCreatePermission;
        public ExecutePermission AsExecutePermission;
        Meta.ExecutePermission Meta.Deletable.AsExecutePermission => this.AsExecutePermission;
        public Permission AsPermission;
        Meta.Permission Meta.Deletable.AsPermission => this.AsPermission;
        public ReadPermission AsReadPermission;
        Meta.ReadPermission Meta.Deletable.AsReadPermission => this.AsReadPermission;
        public WritePermission AsWritePermission;
        Meta.WritePermission Meta.Deletable.AsWritePermission => this.AsWritePermission;
        public Revocation AsRevocation;
        Meta.Revocation Meta.Deletable.AsRevocation => this.AsRevocation;
        public SecurityToken AsSecurityToken;
        Meta.SecurityToken Meta.Deletable.AsSecurityToken => this.AsSecurityToken;
        public User AsUser;
        Meta.User Meta.Deletable.AsUser => this.AsUser;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.Deletable.SecurityTokens => this.SecurityTokens;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.Deletable.Revocations => this.Revocations;



        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.Deletable.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;

        public MethodType Delete;
        IMethodType Meta.Deletable.Delete => this.Delete;

    }
    public partial class Object : Interface, Meta.Object {
        public Object(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.Object.M => (Meta.M)this.M;

        public DispatchStatus AsDispatchStatus;
        Meta.DispatchStatus Meta.Object.AsDispatchStatus => this.AsDispatchStatus;
        public Equipment AsEquipment;
        Meta.Equipment Meta.Object.AsEquipment => this.AsEquipment;
        public EquipmentActual AsEquipmentActual;
        Meta.EquipmentActual Meta.Object.AsEquipmentActual => this.AsEquipmentActual;
        public EquipmentClass AsEquipmentClass;
        Meta.EquipmentClass Meta.Object.AsEquipmentClass => this.AsEquipmentClass;
        public EquipmentClassProperty AsEquipmentClassProperty;
        Meta.EquipmentClassProperty Meta.Object.AsEquipmentClassProperty => this.AsEquipmentClassProperty;
        public EquipmentLevel AsEquipmentLevel;
        Meta.EquipmentLevel Meta.Object.AsEquipmentLevel => this.AsEquipmentLevel;
        public EquipmentProperty AsEquipmentProperty;
        Meta.EquipmentProperty Meta.Object.AsEquipmentProperty => this.AsEquipmentProperty;
        public EquipmentRequirement AsEquipmentRequirement;
        Meta.EquipmentRequirement Meta.Object.AsEquipmentRequirement => this.AsEquipmentRequirement;
        public HierarchyScope AsHierarchyScope;
        Meta.HierarchyScope Meta.Object.AsHierarchyScope => this.AsHierarchyScope;
        public JobOrder AsJobOrder;
        Meta.JobOrder Meta.Object.AsJobOrder => this.AsJobOrder;
        public JobResponse AsJobResponse;
        Meta.JobResponse Meta.Object.AsJobResponse => this.AsJobResponse;
        public MaterialActual AsMaterialActual;
        Meta.MaterialActual Meta.Object.AsMaterialActual => this.AsMaterialActual;
        public MaterialRequirement AsMaterialRequirement;
        Meta.MaterialRequirement Meta.Object.AsMaterialRequirement => this.AsMaterialRequirement;
        public OperationsDefinition AsOperationsDefinition;
        Meta.OperationsDefinition Meta.Object.AsOperationsDefinition => this.AsOperationsDefinition;
        public OperationsSegment AsOperationsSegment;
        Meta.OperationsSegment Meta.Object.AsOperationsSegment => this.AsOperationsSegment;
        public OperationsType AsOperationsType;
        Meta.OperationsType Meta.Object.AsOperationsType => this.AsOperationsType;
        public Person AsPerson;
        Meta.Person Meta.Object.AsPerson => this.AsPerson;
        public PersonnelActual AsPersonnelActual;
        Meta.PersonnelActual Meta.Object.AsPersonnelActual => this.AsPersonnelActual;
        public PersonnelClass AsPersonnelClass;
        Meta.PersonnelClass Meta.Object.AsPersonnelClass => this.AsPersonnelClass;
        public PersonnelClassProperty AsPersonnelClassProperty;
        Meta.PersonnelClassProperty Meta.Object.AsPersonnelClassProperty => this.AsPersonnelClassProperty;
        public PersonnelRequirement AsPersonnelRequirement;
        Meta.PersonnelRequirement Meta.Object.AsPersonnelRequirement => this.AsPersonnelRequirement;
        public PersonProperty AsPersonProperty;
        Meta.PersonProperty Meta.Object.AsPersonProperty => this.AsPersonProperty;
        public PhysicalAsset AsPhysicalAsset;
        Meta.PhysicalAsset Meta.Object.AsPhysicalAsset => this.AsPhysicalAsset;
        public PhysicalAssetProperty AsPhysicalAssetProperty;
        Meta.PhysicalAssetProperty Meta.Object.AsPhysicalAssetProperty => this.AsPhysicalAssetProperty;
        public WorkMaster AsWorkMaster;
        Meta.WorkMaster Meta.Object.AsWorkMaster => this.AsWorkMaster;
        public Deletable AsDeletable;
        Meta.Deletable Meta.Object.AsDeletable => this.AsDeletable;
        public UniquelyIdentifiable AsUniquelyIdentifiable;
        Meta.UniquelyIdentifiable Meta.Object.AsUniquelyIdentifiable => this.AsUniquelyIdentifiable;
        public DelegatedAccessObject AsDelegatedAccessObject;
        Meta.DelegatedAccessObject Meta.Object.AsDelegatedAccessObject => this.AsDelegatedAccessObject;
        public Grant AsGrant;
        Meta.Grant Meta.Object.AsGrant => this.AsGrant;
        public CreatePermission AsCreatePermission;
        Meta.CreatePermission Meta.Object.AsCreatePermission => this.AsCreatePermission;
        public ExecutePermission AsExecutePermission;
        Meta.ExecutePermission Meta.Object.AsExecutePermission => this.AsExecutePermission;
        public Permission AsPermission;
        Meta.Permission Meta.Object.AsPermission => this.AsPermission;
        public ReadPermission AsReadPermission;
        Meta.ReadPermission Meta.Object.AsReadPermission => this.AsReadPermission;
        public WritePermission AsWritePermission;
        Meta.WritePermission Meta.Object.AsWritePermission => this.AsWritePermission;
        public Revocation AsRevocation;
        Meta.Revocation Meta.Object.AsRevocation => this.AsRevocation;
        public Role AsRole;
        Meta.Role Meta.Object.AsRole => this.AsRole;
        public SecurityToken AsSecurityToken;
        Meta.SecurityToken Meta.Object.AsSecurityToken => this.AsSecurityToken;
        public SecurityTokenOwner AsSecurityTokenOwner;
        Meta.SecurityTokenOwner Meta.Object.AsSecurityTokenOwner => this.AsSecurityTokenOwner;
        public User AsUser;
        Meta.User Meta.Object.AsUser => this.AsUser;
        public UserGroup AsUserGroup;
        Meta.UserGroup Meta.Object.AsUserGroup => this.AsUserGroup;

        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.Object.SecurityTokens => this.SecurityTokens;
        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.Object.Revocations => this.Revocations;


        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.Object.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess;


        public MethodType OnBuild;
        IMethodType Meta.Object.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.Object.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.Object.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.Object.OnPostDerive => this.OnPostDerive;

    }
    public partial class UniquelyIdentifiable : Interface, Meta.UniquelyIdentifiable {
        public UniquelyIdentifiable(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.UniquelyIdentifiable.M => (Meta.M)this.M;

        public DispatchStatus AsDispatchStatus;
        Meta.DispatchStatus Meta.UniquelyIdentifiable.AsDispatchStatus => this.AsDispatchStatus;
        public Equipment AsEquipment;
        Meta.Equipment Meta.UniquelyIdentifiable.AsEquipment => this.AsEquipment;
        public EquipmentActual AsEquipmentActual;
        Meta.EquipmentActual Meta.UniquelyIdentifiable.AsEquipmentActual => this.AsEquipmentActual;
        public EquipmentClass AsEquipmentClass;
        Meta.EquipmentClass Meta.UniquelyIdentifiable.AsEquipmentClass => this.AsEquipmentClass;
        public EquipmentClassProperty AsEquipmentClassProperty;
        Meta.EquipmentClassProperty Meta.UniquelyIdentifiable.AsEquipmentClassProperty => this.AsEquipmentClassProperty;
        public EquipmentLevel AsEquipmentLevel;
        Meta.EquipmentLevel Meta.UniquelyIdentifiable.AsEquipmentLevel => this.AsEquipmentLevel;
        public EquipmentProperty AsEquipmentProperty;
        Meta.EquipmentProperty Meta.UniquelyIdentifiable.AsEquipmentProperty => this.AsEquipmentProperty;
        public EquipmentRequirement AsEquipmentRequirement;
        Meta.EquipmentRequirement Meta.UniquelyIdentifiable.AsEquipmentRequirement => this.AsEquipmentRequirement;
        public HierarchyScope AsHierarchyScope;
        Meta.HierarchyScope Meta.UniquelyIdentifiable.AsHierarchyScope => this.AsHierarchyScope;
        public JobOrder AsJobOrder;
        Meta.JobOrder Meta.UniquelyIdentifiable.AsJobOrder => this.AsJobOrder;
        public JobResponse AsJobResponse;
        Meta.JobResponse Meta.UniquelyIdentifiable.AsJobResponse => this.AsJobResponse;
        public MaterialActual AsMaterialActual;
        Meta.MaterialActual Meta.UniquelyIdentifiable.AsMaterialActual => this.AsMaterialActual;
        public MaterialRequirement AsMaterialRequirement;
        Meta.MaterialRequirement Meta.UniquelyIdentifiable.AsMaterialRequirement => this.AsMaterialRequirement;
        public OperationsDefinition AsOperationsDefinition;
        Meta.OperationsDefinition Meta.UniquelyIdentifiable.AsOperationsDefinition => this.AsOperationsDefinition;
        public OperationsSegment AsOperationsSegment;
        Meta.OperationsSegment Meta.UniquelyIdentifiable.AsOperationsSegment => this.AsOperationsSegment;
        public OperationsType AsOperationsType;
        Meta.OperationsType Meta.UniquelyIdentifiable.AsOperationsType => this.AsOperationsType;
        public Person AsPerson;
        Meta.Person Meta.UniquelyIdentifiable.AsPerson => this.AsPerson;
        public PersonnelActual AsPersonnelActual;
        Meta.PersonnelActual Meta.UniquelyIdentifiable.AsPersonnelActual => this.AsPersonnelActual;
        public PersonnelClass AsPersonnelClass;
        Meta.PersonnelClass Meta.UniquelyIdentifiable.AsPersonnelClass => this.AsPersonnelClass;
        public PersonnelClassProperty AsPersonnelClassProperty;
        Meta.PersonnelClassProperty Meta.UniquelyIdentifiable.AsPersonnelClassProperty => this.AsPersonnelClassProperty;
        public PersonnelRequirement AsPersonnelRequirement;
        Meta.PersonnelRequirement Meta.UniquelyIdentifiable.AsPersonnelRequirement => this.AsPersonnelRequirement;
        public PersonProperty AsPersonProperty;
        Meta.PersonProperty Meta.UniquelyIdentifiable.AsPersonProperty => this.AsPersonProperty;
        public PhysicalAsset AsPhysicalAsset;
        Meta.PhysicalAsset Meta.UniquelyIdentifiable.AsPhysicalAsset => this.AsPhysicalAsset;
        public PhysicalAssetProperty AsPhysicalAssetProperty;
        Meta.PhysicalAssetProperty Meta.UniquelyIdentifiable.AsPhysicalAssetProperty => this.AsPhysicalAssetProperty;
        public WorkMaster AsWorkMaster;
        Meta.WorkMaster Meta.UniquelyIdentifiable.AsWorkMaster => this.AsWorkMaster;
        public Grant AsGrant;
        Meta.Grant Meta.UniquelyIdentifiable.AsGrant => this.AsGrant;
        public Revocation AsRevocation;
        Meta.Revocation Meta.UniquelyIdentifiable.AsRevocation => this.AsRevocation;
        public Role AsRole;
        Meta.Role Meta.UniquelyIdentifiable.AsRole => this.AsRole;
        public SecurityToken AsSecurityToken;
        Meta.SecurityToken Meta.UniquelyIdentifiable.AsSecurityToken => this.AsSecurityToken;
        public User AsUser;
        Meta.User Meta.UniquelyIdentifiable.AsUser => this.AsUser;
        public UserGroup AsUserGroup;
        Meta.UserGroup Meta.UniquelyIdentifiable.AsUserGroup => this.AsUserGroup;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.UniquelyIdentifiable.UniqueId => this.UniqueId;

        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.UniquelyIdentifiable.SecurityTokens => this.SecurityTokens;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.UniquelyIdentifiable.Revocations => this.Revocations;



        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.UniquelyIdentifiable.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


    }
    public partial class DelegatedAccessObject : Interface, Meta.DelegatedAccessObject {
        public DelegatedAccessObject(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.DelegatedAccessObject.M => (Meta.M)this.M;


        public DelegatedAccessObjectDelegatedAccess DelegatedAccess;
        Meta.DelegatedAccessObjectDelegatedAccess Meta.DelegatedAccessObject.DelegatedAccess => this.DelegatedAccess;

        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.DelegatedAccessObject.SecurityTokens => this.SecurityTokens;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.DelegatedAccessObject.Revocations => this.Revocations;



        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.DelegatedAccessObject.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


    }
    public partial class Permission : Interface, Meta.Permission {
        public Permission(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.Permission.M => (Meta.M)this.M;

        public CreatePermission AsCreatePermission;
        Meta.CreatePermission Meta.Permission.AsCreatePermission => this.AsCreatePermission;
        public ExecutePermission AsExecutePermission;
        Meta.ExecutePermission Meta.Permission.AsExecutePermission => this.AsExecutePermission;
        public ReadPermission AsReadPermission;
        Meta.ReadPermission Meta.Permission.AsReadPermission => this.AsReadPermission;
        public WritePermission AsWritePermission;
        Meta.WritePermission Meta.Permission.AsWritePermission => this.AsWritePermission;

        public PermissionClassPointer ClassPointer;
        Meta.PermissionClassPointer Meta.Permission.ClassPointer => this.ClassPointer;

        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.Permission.SecurityTokens => this.SecurityTokens;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.Permission.Revocations => this.Revocations;


        public GrantsWhereEffectivePermission GrantsWhereEffectivePermission;
        Meta.GrantsWhereEffectivePermission Meta.Permission.GrantsWhereEffectivePermission => this.GrantsWhereEffectivePermission;
        public RevocationsWhereDeniedPermission RevocationsWhereDeniedPermission;
        Meta.RevocationsWhereDeniedPermission Meta.Permission.RevocationsWhereDeniedPermission => this.RevocationsWhereDeniedPermission;
        public RolesWherePermission RolesWherePermission;
        Meta.RolesWherePermission Meta.Permission.RolesWherePermission => this.RolesWherePermission;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.Permission.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


    }
    public partial class SecurityTokenOwner : Interface, Meta.SecurityTokenOwner {
        public SecurityTokenOwner(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.SecurityTokenOwner.M => (Meta.M)this.M;

        public User AsUser;
        Meta.User Meta.SecurityTokenOwner.AsUser => this.AsUser;

        public SecurityTokenOwnerOwnerSecurityToken OwnerSecurityToken;
        Meta.SecurityTokenOwnerOwnerSecurityToken Meta.SecurityTokenOwner.OwnerSecurityToken => this.OwnerSecurityToken;
        public SecurityTokenOwnerOwnerGrant OwnerGrant;
        Meta.SecurityTokenOwnerOwnerGrant Meta.SecurityTokenOwner.OwnerGrant => this.OwnerGrant;

        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.SecurityTokenOwner.SecurityTokens => this.SecurityTokens;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.SecurityTokenOwner.Revocations => this.Revocations;



        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.SecurityTokenOwner.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


    }
    public partial class User : Interface, Meta.User {
        public User(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.User.M => (Meta.M)this.M;


        public UserUserName UserName;
        Meta.UserUserName Meta.User.UserName => this.UserName;
        public UserNormalizedUserName NormalizedUserName;
        Meta.UserNormalizedUserName Meta.User.NormalizedUserName => this.NormalizedUserName;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.User.UniqueId => this.UniqueId;


        public SecurityTokenOwnerOwnerSecurityToken OwnerSecurityToken;
        Meta.SecurityTokenOwnerOwnerSecurityToken Meta.User.OwnerSecurityToken => this.OwnerSecurityToken;


        public SecurityTokenOwnerOwnerGrant OwnerGrant;
        Meta.SecurityTokenOwnerOwnerGrant Meta.User.OwnerGrant => this.OwnerGrant;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.User.SecurityTokens => this.SecurityTokens;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.User.Revocations => this.Revocations;


        public PersonWhereUser PersonWhereUser;
        Meta.PersonWhereUser Meta.User.PersonWhereUser => this.PersonWhereUser;
        public GrantsWhereSubject GrantsWhereSubject;
        Meta.GrantsWhereSubject Meta.User.GrantsWhereSubject => this.GrantsWhereSubject;
        public GrantsWhereEffectiveUser GrantsWhereEffectiveUser;
        Meta.GrantsWhereEffectiveUser Meta.User.GrantsWhereEffectiveUser => this.GrantsWhereEffectiveUser;
        public UserGroupsWhereMember UserGroupsWhereMember;
        Meta.UserGroupsWhereMember Meta.User.UserGroupsWhereMember => this.UserGroupsWhereMember;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.User.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


    }
}