namespace Allors.Database.Meta
{
/*
// RelationTypes & MethodTypes
        // DispatchStatus;
AddWorkspace(relationTypes.DispatchStatusName, new[] {"Default"});
AddWorkspace(relationTypes.DispatchStatusIsActive, new[] {"Default"});

        // Equipment;
AddWorkspace(relationTypes.EquipmentName, new[] {"Default"});
AddWorkspace(relationTypes.EquipmentDescription, new[] {"Default"});
AddWorkspace(relationTypes.EquipmentEquipmentLevel, new[] {"Default"});
AddWorkspace(relationTypes.EquipmentEquipmentClasses, new[] {"Default"});
AddWorkspace(relationTypes.EquipmentEquipmentProperties, new[] {"Default"});
AddWorkspace(relationTypes.EquipmentEquipmentChildren, new[] {"Default"});
AddWorkspace(relationTypes.EquipmentEquipmentParent, new[] {"Default"});
AddWorkspace(relationTypes.EquipmentPhysicalAsset, new[] {"Default"});
AddWorkspace(relationTypes.EquipmentHierarchyScope, new[] {"Default"});
AddWorkspace(relationTypes.EquipmentDisplayName, new[] {"Default"});

        // EquipmentActual;
AddWorkspace(relationTypes.EquipmentActualEquipment, new[] {"Default"});
AddWorkspace(relationTypes.EquipmentActualEquipmentClass, new[] {"Default"});
AddWorkspace(relationTypes.EquipmentActualDescription, new[] {"Default"});

        // EquipmentClass;
AddWorkspace(relationTypes.EquipmentClassName, new[] {"Default"});
AddWorkspace(relationTypes.EquipmentClassDescription, new[] {"Default"});
AddWorkspace(relationTypes.EquipmentClassEquipmentLevel, new[] {"Default"});
AddWorkspace(relationTypes.EquipmentClassEquipmentClassProperties, new[] {"Default"});
AddWorkspace(relationTypes.EquipmentClassEquipmentClassChildren, new[] {"Default"});
AddWorkspace(relationTypes.EquipmentClassEquipmentClassParent, new[] {"Default"});

        // EquipmentClassProperty;
AddWorkspace(relationTypes.EquipmentClassPropertyName, new[] {"Default"});
AddWorkspace(relationTypes.EquipmentClassPropertyDescription, new[] {"Default"});
AddWorkspace(relationTypes.EquipmentClassPropertyDefaultValue, new[] {"Default"});
AddWorkspace(relationTypes.EquipmentClassPropertyPropertyType, new[] {"Default"});
AddWorkspace(relationTypes.EquipmentClassPropertyEquipmentClassPropertyChildren, new[] {"Default"});

        // EquipmentLevel;
AddWorkspace(relationTypes.EquipmentLevelName, new[] {"Default"});
AddWorkspace(relationTypes.EquipmentLevelIsActive, new[] {"Default"});

        // EquipmentProperty;
AddWorkspace(relationTypes.EquipmentPropertyName, new[] {"Default"});
AddWorkspace(relationTypes.EquipmentPropertyDescription, new[] {"Default"});
AddWorkspace(relationTypes.EquipmentPropertyValue, new[] {"Default"});
AddWorkspace(relationTypes.EquipmentPropertyEquipmentClassProperty, new[] {"Default"});
AddWorkspace(relationTypes.EquipmentPropertyEquipmentPropertyChildren, new[] {"Default"});

        // EquipmentRequirement;
AddWorkspace(relationTypes.EquipmentRequirementEquipmentClass, new[] {"Default"});
AddWorkspace(relationTypes.EquipmentRequirementEquipment, new[] {"Default"});
AddWorkspace(relationTypes.EquipmentRequirementQuantity, new[] {"Default"});
AddWorkspace(relationTypes.EquipmentRequirementDescription, new[] {"Default"});

        // HierarchyScope;
AddWorkspace(relationTypes.HierarchyScopeScopedEquipment, new[] {"Default"});
AddWorkspace(relationTypes.HierarchyScopeEquipmentLevel, new[] {"Default"});

        // JobOrder;
AddWorkspace(relationTypes.JobOrderName, new[] {"Default"});
AddWorkspace(relationTypes.JobOrderDescription, new[] {"Default"});
AddWorkspace(relationTypes.JobOrderWorkType, new[] {"Default"});
AddWorkspace(relationTypes.JobOrderWorkMaster, new[] {"Default"});
AddWorkspace(relationTypes.JobOrderEquipment, new[] {"Default"});
AddWorkspace(relationTypes.JobOrderPriority, new[] {"Default"});
AddWorkspace(relationTypes.JobOrderDispatchStatus, new[] {"Default"});
AddWorkspace(relationTypes.JobOrderStartTime, new[] {"Default"});
AddWorkspace(relationTypes.JobOrderEndTime, new[] {"Default"});
AddWorkspace(relationTypes.JobOrderHierarchyScope, new[] {"Default"});
AddWorkspace(relationTypes.JobOrderPersonnelRequirements, new[] {"Default"});
AddWorkspace(relationTypes.JobOrderEquipmentRequirements, new[] {"Default"});
AddWorkspace(relationTypes.JobOrderMaterialRequirements, new[] {"Default"});
AddWorkspace(relationTypes.JobOrderAssignedTo, new[] {"Default"});
AddWorkspace(relationTypes.JobOrderResponse, new[] {"Default"});

        // JobResponse;
AddWorkspace(relationTypes.JobResponseDescription, new[] {"Default"});
AddWorkspace(relationTypes.JobResponseWorkType, new[] {"Default"});
AddWorkspace(relationTypes.JobResponseJobOrder, new[] {"Default"});
AddWorkspace(relationTypes.JobResponseStartTime, new[] {"Default"});
AddWorkspace(relationTypes.JobResponseEndTime, new[] {"Default"});
AddWorkspace(relationTypes.JobResponseJobState, new[] {"Default"});
AddWorkspace(relationTypes.JobResponsePersonnelActuals, new[] {"Default"});
AddWorkspace(relationTypes.JobResponseEquipmentActuals, new[] {"Default"});
AddWorkspace(relationTypes.JobResponseMaterialActuals, new[] {"Default"});

        // MaterialActual;
AddWorkspace(relationTypes.MaterialActualName, new[] {"Default"});
AddWorkspace(relationTypes.MaterialActualQuantity, new[] {"Default"});
AddWorkspace(relationTypes.MaterialActualDescription, new[] {"Default"});

        // MaterialRequirement;
AddWorkspace(relationTypes.MaterialRequirementName, new[] {"Default"});
AddWorkspace(relationTypes.MaterialRequirementQuantity, new[] {"Default"});
AddWorkspace(relationTypes.MaterialRequirementDescription, new[] {"Default"});

        // OperationsDefinition;
AddWorkspace(relationTypes.OperationsDefinitionName, new[] {"Default"});
AddWorkspace(relationTypes.OperationsDefinitionDescription, new[] {"Default"});
AddWorkspace(relationTypes.OperationsDefinitionVersion, new[] {"Default"});
AddWorkspace(relationTypes.OperationsDefinitionOperationsType, new[] {"Default"});
AddWorkspace(relationTypes.OperationsDefinitionOperationsSegments, new[] {"Default"});
AddWorkspace(relationTypes.OperationsDefinitionEffectiveStartDate, new[] {"Default"});
AddWorkspace(relationTypes.OperationsDefinitionEffectiveEndDate, new[] {"Default"});
AddWorkspace(relationTypes.OperationsDefinitionHierarchyScope, new[] {"Default"});

        // OperationsSegment;
AddWorkspace(relationTypes.OperationsSegmentName, new[] {"Default"});
AddWorkspace(relationTypes.OperationsSegmentDescription, new[] {"Default"});
AddWorkspace(relationTypes.OperationsSegmentDuration, new[] {"Default"});
AddWorkspace(relationTypes.OperationsSegmentOperationsType, new[] {"Default"});
AddWorkspace(relationTypes.OperationsSegmentPersonnelSpecifications, new[] {"Default"});
AddWorkspace(relationTypes.OperationsSegmentEquipmentSpecifications, new[] {"Default"});
AddWorkspace(relationTypes.OperationsSegmentMaterialSpecifications, new[] {"Default"});
AddWorkspace(relationTypes.OperationsSegmentOperationsSegmentChildren, new[] {"Default"});
AddWorkspace(relationTypes.OperationsSegmentOperationsSegmentParent, new[] {"Default"});

        // OperationsType;
AddWorkspace(relationTypes.OperationsTypeName, new[] {"Default"});
AddWorkspace(relationTypes.OperationsTypeIsActive, new[] {"Default"});

        // Person;
AddWorkspace(relationTypes.PersonFirstName, new[] {"Default"});
AddWorkspace(relationTypes.PersonLastName, new[] {"Default"});
AddWorkspace(relationTypes.PersonUser, new[] {"Default"});
AddWorkspace(relationTypes.PersonPersonnelClasses, new[] {"Default"});
AddWorkspace(relationTypes.PersonPersonProperties, new[] {"Default"});
AddWorkspace(relationTypes.PersonDisplayName, new[] {"Default"});

        // PersonnelActual;
AddWorkspace(relationTypes.PersonnelActualPerson, new[] {"Default"});
AddWorkspace(relationTypes.PersonnelActualPersonnelClass, new[] {"Default"});
AddWorkspace(relationTypes.PersonnelActualDescription, new[] {"Default"});

        // PersonnelClass;
AddWorkspace(relationTypes.PersonnelClassName, new[] {"Default"});
AddWorkspace(relationTypes.PersonnelClassDescription, new[] {"Default"});
AddWorkspace(relationTypes.PersonnelClassPersonnelClassProperties, new[] {"Default"});
AddWorkspace(relationTypes.PersonnelClassPersonnelClassParent, new[] {"Default"});

        // PersonnelClassProperty;
AddWorkspace(relationTypes.PersonnelClassPropertyName, new[] {"Default"});
AddWorkspace(relationTypes.PersonnelClassPropertyDescription, new[] {"Default"});
AddWorkspace(relationTypes.PersonnelClassPropertyDefaultValue, new[] {"Default"});

        // PersonnelRequirement;
AddWorkspace(relationTypes.PersonnelRequirementPersonnelClass, new[] {"Default"});
AddWorkspace(relationTypes.PersonnelRequirementPerson, new[] {"Default"});
AddWorkspace(relationTypes.PersonnelRequirementQuantity, new[] {"Default"});
AddWorkspace(relationTypes.PersonnelRequirementDescription, new[] {"Default"});

        // PersonProperty;
AddWorkspace(relationTypes.PersonPropertyName, new[] {"Default"});
AddWorkspace(relationTypes.PersonPropertyValue, new[] {"Default"});
AddWorkspace(relationTypes.PersonPropertyPersonnelClassProperty, new[] {"Default"});

        // PhysicalAsset;
AddWorkspace(relationTypes.PhysicalAssetName, new[] {"Default"});
AddWorkspace(relationTypes.PhysicalAssetDescription, new[] {"Default"});
AddWorkspace(relationTypes.PhysicalAssetSerialNumber, new[] {"Default"});
AddWorkspace(relationTypes.PhysicalAssetManufacturer, new[] {"Default"});
AddWorkspace(relationTypes.PhysicalAssetModelNumber, new[] {"Default"});
AddWorkspace(relationTypes.PhysicalAssetInstallationDate, new[] {"Default"});
AddWorkspace(relationTypes.PhysicalAssetPhysicalAssetProperties, new[] {"Default"});
AddWorkspace(relationTypes.PhysicalAssetPhysicalAssetChildren, new[] {"Default"});

        // PhysicalAssetProperty;
AddWorkspace(relationTypes.PhysicalAssetPropertyName, new[] {"Default"});
AddWorkspace(relationTypes.PhysicalAssetPropertyValue, new[] {"Default"});

        // WorkMaster;
AddWorkspace(relationTypes.WorkMasterName, new[] {"Default"});
AddWorkspace(relationTypes.WorkMasterDescription, new[] {"Default"});
AddWorkspace(relationTypes.WorkMasterVersion, new[] {"Default"});
AddWorkspace(relationTypes.WorkMasterWorkType, new[] {"Default"});
AddWorkspace(relationTypes.WorkMasterDuration, new[] {"Default"});
AddWorkspace(relationTypes.WorkMasterOperationsDefinition, new[] {"Default"});
AddWorkspace(relationTypes.WorkMasterPersonnelSpecifications, new[] {"Default"});
AddWorkspace(relationTypes.WorkMasterEquipmentSpecifications, new[] {"Default"});
AddWorkspace(relationTypes.WorkMasterMaterialSpecifications, new[] {"Default"});
AddWorkspace(relationTypes.WorkMasterWorkMasterChildren, new[] {"Default"});

        // Grant;

        // CreatePermission;

        // ExecutePermission;

        // ReadPermission;

        // WritePermission;

        // Revocation;

        // Role;

        // SecurityToken;

        // UserGroup;
AddWorkspace(relationTypes.UserGroupMembers, new[] {"Default"});
AddWorkspace(relationTypes.UserGroupName, new[] {"Default"});

        // Deletable;
AddWorkspace(methodTypes.DeletableDelete, new[] {"Default"});

        // Object;

        // UniquelyIdentifiable;
AddWorkspace(relationTypes.UniquelyIdentifiableUniqueId, new[] {"Default"});

        // DelegatedAccessObject;

        // Permission;

        // SecurityTokenOwner;

        // User;
AddWorkspace(relationTypes.UserUserName, new[] {"Default"});



// Classes

*/
}