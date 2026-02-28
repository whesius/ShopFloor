namespace Allors.Database.Meta
{
    public interface DispatchStatusWhereName : IAssociationType
    {
        new DispatchStatus ObjectType { get; }
    }
    public interface DispatchStatusWhereIsActive : IAssociationType
    {
        new DispatchStatus ObjectType { get; }
    }
    public interface EquipmentWhereName : IAssociationType
    {
        new Equipment ObjectType { get; }
    }
    public interface EquipmentWhereDescription : IAssociationType
    {
        new Equipment ObjectType { get; }
    }
    public interface EquipmentsWhereEquipmentLevel : IAssociationType
    {
        new Equipment ObjectType { get; }
    }
    public interface EquipmentsWhereEquipmentClass : IAssociationType
    {
        new Equipment ObjectType { get; }
    }
    public interface EquipmentWhereEquipmentProperty : IAssociationType
    {
        new Equipment ObjectType { get; }
    }
    public interface EquipmentWhereEquipmentChild : IAssociationType
    {
        new Equipment ObjectType { get; }
    }
    public interface EquipmentsWhereEquipmentParent : IAssociationType
    {
        new Equipment ObjectType { get; }
    }
    public interface EquipmentsWherePhysicalAsset : IAssociationType
    {
        new Equipment ObjectType { get; }
    }
    public interface EquipmentsWhereHierarchyScope : IAssociationType
    {
        new Equipment ObjectType { get; }
    }
    public interface EquipmentWhereDisplayName : IAssociationType
    {
        new Equipment ObjectType { get; }
    }
    public interface EquipmentActualsWhereEquipment : IAssociationType
    {
        new EquipmentActual ObjectType { get; }
    }
    public interface EquipmentActualsWhereEquipmentClass : IAssociationType
    {
        new EquipmentActual ObjectType { get; }
    }
    public interface EquipmentActualWhereDescription : IAssociationType
    {
        new EquipmentActual ObjectType { get; }
    }
    public interface EquipmentClassWhereName : IAssociationType
    {
        new EquipmentClass ObjectType { get; }
    }
    public interface EquipmentClassWhereDescription : IAssociationType
    {
        new EquipmentClass ObjectType { get; }
    }
    public interface EquipmentClassesWhereEquipmentLevel : IAssociationType
    {
        new EquipmentClass ObjectType { get; }
    }
    public interface EquipmentClassWhereEquipmentClassProperty : IAssociationType
    {
        new EquipmentClass ObjectType { get; }
    }
    public interface EquipmentClassWhereEquipmentClassChild : IAssociationType
    {
        new EquipmentClass ObjectType { get; }
    }
    public interface EquipmentClassesWhereEquipmentClassParent : IAssociationType
    {
        new EquipmentClass ObjectType { get; }
    }
    public interface EquipmentClassPropertyWhereName : IAssociationType
    {
        new EquipmentClassProperty ObjectType { get; }
    }
    public interface EquipmentClassPropertyWhereDescription : IAssociationType
    {
        new EquipmentClassProperty ObjectType { get; }
    }
    public interface EquipmentClassPropertyWhereDefaultValue : IAssociationType
    {
        new EquipmentClassProperty ObjectType { get; }
    }
    public interface EquipmentClassPropertyWherePropertyType : IAssociationType
    {
        new EquipmentClassProperty ObjectType { get; }
    }
    public interface EquipmentClassPropertyWhereEquipmentClassPropertyChild : IAssociationType
    {
        new EquipmentClassProperty ObjectType { get; }
    }
    public interface EquipmentLevelWhereName : IAssociationType
    {
        new EquipmentLevel ObjectType { get; }
    }
    public interface EquipmentLevelWhereIsActive : IAssociationType
    {
        new EquipmentLevel ObjectType { get; }
    }
    public interface EquipmentPropertyWhereName : IAssociationType
    {
        new EquipmentProperty ObjectType { get; }
    }
    public interface EquipmentPropertyWhereDescription : IAssociationType
    {
        new EquipmentProperty ObjectType { get; }
    }
    public interface EquipmentPropertyWhereValue : IAssociationType
    {
        new EquipmentProperty ObjectType { get; }
    }
    public interface EquipmentPropertiesWhereEquipmentClassProperty : IAssociationType
    {
        new EquipmentProperty ObjectType { get; }
    }
    public interface EquipmentPropertyWhereEquipmentPropertyChild : IAssociationType
    {
        new EquipmentProperty ObjectType { get; }
    }
    public interface EquipmentRequirementsWhereEquipmentClass : IAssociationType
    {
        new EquipmentRequirement ObjectType { get; }
    }
    public interface EquipmentRequirementsWhereEquipment : IAssociationType
    {
        new EquipmentRequirement ObjectType { get; }
    }
    public interface EquipmentRequirementWhereQuantity : IAssociationType
    {
        new EquipmentRequirement ObjectType { get; }
    }
    public interface EquipmentRequirementWhereDescription : IAssociationType
    {
        new EquipmentRequirement ObjectType { get; }
    }
    public interface HierarchyScopesWhereScopedEquipment : IAssociationType
    {
        new HierarchyScope ObjectType { get; }
    }
    public interface HierarchyScopesWhereEquipmentLevel : IAssociationType
    {
        new HierarchyScope ObjectType { get; }
    }
    public interface JobOrderWhereName : IAssociationType
    {
        new JobOrder ObjectType { get; }
    }
    public interface JobOrderWhereDescription : IAssociationType
    {
        new JobOrder ObjectType { get; }
    }
    public interface JobOrdersWhereWorkType : IAssociationType
    {
        new JobOrder ObjectType { get; }
    }
    public interface JobOrdersWhereWorkMaster : IAssociationType
    {
        new JobOrder ObjectType { get; }
    }
    public interface JobOrdersWhereEquipment : IAssociationType
    {
        new JobOrder ObjectType { get; }
    }
    public interface JobOrderWherePriority : IAssociationType
    {
        new JobOrder ObjectType { get; }
    }
    public interface JobOrdersWhereDispatchStatus : IAssociationType
    {
        new JobOrder ObjectType { get; }
    }
    public interface JobOrderWhereStartTime : IAssociationType
    {
        new JobOrder ObjectType { get; }
    }
    public interface JobOrderWhereEndTime : IAssociationType
    {
        new JobOrder ObjectType { get; }
    }
    public interface JobOrdersWhereHierarchyScope : IAssociationType
    {
        new JobOrder ObjectType { get; }
    }
    public interface JobOrderWherePersonnelRequirement : IAssociationType
    {
        new JobOrder ObjectType { get; }
    }
    public interface JobOrderWhereEquipmentRequirement : IAssociationType
    {
        new JobOrder ObjectType { get; }
    }
    public interface JobOrderWhereMaterialRequirement : IAssociationType
    {
        new JobOrder ObjectType { get; }
    }
    public interface JobOrdersWhereAssignedTo : IAssociationType
    {
        new JobOrder ObjectType { get; }
    }
    public interface JobOrderWhereResponse : IAssociationType
    {
        new JobOrder ObjectType { get; }
    }
    public interface JobResponseWhereDescription : IAssociationType
    {
        new JobResponse ObjectType { get; }
    }
    public interface JobResponsesWhereWorkType : IAssociationType
    {
        new JobResponse ObjectType { get; }
    }
    public interface JobResponsesWhereJobOrder : IAssociationType
    {
        new JobResponse ObjectType { get; }
    }
    public interface JobResponseWhereStartTime : IAssociationType
    {
        new JobResponse ObjectType { get; }
    }
    public interface JobResponseWhereEndTime : IAssociationType
    {
        new JobResponse ObjectType { get; }
    }
    public interface JobResponseWhereJobState : IAssociationType
    {
        new JobResponse ObjectType { get; }
    }
    public interface JobResponseWherePersonnelActual : IAssociationType
    {
        new JobResponse ObjectType { get; }
    }
    public interface JobResponseWhereEquipmentActual : IAssociationType
    {
        new JobResponse ObjectType { get; }
    }
    public interface JobResponseWhereMaterialActual : IAssociationType
    {
        new JobResponse ObjectType { get; }
    }
    public interface MaterialActualWhereName : IAssociationType
    {
        new MaterialActual ObjectType { get; }
    }
    public interface MaterialActualWhereQuantity : IAssociationType
    {
        new MaterialActual ObjectType { get; }
    }
    public interface MaterialActualWhereDescription : IAssociationType
    {
        new MaterialActual ObjectType { get; }
    }
    public interface MaterialRequirementWhereName : IAssociationType
    {
        new MaterialRequirement ObjectType { get; }
    }
    public interface MaterialRequirementWhereQuantity : IAssociationType
    {
        new MaterialRequirement ObjectType { get; }
    }
    public interface MaterialRequirementWhereDescription : IAssociationType
    {
        new MaterialRequirement ObjectType { get; }
    }
    public interface OperationsDefinitionWhereName : IAssociationType
    {
        new OperationsDefinition ObjectType { get; }
    }
    public interface OperationsDefinitionWhereDescription : IAssociationType
    {
        new OperationsDefinition ObjectType { get; }
    }
    public interface OperationsDefinitionWhereVersion : IAssociationType
    {
        new OperationsDefinition ObjectType { get; }
    }
    public interface OperationsDefinitionsWhereOperationsType : IAssociationType
    {
        new OperationsDefinition ObjectType { get; }
    }
    public interface OperationsDefinitionWhereOperationsSegment : IAssociationType
    {
        new OperationsDefinition ObjectType { get; }
    }
    public interface OperationsDefinitionWhereEffectiveStartDate : IAssociationType
    {
        new OperationsDefinition ObjectType { get; }
    }
    public interface OperationsDefinitionWhereEffectiveEndDate : IAssociationType
    {
        new OperationsDefinition ObjectType { get; }
    }
    public interface OperationsDefinitionsWhereHierarchyScope : IAssociationType
    {
        new OperationsDefinition ObjectType { get; }
    }
    public interface OperationsSegmentWhereName : IAssociationType
    {
        new OperationsSegment ObjectType { get; }
    }
    public interface OperationsSegmentWhereDescription : IAssociationType
    {
        new OperationsSegment ObjectType { get; }
    }
    public interface OperationsSegmentWhereDuration : IAssociationType
    {
        new OperationsSegment ObjectType { get; }
    }
    public interface OperationsSegmentsWhereOperationsType : IAssociationType
    {
        new OperationsSegment ObjectType { get; }
    }
    public interface OperationsSegmentWherePersonnelSpecification : IAssociationType
    {
        new OperationsSegment ObjectType { get; }
    }
    public interface OperationsSegmentWhereEquipmentSpecification : IAssociationType
    {
        new OperationsSegment ObjectType { get; }
    }
    public interface OperationsSegmentWhereMaterialSpecification : IAssociationType
    {
        new OperationsSegment ObjectType { get; }
    }
    public interface OperationsSegmentWhereOperationsSegmentChild : IAssociationType
    {
        new OperationsSegment ObjectType { get; }
    }
    public interface OperationsSegmentsWhereOperationsSegmentParent : IAssociationType
    {
        new OperationsSegment ObjectType { get; }
    }
    public interface OperationsTypeWhereName : IAssociationType
    {
        new OperationsType ObjectType { get; }
    }
    public interface OperationsTypeWhereIsActive : IAssociationType
    {
        new OperationsType ObjectType { get; }
    }
    public interface PersonWhereFirstName : IAssociationType
    {
        new Person ObjectType { get; }
    }
    public interface PersonWhereLastName : IAssociationType
    {
        new Person ObjectType { get; }
    }
    public interface PersonWhereUser : IAssociationType
    {
        new Person ObjectType { get; }
    }
    public interface PeopleWherePersonnelClass : IAssociationType
    {
        new Person ObjectType { get; }
    }
    public interface PersonWherePersonProperty : IAssociationType
    {
        new Person ObjectType { get; }
    }
    public interface PersonWhereDisplayName : IAssociationType
    {
        new Person ObjectType { get; }
    }
    public interface PersonnelActualsWherePerson : IAssociationType
    {
        new PersonnelActual ObjectType { get; }
    }
    public interface PersonnelActualsWherePersonnelClass : IAssociationType
    {
        new PersonnelActual ObjectType { get; }
    }
    public interface PersonnelActualWhereDescription : IAssociationType
    {
        new PersonnelActual ObjectType { get; }
    }
    public interface PersonnelClassWhereName : IAssociationType
    {
        new PersonnelClass ObjectType { get; }
    }
    public interface PersonnelClassWhereDescription : IAssociationType
    {
        new PersonnelClass ObjectType { get; }
    }
    public interface PersonnelClassWherePersonnelClassProperty : IAssociationType
    {
        new PersonnelClass ObjectType { get; }
    }
    public interface PersonnelClassesWherePersonnelClassParent : IAssociationType
    {
        new PersonnelClass ObjectType { get; }
    }
    public interface PersonnelClassPropertyWhereName : IAssociationType
    {
        new PersonnelClassProperty ObjectType { get; }
    }
    public interface PersonnelClassPropertyWhereDescription : IAssociationType
    {
        new PersonnelClassProperty ObjectType { get; }
    }
    public interface PersonnelClassPropertyWhereDefaultValue : IAssociationType
    {
        new PersonnelClassProperty ObjectType { get; }
    }
    public interface PersonnelRequirementsWherePersonnelClass : IAssociationType
    {
        new PersonnelRequirement ObjectType { get; }
    }
    public interface PersonnelRequirementsWherePerson : IAssociationType
    {
        new PersonnelRequirement ObjectType { get; }
    }
    public interface PersonnelRequirementWhereQuantity : IAssociationType
    {
        new PersonnelRequirement ObjectType { get; }
    }
    public interface PersonnelRequirementWhereDescription : IAssociationType
    {
        new PersonnelRequirement ObjectType { get; }
    }
    public interface PersonPropertyWhereName : IAssociationType
    {
        new PersonProperty ObjectType { get; }
    }
    public interface PersonPropertyWhereValue : IAssociationType
    {
        new PersonProperty ObjectType { get; }
    }
    public interface PersonPropertiesWherePersonnelClassProperty : IAssociationType
    {
        new PersonProperty ObjectType { get; }
    }
    public interface PhysicalAssetWhereName : IAssociationType
    {
        new PhysicalAsset ObjectType { get; }
    }
    public interface PhysicalAssetWhereDescription : IAssociationType
    {
        new PhysicalAsset ObjectType { get; }
    }
    public interface PhysicalAssetWhereSerialNumber : IAssociationType
    {
        new PhysicalAsset ObjectType { get; }
    }
    public interface PhysicalAssetWhereManufacturer : IAssociationType
    {
        new PhysicalAsset ObjectType { get; }
    }
    public interface PhysicalAssetWhereModelNumber : IAssociationType
    {
        new PhysicalAsset ObjectType { get; }
    }
    public interface PhysicalAssetWhereInstallationDate : IAssociationType
    {
        new PhysicalAsset ObjectType { get; }
    }
    public interface PhysicalAssetWherePhysicalAssetProperty : IAssociationType
    {
        new PhysicalAsset ObjectType { get; }
    }
    public interface PhysicalAssetWherePhysicalAssetChild : IAssociationType
    {
        new PhysicalAsset ObjectType { get; }
    }
    public interface PhysicalAssetPropertyWhereName : IAssociationType
    {
        new PhysicalAssetProperty ObjectType { get; }
    }
    public interface PhysicalAssetPropertyWhereValue : IAssociationType
    {
        new PhysicalAssetProperty ObjectType { get; }
    }
    public interface WorkMasterWhereName : IAssociationType
    {
        new WorkMaster ObjectType { get; }
    }
    public interface WorkMasterWhereDescription : IAssociationType
    {
        new WorkMaster ObjectType { get; }
    }
    public interface WorkMasterWhereVersion : IAssociationType
    {
        new WorkMaster ObjectType { get; }
    }
    public interface WorkMastersWhereWorkType : IAssociationType
    {
        new WorkMaster ObjectType { get; }
    }
    public interface WorkMasterWhereDuration : IAssociationType
    {
        new WorkMaster ObjectType { get; }
    }
    public interface WorkMastersWhereOperationsDefinition : IAssociationType
    {
        new WorkMaster ObjectType { get; }
    }
    public interface WorkMasterWherePersonnelSpecification : IAssociationType
    {
        new WorkMaster ObjectType { get; }
    }
    public interface WorkMasterWhereEquipmentSpecification : IAssociationType
    {
        new WorkMaster ObjectType { get; }
    }
    public interface WorkMasterWhereMaterialSpecification : IAssociationType
    {
        new WorkMaster ObjectType { get; }
    }
    public interface WorkMasterWhereWorkMasterChild : IAssociationType
    {
        new WorkMaster ObjectType { get; }
    }
    public interface GrantsWhereSubjectGroup : IAssociationType
    {
        new Grant ObjectType { get; }
    }
    public interface GrantsWhereSubject : IAssociationType
    {
        new Grant ObjectType { get; }
    }
    public interface GrantsWhereRole : IAssociationType
    {
        new Grant ObjectType { get; }
    }
    public interface GrantsWhereEffectivePermission : IAssociationType
    {
        new Grant ObjectType { get; }
    }
    public interface GrantsWhereEffectiveUser : IAssociationType
    {
        new Grant ObjectType { get; }
    }

    public interface ExecutePermissionWhereMethodTypePointer : IAssociationType
    {
        new ExecutePermission ObjectType { get; }
    }
    public interface ReadPermissionWhereRelationTypePointer : IAssociationType
    {
        new ReadPermission ObjectType { get; }
    }
    public interface WritePermissionWhereRelationTypePointer : IAssociationType
    {
        new WritePermission ObjectType { get; }
    }
    public interface RevocationsWhereDeniedPermission : IAssociationType
    {
        new Revocation ObjectType { get; }
    }
    public interface RolesWherePermission : IAssociationType
    {
        new Role ObjectType { get; }
    }
    public interface RoleWhereName : IAssociationType
    {
        new Role ObjectType { get; }
    }
    public interface SecurityTokensWhereGrant : IAssociationType
    {
        new SecurityToken ObjectType { get; }
    }
    public interface SecurityTokenWhereSecurityStamp : IAssociationType
    {
        new SecurityToken ObjectType { get; }
    }
    public interface UserGroupsWhereMember : IAssociationType
    {
        new UserGroup ObjectType { get; }
    }
    public interface UserGroupWhereName : IAssociationType
    {
        new UserGroup ObjectType { get; }
    }

    public interface ObjectsWhereSecurityToken : IAssociationType
    {
        new Object ObjectType { get; }
    }
    public interface ObjectsWhereRevocation : IAssociationType
    {
        new Object ObjectType { get; }
    }
    public interface UniquelyIdentifiableWhereUniqueId : IAssociationType
    {
        new UniquelyIdentifiable ObjectType { get; }
    }
    public interface DelegatedAccessObjectsWhereDelegatedAccess : IAssociationType
    {
        new DelegatedAccessObject ObjectType { get; }
    }
    public interface PermissionWhereClassPointer : IAssociationType
    {
        new Permission ObjectType { get; }
    }
    public interface SecurityTokenOwnerWhereOwnerSecurityToken : IAssociationType
    {
        new SecurityTokenOwner ObjectType { get; }
    }
    public interface SecurityTokenOwnerWhereOwnerGrant : IAssociationType
    {
        new SecurityTokenOwner ObjectType { get; }
    }
    public interface UserWhereUserName : IAssociationType
    {
        new User ObjectType { get; }
    }
    public interface UserWhereNormalizedUserName : IAssociationType
    {
        new User ObjectType { get; }
    }
}