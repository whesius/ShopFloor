namespace Allors.Database.Meta.Configuration
{
    public class DispatchStatusName : ClassRoleType, Meta.DispatchStatusName
    {
        public DispatchStatusName(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class DispatchStatusIsActive : ClassRoleType, Meta.DispatchStatusIsActive
    {
        public DispatchStatusIsActive(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class EquipmentName : ClassRoleType, Meta.EquipmentName
    {
        public EquipmentName(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class EquipmentDescription : ClassRoleType, Meta.EquipmentDescription
    {
        public EquipmentDescription(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class EquipmentEquipmentLevel : ClassRoleType, Meta.EquipmentEquipmentLevel
    {
        public EquipmentEquipmentLevel(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.EquipmentLevel ObjectType => ((M)this.M).EquipmentLevel;
    }


    public class EquipmentEquipmentClasses : ClassRoleType, Meta.EquipmentEquipmentClasses
    {
        public EquipmentEquipmentClasses(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.EquipmentClass ObjectType => ((M)this.M).EquipmentClass;
    }


    public class EquipmentEquipmentProperties : ClassRoleType, Meta.EquipmentEquipmentProperties
    {
        public EquipmentEquipmentProperties(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.EquipmentProperty ObjectType => ((M)this.M).EquipmentProperty;
    }


    public class EquipmentEquipmentChildren : ClassRoleType, Meta.EquipmentEquipmentChildren
    {
        public EquipmentEquipmentChildren(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.Equipment ObjectType => ((M)this.M).Equipment;
    }


    public class EquipmentEquipmentParent : ClassRoleType, Meta.EquipmentEquipmentParent
    {
        public EquipmentEquipmentParent(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.Equipment ObjectType => ((M)this.M).Equipment;
    }


    public class EquipmentPhysicalAsset : ClassRoleType, Meta.EquipmentPhysicalAsset
    {
        public EquipmentPhysicalAsset(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.PhysicalAsset ObjectType => ((M)this.M).PhysicalAsset;
    }


    public class EquipmentHierarchyScope : ClassRoleType, Meta.EquipmentHierarchyScope
    {
        public EquipmentHierarchyScope(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.HierarchyScope ObjectType => ((M)this.M).HierarchyScope;
    }


    public class EquipmentDisplayName : ClassRoleType, Meta.EquipmentDisplayName
    {
        public EquipmentDisplayName(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class EquipmentActualEquipment : ClassRoleType, Meta.EquipmentActualEquipment
    {
        public EquipmentActualEquipment(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.Equipment ObjectType => ((M)this.M).Equipment;
    }


    public class EquipmentActualEquipmentClass : ClassRoleType, Meta.EquipmentActualEquipmentClass
    {
        public EquipmentActualEquipmentClass(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.EquipmentClass ObjectType => ((M)this.M).EquipmentClass;
    }


    public class EquipmentActualDescription : ClassRoleType, Meta.EquipmentActualDescription
    {
        public EquipmentActualDescription(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class EquipmentClassName : ClassRoleType, Meta.EquipmentClassName
    {
        public EquipmentClassName(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class EquipmentClassDescription : ClassRoleType, Meta.EquipmentClassDescription
    {
        public EquipmentClassDescription(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class EquipmentClassEquipmentLevel : ClassRoleType, Meta.EquipmentClassEquipmentLevel
    {
        public EquipmentClassEquipmentLevel(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.EquipmentLevel ObjectType => ((M)this.M).EquipmentLevel;
    }


    public class EquipmentClassEquipmentClassProperties : ClassRoleType, Meta.EquipmentClassEquipmentClassProperties
    {
        public EquipmentClassEquipmentClassProperties(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.EquipmentClassProperty ObjectType => ((M)this.M).EquipmentClassProperty;
    }


    public class EquipmentClassEquipmentClassChildren : ClassRoleType, Meta.EquipmentClassEquipmentClassChildren
    {
        public EquipmentClassEquipmentClassChildren(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.EquipmentClass ObjectType => ((M)this.M).EquipmentClass;
    }


    public class EquipmentClassEquipmentClassParent : ClassRoleType, Meta.EquipmentClassEquipmentClassParent
    {
        public EquipmentClassEquipmentClassParent(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.EquipmentClass ObjectType => ((M)this.M).EquipmentClass;
    }


    public class EquipmentClassPropertyName : ClassRoleType, Meta.EquipmentClassPropertyName
    {
        public EquipmentClassPropertyName(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class EquipmentClassPropertyDescription : ClassRoleType, Meta.EquipmentClassPropertyDescription
    {
        public EquipmentClassPropertyDescription(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class EquipmentClassPropertyDefaultValue : ClassRoleType, Meta.EquipmentClassPropertyDefaultValue
    {
        public EquipmentClassPropertyDefaultValue(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class EquipmentClassPropertyPropertyType : ClassRoleType, Meta.EquipmentClassPropertyPropertyType
    {
        public EquipmentClassPropertyPropertyType(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class EquipmentClassPropertyEquipmentClassPropertyChildren : ClassRoleType, Meta.EquipmentClassPropertyEquipmentClassPropertyChildren
    {
        public EquipmentClassPropertyEquipmentClassPropertyChildren(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.EquipmentClassProperty ObjectType => ((M)this.M).EquipmentClassProperty;
    }


    public class EquipmentLevelName : ClassRoleType, Meta.EquipmentLevelName
    {
        public EquipmentLevelName(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class EquipmentLevelIsActive : ClassRoleType, Meta.EquipmentLevelIsActive
    {
        public EquipmentLevelIsActive(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class EquipmentPropertyName : ClassRoleType, Meta.EquipmentPropertyName
    {
        public EquipmentPropertyName(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class EquipmentPropertyDescription : ClassRoleType, Meta.EquipmentPropertyDescription
    {
        public EquipmentPropertyDescription(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class EquipmentPropertyValue : ClassRoleType, Meta.EquipmentPropertyValue
    {
        public EquipmentPropertyValue(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class EquipmentPropertyEquipmentClassProperty : ClassRoleType, Meta.EquipmentPropertyEquipmentClassProperty
    {
        public EquipmentPropertyEquipmentClassProperty(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.EquipmentClassProperty ObjectType => ((M)this.M).EquipmentClassProperty;
    }


    public class EquipmentPropertyEquipmentPropertyChildren : ClassRoleType, Meta.EquipmentPropertyEquipmentPropertyChildren
    {
        public EquipmentPropertyEquipmentPropertyChildren(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.EquipmentProperty ObjectType => ((M)this.M).EquipmentProperty;
    }


    public class EquipmentRequirementEquipmentClass : ClassRoleType, Meta.EquipmentRequirementEquipmentClass
    {
        public EquipmentRequirementEquipmentClass(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.EquipmentClass ObjectType => ((M)this.M).EquipmentClass;
    }


    public class EquipmentRequirementEquipment : ClassRoleType, Meta.EquipmentRequirementEquipment
    {
        public EquipmentRequirementEquipment(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.Equipment ObjectType => ((M)this.M).Equipment;
    }


    public class EquipmentRequirementQuantity : ClassRoleType, Meta.EquipmentRequirementQuantity
    {
        public EquipmentRequirementQuantity(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class EquipmentRequirementDescription : ClassRoleType, Meta.EquipmentRequirementDescription
    {
        public EquipmentRequirementDescription(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class HierarchyScopeScopedEquipment : ClassRoleType, Meta.HierarchyScopeScopedEquipment
    {
        public HierarchyScopeScopedEquipment(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.Equipment ObjectType => ((M)this.M).Equipment;
    }


    public class HierarchyScopeEquipmentLevel : ClassRoleType, Meta.HierarchyScopeEquipmentLevel
    {
        public HierarchyScopeEquipmentLevel(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.EquipmentLevel ObjectType => ((M)this.M).EquipmentLevel;
    }


    public class JobOrderName : ClassRoleType, Meta.JobOrderName
    {
        public JobOrderName(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class JobOrderDescription : ClassRoleType, Meta.JobOrderDescription
    {
        public JobOrderDescription(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class JobOrderWorkType : ClassRoleType, Meta.JobOrderWorkType
    {
        public JobOrderWorkType(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.OperationsType ObjectType => ((M)this.M).OperationsType;
    }


    public class JobOrderWorkMaster : ClassRoleType, Meta.JobOrderWorkMaster
    {
        public JobOrderWorkMaster(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.WorkMaster ObjectType => ((M)this.M).WorkMaster;
    }


    public class JobOrderEquipment : ClassRoleType, Meta.JobOrderEquipment
    {
        public JobOrderEquipment(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.Equipment ObjectType => ((M)this.M).Equipment;
    }


    public class JobOrderPriority : ClassRoleType, Meta.JobOrderPriority
    {
        public JobOrderPriority(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class JobOrderDispatchStatus : ClassRoleType, Meta.JobOrderDispatchStatus
    {
        public JobOrderDispatchStatus(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.DispatchStatus ObjectType => ((M)this.M).DispatchStatus;
    }


    public class JobOrderStartTime : ClassRoleType, Meta.JobOrderStartTime
    {
        public JobOrderStartTime(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class JobOrderEndTime : ClassRoleType, Meta.JobOrderEndTime
    {
        public JobOrderEndTime(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class JobOrderHierarchyScope : ClassRoleType, Meta.JobOrderHierarchyScope
    {
        public JobOrderHierarchyScope(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.HierarchyScope ObjectType => ((M)this.M).HierarchyScope;
    }


    public class JobOrderPersonnelRequirements : ClassRoleType, Meta.JobOrderPersonnelRequirements
    {
        public JobOrderPersonnelRequirements(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.PersonnelRequirement ObjectType => ((M)this.M).PersonnelRequirement;
    }


    public class JobOrderEquipmentRequirements : ClassRoleType, Meta.JobOrderEquipmentRequirements
    {
        public JobOrderEquipmentRequirements(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.EquipmentRequirement ObjectType => ((M)this.M).EquipmentRequirement;
    }


    public class JobOrderMaterialRequirements : ClassRoleType, Meta.JobOrderMaterialRequirements
    {
        public JobOrderMaterialRequirements(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.MaterialRequirement ObjectType => ((M)this.M).MaterialRequirement;
    }


    public class JobOrderAssignedTo : ClassRoleType, Meta.JobOrderAssignedTo
    {
        public JobOrderAssignedTo(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.Person ObjectType => ((M)this.M).Person;
    }


    public class JobOrderResponse : ClassRoleType, Meta.JobOrderResponse
    {
        public JobOrderResponse(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.JobResponse ObjectType => ((M)this.M).JobResponse;
    }


    public class JobResponseDescription : ClassRoleType, Meta.JobResponseDescription
    {
        public JobResponseDescription(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class JobResponseWorkType : ClassRoleType, Meta.JobResponseWorkType
    {
        public JobResponseWorkType(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.OperationsType ObjectType => ((M)this.M).OperationsType;
    }


    public class JobResponseJobOrder : ClassRoleType, Meta.JobResponseJobOrder
    {
        public JobResponseJobOrder(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.JobOrder ObjectType => ((M)this.M).JobOrder;
    }


    public class JobResponseStartTime : ClassRoleType, Meta.JobResponseStartTime
    {
        public JobResponseStartTime(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class JobResponseEndTime : ClassRoleType, Meta.JobResponseEndTime
    {
        public JobResponseEndTime(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class JobResponseJobState : ClassRoleType, Meta.JobResponseJobState
    {
        public JobResponseJobState(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class JobResponsePersonnelActuals : ClassRoleType, Meta.JobResponsePersonnelActuals
    {
        public JobResponsePersonnelActuals(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.PersonnelActual ObjectType => ((M)this.M).PersonnelActual;
    }


    public class JobResponseEquipmentActuals : ClassRoleType, Meta.JobResponseEquipmentActuals
    {
        public JobResponseEquipmentActuals(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.EquipmentActual ObjectType => ((M)this.M).EquipmentActual;
    }


    public class JobResponseMaterialActuals : ClassRoleType, Meta.JobResponseMaterialActuals
    {
        public JobResponseMaterialActuals(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.MaterialActual ObjectType => ((M)this.M).MaterialActual;
    }


    public class MaterialActualName : ClassRoleType, Meta.MaterialActualName
    {
        public MaterialActualName(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class MaterialActualQuantity : ClassRoleType, Meta.MaterialActualQuantity
    {
        public MaterialActualQuantity(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class MaterialActualDescription : ClassRoleType, Meta.MaterialActualDescription
    {
        public MaterialActualDescription(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class MaterialRequirementName : ClassRoleType, Meta.MaterialRequirementName
    {
        public MaterialRequirementName(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class MaterialRequirementQuantity : ClassRoleType, Meta.MaterialRequirementQuantity
    {
        public MaterialRequirementQuantity(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class MaterialRequirementDescription : ClassRoleType, Meta.MaterialRequirementDescription
    {
        public MaterialRequirementDescription(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class OperationsDefinitionName : ClassRoleType, Meta.OperationsDefinitionName
    {
        public OperationsDefinitionName(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class OperationsDefinitionDescription : ClassRoleType, Meta.OperationsDefinitionDescription
    {
        public OperationsDefinitionDescription(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class OperationsDefinitionVersion : ClassRoleType, Meta.OperationsDefinitionVersion
    {
        public OperationsDefinitionVersion(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class OperationsDefinitionOperationsType : ClassRoleType, Meta.OperationsDefinitionOperationsType
    {
        public OperationsDefinitionOperationsType(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.OperationsType ObjectType => ((M)this.M).OperationsType;
    }


    public class OperationsDefinitionOperationsSegments : ClassRoleType, Meta.OperationsDefinitionOperationsSegments
    {
        public OperationsDefinitionOperationsSegments(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.OperationsSegment ObjectType => ((M)this.M).OperationsSegment;
    }


    public class OperationsDefinitionEffectiveStartDate : ClassRoleType, Meta.OperationsDefinitionEffectiveStartDate
    {
        public OperationsDefinitionEffectiveStartDate(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class OperationsDefinitionEffectiveEndDate : ClassRoleType, Meta.OperationsDefinitionEffectiveEndDate
    {
        public OperationsDefinitionEffectiveEndDate(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class OperationsDefinitionHierarchyScope : ClassRoleType, Meta.OperationsDefinitionHierarchyScope
    {
        public OperationsDefinitionHierarchyScope(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.HierarchyScope ObjectType => ((M)this.M).HierarchyScope;
    }


    public class OperationsSegmentName : ClassRoleType, Meta.OperationsSegmentName
    {
        public OperationsSegmentName(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class OperationsSegmentDescription : ClassRoleType, Meta.OperationsSegmentDescription
    {
        public OperationsSegmentDescription(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class OperationsSegmentDuration : ClassRoleType, Meta.OperationsSegmentDuration
    {
        public OperationsSegmentDuration(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class OperationsSegmentOperationsType : ClassRoleType, Meta.OperationsSegmentOperationsType
    {
        public OperationsSegmentOperationsType(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.OperationsType ObjectType => ((M)this.M).OperationsType;
    }


    public class OperationsSegmentPersonnelSpecifications : ClassRoleType, Meta.OperationsSegmentPersonnelSpecifications
    {
        public OperationsSegmentPersonnelSpecifications(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.PersonnelRequirement ObjectType => ((M)this.M).PersonnelRequirement;
    }


    public class OperationsSegmentEquipmentSpecifications : ClassRoleType, Meta.OperationsSegmentEquipmentSpecifications
    {
        public OperationsSegmentEquipmentSpecifications(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.EquipmentRequirement ObjectType => ((M)this.M).EquipmentRequirement;
    }


    public class OperationsSegmentMaterialSpecifications : ClassRoleType, Meta.OperationsSegmentMaterialSpecifications
    {
        public OperationsSegmentMaterialSpecifications(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.MaterialRequirement ObjectType => ((M)this.M).MaterialRequirement;
    }


    public class OperationsSegmentOperationsSegmentChildren : ClassRoleType, Meta.OperationsSegmentOperationsSegmentChildren
    {
        public OperationsSegmentOperationsSegmentChildren(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.OperationsSegment ObjectType => ((M)this.M).OperationsSegment;
    }


    public class OperationsSegmentOperationsSegmentParent : ClassRoleType, Meta.OperationsSegmentOperationsSegmentParent
    {
        public OperationsSegmentOperationsSegmentParent(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.OperationsSegment ObjectType => ((M)this.M).OperationsSegment;
    }


    public class OperationsTypeName : ClassRoleType, Meta.OperationsTypeName
    {
        public OperationsTypeName(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class OperationsTypeIsActive : ClassRoleType, Meta.OperationsTypeIsActive
    {
        public OperationsTypeIsActive(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class PersonFirstName : ClassRoleType, Meta.PersonFirstName
    {
        public PersonFirstName(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class PersonLastName : ClassRoleType, Meta.PersonLastName
    {
        public PersonLastName(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class PersonUser : ClassRoleType, Meta.PersonUser
    {
        public PersonUser(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.User ObjectType => ((M)this.M).User;
    }


    public class PersonPersonnelClasses : ClassRoleType, Meta.PersonPersonnelClasses
    {
        public PersonPersonnelClasses(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.PersonnelClass ObjectType => ((M)this.M).PersonnelClass;
    }


    public class PersonPersonProperties : ClassRoleType, Meta.PersonPersonProperties
    {
        public PersonPersonProperties(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.PersonProperty ObjectType => ((M)this.M).PersonProperty;
    }


    public class PersonDisplayName : ClassRoleType, Meta.PersonDisplayName
    {
        public PersonDisplayName(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class PersonnelActualPerson : ClassRoleType, Meta.PersonnelActualPerson
    {
        public PersonnelActualPerson(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.Person ObjectType => ((M)this.M).Person;
    }


    public class PersonnelActualPersonnelClass : ClassRoleType, Meta.PersonnelActualPersonnelClass
    {
        public PersonnelActualPersonnelClass(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.PersonnelClass ObjectType => ((M)this.M).PersonnelClass;
    }


    public class PersonnelActualDescription : ClassRoleType, Meta.PersonnelActualDescription
    {
        public PersonnelActualDescription(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class PersonnelClassName : ClassRoleType, Meta.PersonnelClassName
    {
        public PersonnelClassName(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class PersonnelClassDescription : ClassRoleType, Meta.PersonnelClassDescription
    {
        public PersonnelClassDescription(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class PersonnelClassPersonnelClassProperties : ClassRoleType, Meta.PersonnelClassPersonnelClassProperties
    {
        public PersonnelClassPersonnelClassProperties(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.PersonnelClassProperty ObjectType => ((M)this.M).PersonnelClassProperty;
    }


    public class PersonnelClassPersonnelClassParent : ClassRoleType, Meta.PersonnelClassPersonnelClassParent
    {
        public PersonnelClassPersonnelClassParent(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.PersonnelClass ObjectType => ((M)this.M).PersonnelClass;
    }


    public class PersonnelClassPropertyName : ClassRoleType, Meta.PersonnelClassPropertyName
    {
        public PersonnelClassPropertyName(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class PersonnelClassPropertyDescription : ClassRoleType, Meta.PersonnelClassPropertyDescription
    {
        public PersonnelClassPropertyDescription(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class PersonnelClassPropertyDefaultValue : ClassRoleType, Meta.PersonnelClassPropertyDefaultValue
    {
        public PersonnelClassPropertyDefaultValue(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class PersonnelRequirementPersonnelClass : ClassRoleType, Meta.PersonnelRequirementPersonnelClass
    {
        public PersonnelRequirementPersonnelClass(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.PersonnelClass ObjectType => ((M)this.M).PersonnelClass;
    }


    public class PersonnelRequirementPerson : ClassRoleType, Meta.PersonnelRequirementPerson
    {
        public PersonnelRequirementPerson(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.Person ObjectType => ((M)this.M).Person;
    }


    public class PersonnelRequirementQuantity : ClassRoleType, Meta.PersonnelRequirementQuantity
    {
        public PersonnelRequirementQuantity(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class PersonnelRequirementDescription : ClassRoleType, Meta.PersonnelRequirementDescription
    {
        public PersonnelRequirementDescription(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class PersonPropertyName : ClassRoleType, Meta.PersonPropertyName
    {
        public PersonPropertyName(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class PersonPropertyValue : ClassRoleType, Meta.PersonPropertyValue
    {
        public PersonPropertyValue(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class PersonPropertyPersonnelClassProperty : ClassRoleType, Meta.PersonPropertyPersonnelClassProperty
    {
        public PersonPropertyPersonnelClassProperty(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.PersonnelClassProperty ObjectType => ((M)this.M).PersonnelClassProperty;
    }


    public class PhysicalAssetName : ClassRoleType, Meta.PhysicalAssetName
    {
        public PhysicalAssetName(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class PhysicalAssetDescription : ClassRoleType, Meta.PhysicalAssetDescription
    {
        public PhysicalAssetDescription(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class PhysicalAssetSerialNumber : ClassRoleType, Meta.PhysicalAssetSerialNumber
    {
        public PhysicalAssetSerialNumber(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class PhysicalAssetManufacturer : ClassRoleType, Meta.PhysicalAssetManufacturer
    {
        public PhysicalAssetManufacturer(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class PhysicalAssetModelNumber : ClassRoleType, Meta.PhysicalAssetModelNumber
    {
        public PhysicalAssetModelNumber(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class PhysicalAssetInstallationDate : ClassRoleType, Meta.PhysicalAssetInstallationDate
    {
        public PhysicalAssetInstallationDate(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class PhysicalAssetPhysicalAssetProperties : ClassRoleType, Meta.PhysicalAssetPhysicalAssetProperties
    {
        public PhysicalAssetPhysicalAssetProperties(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.PhysicalAssetProperty ObjectType => ((M)this.M).PhysicalAssetProperty;
    }


    public class PhysicalAssetPhysicalAssetChildren : ClassRoleType, Meta.PhysicalAssetPhysicalAssetChildren
    {
        public PhysicalAssetPhysicalAssetChildren(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.PhysicalAsset ObjectType => ((M)this.M).PhysicalAsset;
    }


    public class PhysicalAssetPropertyName : ClassRoleType, Meta.PhysicalAssetPropertyName
    {
        public PhysicalAssetPropertyName(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class PhysicalAssetPropertyValue : ClassRoleType, Meta.PhysicalAssetPropertyValue
    {
        public PhysicalAssetPropertyValue(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class WorkMasterName : ClassRoleType, Meta.WorkMasterName
    {
        public WorkMasterName(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class WorkMasterDescription : ClassRoleType, Meta.WorkMasterDescription
    {
        public WorkMasterDescription(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class WorkMasterVersion : ClassRoleType, Meta.WorkMasterVersion
    {
        public WorkMasterVersion(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class WorkMasterWorkType : ClassRoleType, Meta.WorkMasterWorkType
    {
        public WorkMasterWorkType(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.OperationsType ObjectType => ((M)this.M).OperationsType;
    }


    public class WorkMasterDuration : ClassRoleType, Meta.WorkMasterDuration
    {
        public WorkMasterDuration(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class WorkMasterOperationsDefinition : ClassRoleType, Meta.WorkMasterOperationsDefinition
    {
        public WorkMasterOperationsDefinition(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.OperationsDefinition ObjectType => ((M)this.M).OperationsDefinition;
    }


    public class WorkMasterPersonnelSpecifications : ClassRoleType, Meta.WorkMasterPersonnelSpecifications
    {
        public WorkMasterPersonnelSpecifications(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.PersonnelRequirement ObjectType => ((M)this.M).PersonnelRequirement;
    }


    public class WorkMasterEquipmentSpecifications : ClassRoleType, Meta.WorkMasterEquipmentSpecifications
    {
        public WorkMasterEquipmentSpecifications(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.EquipmentRequirement ObjectType => ((M)this.M).EquipmentRequirement;
    }


    public class WorkMasterMaterialSpecifications : ClassRoleType, Meta.WorkMasterMaterialSpecifications
    {
        public WorkMasterMaterialSpecifications(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.MaterialRequirement ObjectType => ((M)this.M).MaterialRequirement;
    }


    public class WorkMasterWorkMasterChildren : ClassRoleType, Meta.WorkMasterWorkMasterChildren
    {
        public WorkMasterWorkMasterChildren(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.WorkMaster ObjectType => ((M)this.M).WorkMaster;
    }


    public class GrantSubjectGroups : ClassRoleType, Meta.GrantSubjectGroups
    {
        public GrantSubjectGroups(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.UserGroup ObjectType => ((M)this.M).UserGroup;
    }


    public class GrantSubjects : ClassRoleType, Meta.GrantSubjects
    {
        public GrantSubjects(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.User ObjectType => ((M)this.M).User;
    }


    public class GrantRole : ClassRoleType, Meta.GrantRole
    {
        public GrantRole(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.Role ObjectType => ((M)this.M).Role;
    }


    public class GrantEffectivePermissions : ClassRoleType, Meta.GrantEffectivePermissions
    {
        public GrantEffectivePermissions(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.Permission ObjectType => ((M)this.M).Permission;
    }


    public class GrantEffectiveUsers : ClassRoleType, Meta.GrantEffectiveUsers
    {
        public GrantEffectiveUsers(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.User ObjectType => ((M)this.M).User;
    }



    public class ExecutePermissionMethodTypePointer : ClassRoleType, Meta.ExecutePermissionMethodTypePointer
    {
        public ExecutePermissionMethodTypePointer(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class ReadPermissionRelationTypePointer : ClassRoleType, Meta.ReadPermissionRelationTypePointer
    {
        public ReadPermissionRelationTypePointer(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class WritePermissionRelationTypePointer : ClassRoleType, Meta.WritePermissionRelationTypePointer
    {
        public WritePermissionRelationTypePointer(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class RevocationDeniedPermissions : ClassRoleType, Meta.RevocationDeniedPermissions
    {
        public RevocationDeniedPermissions(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.Permission ObjectType => ((M)this.M).Permission;
    }


    public class RolePermissions : ClassRoleType, Meta.RolePermissions
    {
        public RolePermissions(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.Permission ObjectType => ((M)this.M).Permission;
    }


    public class RoleName : ClassRoleType, Meta.RoleName
    {
        public RoleName(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class SecurityTokenGrants : ClassRoleType, Meta.SecurityTokenGrants
    {
        public SecurityTokenGrants(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.Grant ObjectType => ((M)this.M).Grant;
    }


    public class SecurityTokenSecurityStamp : ClassRoleType, Meta.SecurityTokenSecurityStamp
    {
        public SecurityTokenSecurityStamp(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class UserGroupMembers : ClassRoleType, Meta.UserGroupMembers
    {
        public UserGroupMembers(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.User ObjectType => ((M)this.M).User;
    }


    public class UserGroupName : ClassRoleType, Meta.UserGroupName
    {
        public UserGroupName(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }



    public class ObjectSecurityTokens : InterfaceRoleType, Meta.ObjectSecurityTokens
    {
        public ObjectSecurityTokens(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }

/*
    public class DispatchStatusSecurityTokens : ClassRoleType, Meta.DispatchStatusSecurityTokens
    {
        public DispatchStatusSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class EquipmentSecurityTokens : ClassRoleType, Meta.EquipmentSecurityTokens
    {
        public EquipmentSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class EquipmentActualSecurityTokens : ClassRoleType, Meta.EquipmentActualSecurityTokens
    {
        public EquipmentActualSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class EquipmentClassSecurityTokens : ClassRoleType, Meta.EquipmentClassSecurityTokens
    {
        public EquipmentClassSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class EquipmentClassPropertySecurityTokens : ClassRoleType, Meta.EquipmentClassPropertySecurityTokens
    {
        public EquipmentClassPropertySecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class EquipmentLevelSecurityTokens : ClassRoleType, Meta.EquipmentLevelSecurityTokens
    {
        public EquipmentLevelSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class EquipmentPropertySecurityTokens : ClassRoleType, Meta.EquipmentPropertySecurityTokens
    {
        public EquipmentPropertySecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class EquipmentRequirementSecurityTokens : ClassRoleType, Meta.EquipmentRequirementSecurityTokens
    {
        public EquipmentRequirementSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class HierarchyScopeSecurityTokens : ClassRoleType, Meta.HierarchyScopeSecurityTokens
    {
        public HierarchyScopeSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class JobOrderSecurityTokens : ClassRoleType, Meta.JobOrderSecurityTokens
    {
        public JobOrderSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class JobResponseSecurityTokens : ClassRoleType, Meta.JobResponseSecurityTokens
    {
        public JobResponseSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class MaterialActualSecurityTokens : ClassRoleType, Meta.MaterialActualSecurityTokens
    {
        public MaterialActualSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class MaterialRequirementSecurityTokens : ClassRoleType, Meta.MaterialRequirementSecurityTokens
    {
        public MaterialRequirementSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class OperationsDefinitionSecurityTokens : ClassRoleType, Meta.OperationsDefinitionSecurityTokens
    {
        public OperationsDefinitionSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class OperationsSegmentSecurityTokens : ClassRoleType, Meta.OperationsSegmentSecurityTokens
    {
        public OperationsSegmentSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class OperationsTypeSecurityTokens : ClassRoleType, Meta.OperationsTypeSecurityTokens
    {
        public OperationsTypeSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class PersonSecurityTokens : ClassRoleType, Meta.PersonSecurityTokens
    {
        public PersonSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class PersonnelActualSecurityTokens : ClassRoleType, Meta.PersonnelActualSecurityTokens
    {
        public PersonnelActualSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class PersonnelClassSecurityTokens : ClassRoleType, Meta.PersonnelClassSecurityTokens
    {
        public PersonnelClassSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class PersonnelClassPropertySecurityTokens : ClassRoleType, Meta.PersonnelClassPropertySecurityTokens
    {
        public PersonnelClassPropertySecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class PersonnelRequirementSecurityTokens : ClassRoleType, Meta.PersonnelRequirementSecurityTokens
    {
        public PersonnelRequirementSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class PersonPropertySecurityTokens : ClassRoleType, Meta.PersonPropertySecurityTokens
    {
        public PersonPropertySecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class PhysicalAssetSecurityTokens : ClassRoleType, Meta.PhysicalAssetSecurityTokens
    {
        public PhysicalAssetSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class PhysicalAssetPropertySecurityTokens : ClassRoleType, Meta.PhysicalAssetPropertySecurityTokens
    {
        public PhysicalAssetPropertySecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class WorkMasterSecurityTokens : ClassRoleType, Meta.WorkMasterSecurityTokens
    {
        public WorkMasterSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class GrantSecurityTokens : ClassRoleType, Meta.GrantSecurityTokens
    {
        public GrantSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class CreatePermissionSecurityTokens : ClassRoleType, Meta.CreatePermissionSecurityTokens
    {
        public CreatePermissionSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class ExecutePermissionSecurityTokens : ClassRoleType, Meta.ExecutePermissionSecurityTokens
    {
        public ExecutePermissionSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class ReadPermissionSecurityTokens : ClassRoleType, Meta.ReadPermissionSecurityTokens
    {
        public ReadPermissionSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class WritePermissionSecurityTokens : ClassRoleType, Meta.WritePermissionSecurityTokens
    {
        public WritePermissionSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class RevocationSecurityTokens : ClassRoleType, Meta.RevocationSecurityTokens
    {
        public RevocationSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class RoleSecurityTokens : ClassRoleType, Meta.RoleSecurityTokens
    {
        public RoleSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class SecurityTokenSecurityTokens : ClassRoleType, Meta.SecurityTokenSecurityTokens
    {
        public SecurityTokenSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/
/*
    public class UserGroupSecurityTokens : ClassRoleType, Meta.UserGroupSecurityTokens
    {
        public UserGroupSecurityTokens(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }
*/

    public class ObjectRevocations : InterfaceRoleType, Meta.ObjectRevocations
    {
        public ObjectRevocations(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }

/*
    public class DispatchStatusRevocations : ClassRoleType, Meta.DispatchStatusRevocations
    {
        public DispatchStatusRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class EquipmentRevocations : ClassRoleType, Meta.EquipmentRevocations
    {
        public EquipmentRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class EquipmentActualRevocations : ClassRoleType, Meta.EquipmentActualRevocations
    {
        public EquipmentActualRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class EquipmentClassRevocations : ClassRoleType, Meta.EquipmentClassRevocations
    {
        public EquipmentClassRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class EquipmentClassPropertyRevocations : ClassRoleType, Meta.EquipmentClassPropertyRevocations
    {
        public EquipmentClassPropertyRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class EquipmentLevelRevocations : ClassRoleType, Meta.EquipmentLevelRevocations
    {
        public EquipmentLevelRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class EquipmentPropertyRevocations : ClassRoleType, Meta.EquipmentPropertyRevocations
    {
        public EquipmentPropertyRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class EquipmentRequirementRevocations : ClassRoleType, Meta.EquipmentRequirementRevocations
    {
        public EquipmentRequirementRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class HierarchyScopeRevocations : ClassRoleType, Meta.HierarchyScopeRevocations
    {
        public HierarchyScopeRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class JobOrderRevocations : ClassRoleType, Meta.JobOrderRevocations
    {
        public JobOrderRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class JobResponseRevocations : ClassRoleType, Meta.JobResponseRevocations
    {
        public JobResponseRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class MaterialActualRevocations : ClassRoleType, Meta.MaterialActualRevocations
    {
        public MaterialActualRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class MaterialRequirementRevocations : ClassRoleType, Meta.MaterialRequirementRevocations
    {
        public MaterialRequirementRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class OperationsDefinitionRevocations : ClassRoleType, Meta.OperationsDefinitionRevocations
    {
        public OperationsDefinitionRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class OperationsSegmentRevocations : ClassRoleType, Meta.OperationsSegmentRevocations
    {
        public OperationsSegmentRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class OperationsTypeRevocations : ClassRoleType, Meta.OperationsTypeRevocations
    {
        public OperationsTypeRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class PersonRevocations : ClassRoleType, Meta.PersonRevocations
    {
        public PersonRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class PersonnelActualRevocations : ClassRoleType, Meta.PersonnelActualRevocations
    {
        public PersonnelActualRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class PersonnelClassRevocations : ClassRoleType, Meta.PersonnelClassRevocations
    {
        public PersonnelClassRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class PersonnelClassPropertyRevocations : ClassRoleType, Meta.PersonnelClassPropertyRevocations
    {
        public PersonnelClassPropertyRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class PersonnelRequirementRevocations : ClassRoleType, Meta.PersonnelRequirementRevocations
    {
        public PersonnelRequirementRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class PersonPropertyRevocations : ClassRoleType, Meta.PersonPropertyRevocations
    {
        public PersonPropertyRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class PhysicalAssetRevocations : ClassRoleType, Meta.PhysicalAssetRevocations
    {
        public PhysicalAssetRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class PhysicalAssetPropertyRevocations : ClassRoleType, Meta.PhysicalAssetPropertyRevocations
    {
        public PhysicalAssetPropertyRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class WorkMasterRevocations : ClassRoleType, Meta.WorkMasterRevocations
    {
        public WorkMasterRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class GrantRevocations : ClassRoleType, Meta.GrantRevocations
    {
        public GrantRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class CreatePermissionRevocations : ClassRoleType, Meta.CreatePermissionRevocations
    {
        public CreatePermissionRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class ExecutePermissionRevocations : ClassRoleType, Meta.ExecutePermissionRevocations
    {
        public ExecutePermissionRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class ReadPermissionRevocations : ClassRoleType, Meta.ReadPermissionRevocations
    {
        public ReadPermissionRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class WritePermissionRevocations : ClassRoleType, Meta.WritePermissionRevocations
    {
        public WritePermissionRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class RevocationRevocations : ClassRoleType, Meta.RevocationRevocations
    {
        public RevocationRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class RoleRevocations : ClassRoleType, Meta.RoleRevocations
    {
        public RoleRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class SecurityTokenRevocations : ClassRoleType, Meta.SecurityTokenRevocations
    {
        public SecurityTokenRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/
/*
    public class UserGroupRevocations : ClassRoleType, Meta.UserGroupRevocations
    {
        public UserGroupRevocations(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
        public Meta.Revocation ObjectType => ((M)this.M).Revocation;
    }
*/

    public class UniquelyIdentifiableUniqueId : InterfaceRoleType, Meta.UniquelyIdentifiableUniqueId
    {
        public UniquelyIdentifiableUniqueId(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }

/*
    public class DispatchStatusUniqueId : ClassRoleType, Meta.DispatchStatusUniqueId
    {
        public DispatchStatusUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class EquipmentUniqueId : ClassRoleType, Meta.EquipmentUniqueId
    {
        public EquipmentUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class EquipmentActualUniqueId : ClassRoleType, Meta.EquipmentActualUniqueId
    {
        public EquipmentActualUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class EquipmentClassUniqueId : ClassRoleType, Meta.EquipmentClassUniqueId
    {
        public EquipmentClassUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class EquipmentClassPropertyUniqueId : ClassRoleType, Meta.EquipmentClassPropertyUniqueId
    {
        public EquipmentClassPropertyUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class EquipmentLevelUniqueId : ClassRoleType, Meta.EquipmentLevelUniqueId
    {
        public EquipmentLevelUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class EquipmentPropertyUniqueId : ClassRoleType, Meta.EquipmentPropertyUniqueId
    {
        public EquipmentPropertyUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class EquipmentRequirementUniqueId : ClassRoleType, Meta.EquipmentRequirementUniqueId
    {
        public EquipmentRequirementUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class HierarchyScopeUniqueId : ClassRoleType, Meta.HierarchyScopeUniqueId
    {
        public HierarchyScopeUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class JobOrderUniqueId : ClassRoleType, Meta.JobOrderUniqueId
    {
        public JobOrderUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class JobResponseUniqueId : ClassRoleType, Meta.JobResponseUniqueId
    {
        public JobResponseUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class MaterialActualUniqueId : ClassRoleType, Meta.MaterialActualUniqueId
    {
        public MaterialActualUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class MaterialRequirementUniqueId : ClassRoleType, Meta.MaterialRequirementUniqueId
    {
        public MaterialRequirementUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class OperationsDefinitionUniqueId : ClassRoleType, Meta.OperationsDefinitionUniqueId
    {
        public OperationsDefinitionUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class OperationsSegmentUniqueId : ClassRoleType, Meta.OperationsSegmentUniqueId
    {
        public OperationsSegmentUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class OperationsTypeUniqueId : ClassRoleType, Meta.OperationsTypeUniqueId
    {
        public OperationsTypeUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class PersonUniqueId : ClassRoleType, Meta.PersonUniqueId
    {
        public PersonUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class PersonnelActualUniqueId : ClassRoleType, Meta.PersonnelActualUniqueId
    {
        public PersonnelActualUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class PersonnelClassUniqueId : ClassRoleType, Meta.PersonnelClassUniqueId
    {
        public PersonnelClassUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class PersonnelClassPropertyUniqueId : ClassRoleType, Meta.PersonnelClassPropertyUniqueId
    {
        public PersonnelClassPropertyUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class PersonnelRequirementUniqueId : ClassRoleType, Meta.PersonnelRequirementUniqueId
    {
        public PersonnelRequirementUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class PersonPropertyUniqueId : ClassRoleType, Meta.PersonPropertyUniqueId
    {
        public PersonPropertyUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class PhysicalAssetUniqueId : ClassRoleType, Meta.PhysicalAssetUniqueId
    {
        public PhysicalAssetUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class PhysicalAssetPropertyUniqueId : ClassRoleType, Meta.PhysicalAssetPropertyUniqueId
    {
        public PhysicalAssetPropertyUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class WorkMasterUniqueId : ClassRoleType, Meta.WorkMasterUniqueId
    {
        public WorkMasterUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class GrantUniqueId : ClassRoleType, Meta.GrantUniqueId
    {
        public GrantUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class RevocationUniqueId : ClassRoleType, Meta.RevocationUniqueId
    {
        public RevocationUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class RoleUniqueId : ClassRoleType, Meta.RoleUniqueId
    {
        public RoleUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class SecurityTokenUniqueId : ClassRoleType, Meta.SecurityTokenUniqueId
    {
        public SecurityTokenUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class UserGroupUniqueId : ClassRoleType, Meta.UserGroupUniqueId
    {
        public UserGroupUniqueId(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/

    public class DelegatedAccessObjectDelegatedAccess : InterfaceRoleType, Meta.DelegatedAccessObjectDelegatedAccess
    {
        public DelegatedAccessObjectDelegatedAccess(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.Object ObjectType => ((M)this.M).Object;
    }


    public class PermissionClassPointer : InterfaceRoleType, Meta.PermissionClassPointer
    {
        public PermissionClassPointer(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }

/*
    public class CreatePermissionClassPointer : ClassRoleType, Meta.CreatePermissionClassPointer
    {
        public CreatePermissionClassPointer(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class ExecutePermissionClassPointer : ClassRoleType, Meta.ExecutePermissionClassPointer
    {
        public ExecutePermissionClassPointer(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class ReadPermissionClassPointer : ClassRoleType, Meta.ReadPermissionClassPointer
    {
        public ReadPermissionClassPointer(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/
/*
    public class WritePermissionClassPointer : ClassRoleType, Meta.WritePermissionClassPointer
    {
        public WritePermissionClassPointer(InterfaceRoleType interfaceRoleType) : base(interfaceRoleType)
        {
        }
    }
*/

    public class SecurityTokenOwnerOwnerSecurityToken : InterfaceRoleType, Meta.SecurityTokenOwnerOwnerSecurityToken
    {
        public SecurityTokenOwnerOwnerSecurityToken(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.SecurityToken ObjectType => ((M)this.M).SecurityToken;
    }


    public class SecurityTokenOwnerOwnerGrant : InterfaceRoleType, Meta.SecurityTokenOwnerOwnerGrant
    {
        public SecurityTokenOwnerOwnerGrant(IRelationTypeBase relationType) : base(relationType)
        {
        }
        public Meta.Grant ObjectType => ((M)this.M).Grant;
    }


    public class UserUserName : InterfaceRoleType, Meta.UserUserName
    {
        public UserUserName(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


    public class UserNormalizedUserName : InterfaceRoleType, Meta.UserNormalizedUserName
    {
        public UserNormalizedUserName(IRelationTypeBase relationType) : base(relationType)
        {
        }
    }


}