namespace Allors.Database.Meta
{
    public interface DispatchStatusName : IClassRoleType
    {
    }


    public interface DispatchStatusIsActive : IClassRoleType
    {
    }


    public interface EquipmentName : IClassRoleType
    {
    }


    public interface EquipmentDescription : IClassRoleType
    {
    }


    public interface EquipmentEquipmentLevel : IClassRoleType
    {
        new public EquipmentLevel ObjectType { get; }
    }


    public interface EquipmentEquipmentClasses : IClassRoleType
    {
        new public EquipmentClass ObjectType { get; }
    }


    public interface EquipmentEquipmentProperties : IClassRoleType
    {
        new public EquipmentProperty ObjectType { get; }
    }


    public interface EquipmentEquipmentChildren : IClassRoleType
    {
        new public Equipment ObjectType { get; }
    }


    public interface EquipmentEquipmentParent : IClassRoleType
    {
        new public Equipment ObjectType { get; }
    }


    public interface EquipmentPhysicalAsset : IClassRoleType
    {
        new public PhysicalAsset ObjectType { get; }
    }


    public interface EquipmentHierarchyScope : IClassRoleType
    {
        new public HierarchyScope ObjectType { get; }
    }


    public interface EquipmentDisplayName : IClassRoleType
    {
    }


    public interface EquipmentActualEquipment : IClassRoleType
    {
        new public Equipment ObjectType { get; }
    }


    public interface EquipmentActualEquipmentClass : IClassRoleType
    {
        new public EquipmentClass ObjectType { get; }
    }


    public interface EquipmentActualDescription : IClassRoleType
    {
    }


    public interface EquipmentClassName : IClassRoleType
    {
    }


    public interface EquipmentClassDescription : IClassRoleType
    {
    }


    public interface EquipmentClassEquipmentLevel : IClassRoleType
    {
        new public EquipmentLevel ObjectType { get; }
    }


    public interface EquipmentClassEquipmentClassProperties : IClassRoleType
    {
        new public EquipmentClassProperty ObjectType { get; }
    }


    public interface EquipmentClassEquipmentClassChildren : IClassRoleType
    {
        new public EquipmentClass ObjectType { get; }
    }


    public interface EquipmentClassEquipmentClassParent : IClassRoleType
    {
        new public EquipmentClass ObjectType { get; }
    }


    public interface EquipmentClassPropertyName : IClassRoleType
    {
    }


    public interface EquipmentClassPropertyDescription : IClassRoleType
    {
    }


    public interface EquipmentClassPropertyDefaultValue : IClassRoleType
    {
    }


    public interface EquipmentClassPropertyPropertyType : IClassRoleType
    {
    }


    public interface EquipmentClassPropertyEquipmentClassPropertyChildren : IClassRoleType
    {
        new public EquipmentClassProperty ObjectType { get; }
    }


    public interface EquipmentLevelName : IClassRoleType
    {
    }


    public interface EquipmentLevelIsActive : IClassRoleType
    {
    }


    public interface EquipmentPropertyName : IClassRoleType
    {
    }


    public interface EquipmentPropertyDescription : IClassRoleType
    {
    }


    public interface EquipmentPropertyValue : IClassRoleType
    {
    }


    public interface EquipmentPropertyEquipmentClassProperty : IClassRoleType
    {
        new public EquipmentClassProperty ObjectType { get; }
    }


    public interface EquipmentPropertyEquipmentPropertyChildren : IClassRoleType
    {
        new public EquipmentProperty ObjectType { get; }
    }


    public interface EquipmentRequirementEquipmentClass : IClassRoleType
    {
        new public EquipmentClass ObjectType { get; }
    }


    public interface EquipmentRequirementEquipment : IClassRoleType
    {
        new public Equipment ObjectType { get; }
    }


    public interface EquipmentRequirementQuantity : IClassRoleType
    {
    }


    public interface EquipmentRequirementDescription : IClassRoleType
    {
    }


    public interface HierarchyScopeScopedEquipment : IClassRoleType
    {
        new public Equipment ObjectType { get; }
    }


    public interface HierarchyScopeEquipmentLevel : IClassRoleType
    {
        new public EquipmentLevel ObjectType { get; }
    }


    public interface JobOrderName : IClassRoleType
    {
    }


    public interface JobOrderDescription : IClassRoleType
    {
    }


    public interface JobOrderWorkType : IClassRoleType
    {
        new public OperationsType ObjectType { get; }
    }


    public interface JobOrderWorkMaster : IClassRoleType
    {
        new public WorkMaster ObjectType { get; }
    }


    public interface JobOrderEquipment : IClassRoleType
    {
        new public Equipment ObjectType { get; }
    }


    public interface JobOrderPriority : IClassRoleType
    {
    }


    public interface JobOrderDispatchStatus : IClassRoleType
    {
        new public DispatchStatus ObjectType { get; }
    }


    public interface JobOrderStartTime : IClassRoleType
    {
    }


    public interface JobOrderEndTime : IClassRoleType
    {
    }


    public interface JobOrderHierarchyScope : IClassRoleType
    {
        new public HierarchyScope ObjectType { get; }
    }


    public interface JobOrderPersonnelRequirements : IClassRoleType
    {
        new public PersonnelRequirement ObjectType { get; }
    }


    public interface JobOrderEquipmentRequirements : IClassRoleType
    {
        new public EquipmentRequirement ObjectType { get; }
    }


    public interface JobOrderMaterialRequirements : IClassRoleType
    {
        new public MaterialRequirement ObjectType { get; }
    }


    public interface JobOrderAssignedTo : IClassRoleType
    {
        new public Person ObjectType { get; }
    }


    public interface JobOrderResponse : IClassRoleType
    {
        new public JobResponse ObjectType { get; }
    }


    public interface JobResponseDescription : IClassRoleType
    {
    }


    public interface JobResponseWorkType : IClassRoleType
    {
        new public OperationsType ObjectType { get; }
    }


    public interface JobResponseJobOrder : IClassRoleType
    {
        new public JobOrder ObjectType { get; }
    }


    public interface JobResponseStartTime : IClassRoleType
    {
    }


    public interface JobResponseEndTime : IClassRoleType
    {
    }


    public interface JobResponseJobState : IClassRoleType
    {
    }


    public interface JobResponsePersonnelActuals : IClassRoleType
    {
        new public PersonnelActual ObjectType { get; }
    }


    public interface JobResponseEquipmentActuals : IClassRoleType
    {
        new public EquipmentActual ObjectType { get; }
    }


    public interface JobResponseMaterialActuals : IClassRoleType
    {
        new public MaterialActual ObjectType { get; }
    }


    public interface MaterialActualName : IClassRoleType
    {
    }


    public interface MaterialActualQuantity : IClassRoleType
    {
    }


    public interface MaterialActualDescription : IClassRoleType
    {
    }


    public interface MaterialRequirementName : IClassRoleType
    {
    }


    public interface MaterialRequirementQuantity : IClassRoleType
    {
    }


    public interface MaterialRequirementDescription : IClassRoleType
    {
    }


    public interface OperationsDefinitionName : IClassRoleType
    {
    }


    public interface OperationsDefinitionDescription : IClassRoleType
    {
    }


    public interface OperationsDefinitionVersion : IClassRoleType
    {
    }


    public interface OperationsDefinitionOperationsType : IClassRoleType
    {
        new public OperationsType ObjectType { get; }
    }


    public interface OperationsDefinitionOperationsSegments : IClassRoleType
    {
        new public OperationsSegment ObjectType { get; }
    }


    public interface OperationsDefinitionEffectiveStartDate : IClassRoleType
    {
    }


    public interface OperationsDefinitionEffectiveEndDate : IClassRoleType
    {
    }


    public interface OperationsDefinitionHierarchyScope : IClassRoleType
    {
        new public HierarchyScope ObjectType { get; }
    }


    public interface OperationsSegmentName : IClassRoleType
    {
    }


    public interface OperationsSegmentDescription : IClassRoleType
    {
    }


    public interface OperationsSegmentDuration : IClassRoleType
    {
    }


    public interface OperationsSegmentOperationsType : IClassRoleType
    {
        new public OperationsType ObjectType { get; }
    }


    public interface OperationsSegmentPersonnelSpecifications : IClassRoleType
    {
        new public PersonnelRequirement ObjectType { get; }
    }


    public interface OperationsSegmentEquipmentSpecifications : IClassRoleType
    {
        new public EquipmentRequirement ObjectType { get; }
    }


    public interface OperationsSegmentMaterialSpecifications : IClassRoleType
    {
        new public MaterialRequirement ObjectType { get; }
    }


    public interface OperationsSegmentOperationsSegmentChildren : IClassRoleType
    {
        new public OperationsSegment ObjectType { get; }
    }


    public interface OperationsSegmentOperationsSegmentParent : IClassRoleType
    {
        new public OperationsSegment ObjectType { get; }
    }


    public interface OperationsTypeName : IClassRoleType
    {
    }


    public interface OperationsTypeIsActive : IClassRoleType
    {
    }


    public interface PersonFirstName : IClassRoleType
    {
    }


    public interface PersonLastName : IClassRoleType
    {
    }


    public interface PersonUser : IClassRoleType
    {
        new public User ObjectType { get; }
    }


    public interface PersonPersonnelClasses : IClassRoleType
    {
        new public PersonnelClass ObjectType { get; }
    }


    public interface PersonPersonProperties : IClassRoleType
    {
        new public PersonProperty ObjectType { get; }
    }


    public interface PersonDisplayName : IClassRoleType
    {
    }


    public interface PersonnelActualPerson : IClassRoleType
    {
        new public Person ObjectType { get; }
    }


    public interface PersonnelActualPersonnelClass : IClassRoleType
    {
        new public PersonnelClass ObjectType { get; }
    }


    public interface PersonnelActualDescription : IClassRoleType
    {
    }


    public interface PersonnelClassName : IClassRoleType
    {
    }


    public interface PersonnelClassDescription : IClassRoleType
    {
    }


    public interface PersonnelClassPersonnelClassProperties : IClassRoleType
    {
        new public PersonnelClassProperty ObjectType { get; }
    }


    public interface PersonnelClassPersonnelClassParent : IClassRoleType
    {
        new public PersonnelClass ObjectType { get; }
    }


    public interface PersonnelClassPropertyName : IClassRoleType
    {
    }


    public interface PersonnelClassPropertyDescription : IClassRoleType
    {
    }


    public interface PersonnelClassPropertyDefaultValue : IClassRoleType
    {
    }


    public interface PersonnelRequirementPersonnelClass : IClassRoleType
    {
        new public PersonnelClass ObjectType { get; }
    }


    public interface PersonnelRequirementPerson : IClassRoleType
    {
        new public Person ObjectType { get; }
    }


    public interface PersonnelRequirementQuantity : IClassRoleType
    {
    }


    public interface PersonnelRequirementDescription : IClassRoleType
    {
    }


    public interface PersonPropertyName : IClassRoleType
    {
    }


    public interface PersonPropertyValue : IClassRoleType
    {
    }


    public interface PersonPropertyPersonnelClassProperty : IClassRoleType
    {
        new public PersonnelClassProperty ObjectType { get; }
    }


    public interface PhysicalAssetName : IClassRoleType
    {
    }


    public interface PhysicalAssetDescription : IClassRoleType
    {
    }


    public interface PhysicalAssetSerialNumber : IClassRoleType
    {
    }


    public interface PhysicalAssetManufacturer : IClassRoleType
    {
    }


    public interface PhysicalAssetModelNumber : IClassRoleType
    {
    }


    public interface PhysicalAssetInstallationDate : IClassRoleType
    {
    }


    public interface PhysicalAssetPhysicalAssetProperties : IClassRoleType
    {
        new public PhysicalAssetProperty ObjectType { get; }
    }


    public interface PhysicalAssetPhysicalAssetChildren : IClassRoleType
    {
        new public PhysicalAsset ObjectType { get; }
    }


    public interface PhysicalAssetPropertyName : IClassRoleType
    {
    }


    public interface PhysicalAssetPropertyValue : IClassRoleType
    {
    }


    public interface WorkMasterName : IClassRoleType
    {
    }


    public interface WorkMasterDescription : IClassRoleType
    {
    }


    public interface WorkMasterVersion : IClassRoleType
    {
    }


    public interface WorkMasterWorkType : IClassRoleType
    {
        new public OperationsType ObjectType { get; }
    }


    public interface WorkMasterDuration : IClassRoleType
    {
    }


    public interface WorkMasterOperationsDefinition : IClassRoleType
    {
        new public OperationsDefinition ObjectType { get; }
    }


    public interface WorkMasterPersonnelSpecifications : IClassRoleType
    {
        new public PersonnelRequirement ObjectType { get; }
    }


    public interface WorkMasterEquipmentSpecifications : IClassRoleType
    {
        new public EquipmentRequirement ObjectType { get; }
    }


    public interface WorkMasterMaterialSpecifications : IClassRoleType
    {
        new public MaterialRequirement ObjectType { get; }
    }


    public interface WorkMasterWorkMasterChildren : IClassRoleType
    {
        new public WorkMaster ObjectType { get; }
    }


    public interface GrantSubjectGroups : IClassRoleType
    {
        new public UserGroup ObjectType { get; }
    }


    public interface GrantSubjects : IClassRoleType
    {
        new public User ObjectType { get; }
    }


    public interface GrantRole : IClassRoleType
    {
        new public Role ObjectType { get; }
    }


    public interface GrantEffectivePermissions : IClassRoleType
    {
        new public Permission ObjectType { get; }
    }


    public interface GrantEffectiveUsers : IClassRoleType
    {
        new public User ObjectType { get; }
    }



    public interface ExecutePermissionMethodTypePointer : IClassRoleType
    {
    }


    public interface ReadPermissionRelationTypePointer : IClassRoleType
    {
    }


    public interface WritePermissionRelationTypePointer : IClassRoleType
    {
    }


    public interface RevocationDeniedPermissions : IClassRoleType
    {
        new public Permission ObjectType { get; }
    }


    public interface RolePermissions : IClassRoleType
    {
        new public Permission ObjectType { get; }
    }


    public interface RoleName : IClassRoleType
    {
    }


    public interface SecurityTokenGrants : IClassRoleType
    {
        new public Grant ObjectType { get; }
    }


    public interface SecurityTokenSecurityStamp : IClassRoleType
    {
    }


    public interface UserGroupMembers : IClassRoleType
    {
        new public User ObjectType { get; }
    }


    public interface UserGroupName : IClassRoleType
    {
    }



    public interface ObjectSecurityTokens : IInterfaceRoleType
    {
        new public SecurityToken ObjectType { get; }
    }

/*
    public interface DispatchStatusSecurityTokens : IClassRoleType
    {
        public DispatchStatusSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface EquipmentSecurityTokens : IClassRoleType
    {
        public EquipmentSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface EquipmentActualSecurityTokens : IClassRoleType
    {
        public EquipmentActualSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface EquipmentClassSecurityTokens : IClassRoleType
    {
        public EquipmentClassSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface EquipmentClassPropertySecurityTokens : IClassRoleType
    {
        public EquipmentClassPropertySecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface EquipmentLevelSecurityTokens : IClassRoleType
    {
        public EquipmentLevelSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface EquipmentPropertySecurityTokens : IClassRoleType
    {
        public EquipmentPropertySecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface EquipmentRequirementSecurityTokens : IClassRoleType
    {
        public EquipmentRequirementSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface HierarchyScopeSecurityTokens : IClassRoleType
    {
        public HierarchyScopeSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface JobOrderSecurityTokens : IClassRoleType
    {
        public JobOrderSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface JobResponseSecurityTokens : IClassRoleType
    {
        public JobResponseSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface MaterialActualSecurityTokens : IClassRoleType
    {
        public MaterialActualSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface MaterialRequirementSecurityTokens : IClassRoleType
    {
        public MaterialRequirementSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface OperationsDefinitionSecurityTokens : IClassRoleType
    {
        public OperationsDefinitionSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface OperationsSegmentSecurityTokens : IClassRoleType
    {
        public OperationsSegmentSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface OperationsTypeSecurityTokens : IClassRoleType
    {
        public OperationsTypeSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface PersonSecurityTokens : IClassRoleType
    {
        public PersonSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface PersonnelActualSecurityTokens : IClassRoleType
    {
        public PersonnelActualSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface PersonnelClassSecurityTokens : IClassRoleType
    {
        public PersonnelClassSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface PersonnelClassPropertySecurityTokens : IClassRoleType
    {
        public PersonnelClassPropertySecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface PersonnelRequirementSecurityTokens : IClassRoleType
    {
        public PersonnelRequirementSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface PersonPropertySecurityTokens : IClassRoleType
    {
        public PersonPropertySecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface PhysicalAssetSecurityTokens : IClassRoleType
    {
        public PhysicalAssetSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface PhysicalAssetPropertySecurityTokens : IClassRoleType
    {
        public PhysicalAssetPropertySecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface WorkMasterSecurityTokens : IClassRoleType
    {
        public WorkMasterSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface GrantSecurityTokens : IClassRoleType
    {
        public GrantSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface CreatePermissionSecurityTokens : IClassRoleType
    {
        public CreatePermissionSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface ExecutePermissionSecurityTokens : IClassRoleType
    {
        public ExecutePermissionSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface ReadPermissionSecurityTokens : IClassRoleType
    {
        public ReadPermissionSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface WritePermissionSecurityTokens : IClassRoleType
    {
        public WritePermissionSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface RevocationSecurityTokens : IClassRoleType
    {
        public RevocationSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface RoleSecurityTokens : IClassRoleType
    {
        public RoleSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface SecurityTokenSecurityTokens : IClassRoleType
    {
        public SecurityTokenSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/
/*
    public interface UserGroupSecurityTokens : IClassRoleType
    {
        public UserGroupSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new SecurityToken ObjectType => this.M.SecurityToken;
    }
*/

    public interface ObjectRevocations : IInterfaceRoleType
    {
        new public Revocation ObjectType { get; }
    }

/*
    public interface DispatchStatusRevocations : IClassRoleType
    {
        public DispatchStatusRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface EquipmentRevocations : IClassRoleType
    {
        public EquipmentRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface EquipmentActualRevocations : IClassRoleType
    {
        public EquipmentActualRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface EquipmentClassRevocations : IClassRoleType
    {
        public EquipmentClassRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface EquipmentClassPropertyRevocations : IClassRoleType
    {
        public EquipmentClassPropertyRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface EquipmentLevelRevocations : IClassRoleType
    {
        public EquipmentLevelRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface EquipmentPropertyRevocations : IClassRoleType
    {
        public EquipmentPropertyRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface EquipmentRequirementRevocations : IClassRoleType
    {
        public EquipmentRequirementRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface HierarchyScopeRevocations : IClassRoleType
    {
        public HierarchyScopeRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface JobOrderRevocations : IClassRoleType
    {
        public JobOrderRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface JobResponseRevocations : IClassRoleType
    {
        public JobResponseRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface MaterialActualRevocations : IClassRoleType
    {
        public MaterialActualRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface MaterialRequirementRevocations : IClassRoleType
    {
        public MaterialRequirementRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface OperationsDefinitionRevocations : IClassRoleType
    {
        public OperationsDefinitionRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface OperationsSegmentRevocations : IClassRoleType
    {
        public OperationsSegmentRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface OperationsTypeRevocations : IClassRoleType
    {
        public OperationsTypeRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface PersonRevocations : IClassRoleType
    {
        public PersonRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface PersonnelActualRevocations : IClassRoleType
    {
        public PersonnelActualRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface PersonnelClassRevocations : IClassRoleType
    {
        public PersonnelClassRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface PersonnelClassPropertyRevocations : IClassRoleType
    {
        public PersonnelClassPropertyRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface PersonnelRequirementRevocations : IClassRoleType
    {
        public PersonnelRequirementRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface PersonPropertyRevocations : IClassRoleType
    {
        public PersonPropertyRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface PhysicalAssetRevocations : IClassRoleType
    {
        public PhysicalAssetRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface PhysicalAssetPropertyRevocations : IClassRoleType
    {
        public PhysicalAssetPropertyRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface WorkMasterRevocations : IClassRoleType
    {
        public WorkMasterRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface GrantRevocations : IClassRoleType
    {
        public GrantRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface CreatePermissionRevocations : IClassRoleType
    {
        public CreatePermissionRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface ExecutePermissionRevocations : IClassRoleType
    {
        public ExecutePermissionRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface ReadPermissionRevocations : IClassRoleType
    {
        public ReadPermissionRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface WritePermissionRevocations : IClassRoleType
    {
        public WritePermissionRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface RevocationRevocations : IClassRoleType
    {
        public RevocationRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface RoleRevocations : IClassRoleType
    {
        public RoleRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface SecurityTokenRevocations : IClassRoleType
    {
        public SecurityTokenRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/
/*
    public interface UserGroupRevocations : IClassRoleType
    {
        public UserGroupRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        new Revocation ObjectType => this.M.Revocation;
    }
*/

    public interface UniquelyIdentifiableUniqueId : IInterfaceRoleType
    {
    }

/*
    public interface DispatchStatusUniqueId : IClassRoleType
    {
        public DispatchStatusUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface EquipmentUniqueId : IClassRoleType
    {
        public EquipmentUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface EquipmentActualUniqueId : IClassRoleType
    {
        public EquipmentActualUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface EquipmentClassUniqueId : IClassRoleType
    {
        public EquipmentClassUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface EquipmentClassPropertyUniqueId : IClassRoleType
    {
        public EquipmentClassPropertyUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface EquipmentLevelUniqueId : IClassRoleType
    {
        public EquipmentLevelUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface EquipmentPropertyUniqueId : IClassRoleType
    {
        public EquipmentPropertyUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface EquipmentRequirementUniqueId : IClassRoleType
    {
        public EquipmentRequirementUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface HierarchyScopeUniqueId : IClassRoleType
    {
        public HierarchyScopeUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface JobOrderUniqueId : IClassRoleType
    {
        public JobOrderUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface JobResponseUniqueId : IClassRoleType
    {
        public JobResponseUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface MaterialActualUniqueId : IClassRoleType
    {
        public MaterialActualUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface MaterialRequirementUniqueId : IClassRoleType
    {
        public MaterialRequirementUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface OperationsDefinitionUniqueId : IClassRoleType
    {
        public OperationsDefinitionUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface OperationsSegmentUniqueId : IClassRoleType
    {
        public OperationsSegmentUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface OperationsTypeUniqueId : IClassRoleType
    {
        public OperationsTypeUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface PersonUniqueId : IClassRoleType
    {
        public PersonUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface PersonnelActualUniqueId : IClassRoleType
    {
        public PersonnelActualUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface PersonnelClassUniqueId : IClassRoleType
    {
        public PersonnelClassUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface PersonnelClassPropertyUniqueId : IClassRoleType
    {
        public PersonnelClassPropertyUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface PersonnelRequirementUniqueId : IClassRoleType
    {
        public PersonnelRequirementUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface PersonPropertyUniqueId : IClassRoleType
    {
        public PersonPropertyUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface PhysicalAssetUniqueId : IClassRoleType
    {
        public PhysicalAssetUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface PhysicalAssetPropertyUniqueId : IClassRoleType
    {
        public PhysicalAssetPropertyUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface WorkMasterUniqueId : IClassRoleType
    {
        public WorkMasterUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface GrantUniqueId : IClassRoleType
    {
        public GrantUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface RevocationUniqueId : IClassRoleType
    {
        public RevocationUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface RoleUniqueId : IClassRoleType
    {
        public RoleUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface SecurityTokenUniqueId : IClassRoleType
    {
        public SecurityTokenUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface UserGroupUniqueId : IClassRoleType
    {
        public UserGroupUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/

    public interface DelegatedAccessObjectDelegatedAccess : IInterfaceRoleType
    {
        new public Object ObjectType { get; }
    }


    public interface PermissionClassPointer : IInterfaceRoleType
    {
    }

/*
    public interface CreatePermissionClassPointer : IClassRoleType
    {
        public CreatePermissionClassPointer(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface ExecutePermissionClassPointer : IClassRoleType
    {
        public ExecutePermissionClassPointer(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface ReadPermissionClassPointer : IClassRoleType
    {
        public ReadPermissionClassPointer(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public interface WritePermissionClassPointer : IClassRoleType
    {
        public WritePermissionClassPointer(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/

    public interface SecurityTokenOwnerOwnerSecurityToken : IInterfaceRoleType
    {
        new public SecurityToken ObjectType { get; }
    }


    public interface SecurityTokenOwnerOwnerGrant : IInterfaceRoleType
    {
        new public Grant ObjectType { get; }
    }


    public interface UserUserName : IInterfaceRoleType
    {
    }


    public interface UserNormalizedUserName : IInterfaceRoleType
    {
    }


}