namespace Allors.Database.Meta
{
    public partial interface DispatchStatus : IClass {

        M M { get; }

                DispatchStatusName Name { get; }
                DispatchStatusIsActive IsActive { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }


                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                JobOrdersWhereDispatchStatus JobOrdersWhereDispatchStatus { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
    }
    public partial interface Equipment : IClass {

        M M { get; }

                EquipmentName Name { get; }
                EquipmentDescription Description { get; }
                EquipmentEquipmentLevel EquipmentLevel { get; }
                EquipmentEquipmentClasses EquipmentClasses { get; }
                EquipmentEquipmentProperties EquipmentProperties { get; }
                EquipmentEquipmentChildren EquipmentChildren { get; }
                EquipmentEquipmentParent EquipmentParent { get; }
                EquipmentPhysicalAsset PhysicalAsset { get; }
                EquipmentHierarchyScope HierarchyScope { get; }
                EquipmentDisplayName DisplayName { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }


                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                EquipmentWhereEquipmentChild EquipmentWhereEquipmentChild { get; }
                EquipmentsWhereEquipmentParent EquipmentsWhereEquipmentParent { get; }
                EquipmentActualsWhereEquipment EquipmentActualsWhereEquipment { get; }
                EquipmentRequirementsWhereEquipment EquipmentRequirementsWhereEquipment { get; }
                HierarchyScopesWhereScopedEquipment HierarchyScopesWhereScopedEquipment { get; }
                JobOrdersWhereEquipment JobOrdersWhereEquipment { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
                IMethodType Delete { get; }
    }
    public partial interface EquipmentActual : IClass {

        M M { get; }

                EquipmentActualEquipment Equipment { get; }
                EquipmentActualEquipmentClass EquipmentClass { get; }
                EquipmentActualDescription Description { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }


                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                JobResponseWhereEquipmentActual JobResponseWhereEquipmentActual { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
                IMethodType Delete { get; }
    }
    public partial interface EquipmentClass : IClass {

        M M { get; }

                EquipmentClassName Name { get; }
                EquipmentClassDescription Description { get; }
                EquipmentClassEquipmentLevel EquipmentLevel { get; }
                EquipmentClassEquipmentClassProperties EquipmentClassProperties { get; }
                EquipmentClassEquipmentClassChildren EquipmentClassChildren { get; }
                EquipmentClassEquipmentClassParent EquipmentClassParent { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }


                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                EquipmentsWhereEquipmentClass EquipmentsWhereEquipmentClass { get; }
                EquipmentActualsWhereEquipmentClass EquipmentActualsWhereEquipmentClass { get; }
                EquipmentClassWhereEquipmentClassChild EquipmentClassWhereEquipmentClassChild { get; }
                EquipmentClassesWhereEquipmentClassParent EquipmentClassesWhereEquipmentClassParent { get; }
                EquipmentRequirementsWhereEquipmentClass EquipmentRequirementsWhereEquipmentClass { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
                IMethodType Delete { get; }
    }
    public partial interface EquipmentClassProperty : IClass {

        M M { get; }

                EquipmentClassPropertyName Name { get; }
                EquipmentClassPropertyDescription Description { get; }
                EquipmentClassPropertyDefaultValue DefaultValue { get; }
                EquipmentClassPropertyPropertyType PropertyType { get; }
                EquipmentClassPropertyEquipmentClassPropertyChildren EquipmentClassPropertyChildren { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }


                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                EquipmentClassWhereEquipmentClassProperty EquipmentClassWhereEquipmentClassProperty { get; }
                EquipmentClassPropertyWhereEquipmentClassPropertyChild EquipmentClassPropertyWhereEquipmentClassPropertyChild { get; }
                EquipmentPropertiesWhereEquipmentClassProperty EquipmentPropertiesWhereEquipmentClassProperty { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
                IMethodType Delete { get; }
    }
    public partial interface EquipmentLevel : IClass {

        M M { get; }

                EquipmentLevelName Name { get; }
                EquipmentLevelIsActive IsActive { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }


                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                EquipmentsWhereEquipmentLevel EquipmentsWhereEquipmentLevel { get; }
                EquipmentClassesWhereEquipmentLevel EquipmentClassesWhereEquipmentLevel { get; }
                HierarchyScopesWhereEquipmentLevel HierarchyScopesWhereEquipmentLevel { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
    }
    public partial interface EquipmentProperty : IClass {

        M M { get; }

                EquipmentPropertyName Name { get; }
                EquipmentPropertyDescription Description { get; }
                EquipmentPropertyValue Value { get; }
                EquipmentPropertyEquipmentClassProperty EquipmentClassProperty { get; }
                EquipmentPropertyEquipmentPropertyChildren EquipmentPropertyChildren { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }


                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                EquipmentWhereEquipmentProperty EquipmentWhereEquipmentProperty { get; }
                EquipmentPropertyWhereEquipmentPropertyChild EquipmentPropertyWhereEquipmentPropertyChild { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
                IMethodType Delete { get; }
    }
    public partial interface EquipmentRequirement : IClass {

        M M { get; }

                EquipmentRequirementEquipmentClass EquipmentClass { get; }
                EquipmentRequirementEquipment Equipment { get; }
                EquipmentRequirementQuantity Quantity { get; }
                EquipmentRequirementDescription Description { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }


                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                JobOrderWhereEquipmentRequirement JobOrderWhereEquipmentRequirement { get; }
                OperationsSegmentWhereEquipmentSpecification OperationsSegmentWhereEquipmentSpecification { get; }
                WorkMasterWhereEquipmentSpecification WorkMasterWhereEquipmentSpecification { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
                IMethodType Delete { get; }
    }
    public partial interface HierarchyScope : IClass {

        M M { get; }

                HierarchyScopeScopedEquipment ScopedEquipment { get; }
                HierarchyScopeEquipmentLevel EquipmentLevel { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }


                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                EquipmentsWhereHierarchyScope EquipmentsWhereHierarchyScope { get; }
                JobOrdersWhereHierarchyScope JobOrdersWhereHierarchyScope { get; }
                OperationsDefinitionsWhereHierarchyScope OperationsDefinitionsWhereHierarchyScope { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
                IMethodType Delete { get; }
    }
    public partial interface JobOrder : IClass {

        M M { get; }

                JobOrderName Name { get; }
                JobOrderDescription Description { get; }
                JobOrderWorkType WorkType { get; }
                JobOrderWorkMaster WorkMaster { get; }
                JobOrderEquipment Equipment { get; }
                JobOrderPriority Priority { get; }
                JobOrderDispatchStatus DispatchStatus { get; }
                JobOrderStartTime StartTime { get; }
                JobOrderEndTime EndTime { get; }
                JobOrderHierarchyScope HierarchyScope { get; }
                JobOrderPersonnelRequirements PersonnelRequirements { get; }
                JobOrderEquipmentRequirements EquipmentRequirements { get; }
                JobOrderMaterialRequirements MaterialRequirements { get; }
                JobOrderAssignedTo AssignedTo { get; }
                JobOrderResponse Response { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }


                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                JobResponsesWhereJobOrder JobResponsesWhereJobOrder { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
                IMethodType Delete { get; }
    }
    public partial interface JobResponse : IClass {

        M M { get; }

                JobResponseDescription Description { get; }
                JobResponseWorkType WorkType { get; }
                JobResponseJobOrder JobOrder { get; }
                JobResponseStartTime StartTime { get; }
                JobResponseEndTime EndTime { get; }
                JobResponseJobState JobState { get; }
                JobResponsePersonnelActuals PersonnelActuals { get; }
                JobResponseEquipmentActuals EquipmentActuals { get; }
                JobResponseMaterialActuals MaterialActuals { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }


                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                JobOrderWhereResponse JobOrderWhereResponse { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
                IMethodType Delete { get; }
    }
    public partial interface MaterialActual : IClass {

        M M { get; }

                MaterialActualName Name { get; }
                MaterialActualQuantity Quantity { get; }
                MaterialActualDescription Description { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }


                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                JobResponseWhereMaterialActual JobResponseWhereMaterialActual { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
                IMethodType Delete { get; }
    }
    public partial interface MaterialRequirement : IClass {

        M M { get; }

                MaterialRequirementName Name { get; }
                MaterialRequirementQuantity Quantity { get; }
                MaterialRequirementDescription Description { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }


                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                JobOrderWhereMaterialRequirement JobOrderWhereMaterialRequirement { get; }
                OperationsSegmentWhereMaterialSpecification OperationsSegmentWhereMaterialSpecification { get; }
                WorkMasterWhereMaterialSpecification WorkMasterWhereMaterialSpecification { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
                IMethodType Delete { get; }
    }
    public partial interface OperationsDefinition : IClass {

        M M { get; }

                OperationsDefinitionName Name { get; }
                OperationsDefinitionDescription Description { get; }
                OperationsDefinitionVersion Version { get; }
                OperationsDefinitionOperationsType OperationsType { get; }
                OperationsDefinitionOperationsSegments OperationsSegments { get; }
                OperationsDefinitionEffectiveStartDate EffectiveStartDate { get; }
                OperationsDefinitionEffectiveEndDate EffectiveEndDate { get; }
                OperationsDefinitionHierarchyScope HierarchyScope { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }


                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                WorkMastersWhereOperationsDefinition WorkMastersWhereOperationsDefinition { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
                IMethodType Delete { get; }
    }
    public partial interface OperationsSegment : IClass {

        M M { get; }

                OperationsSegmentName Name { get; }
                OperationsSegmentDescription Description { get; }
                OperationsSegmentDuration Duration { get; }
                OperationsSegmentOperationsType OperationsType { get; }
                OperationsSegmentPersonnelSpecifications PersonnelSpecifications { get; }
                OperationsSegmentEquipmentSpecifications EquipmentSpecifications { get; }
                OperationsSegmentMaterialSpecifications MaterialSpecifications { get; }
                OperationsSegmentOperationsSegmentChildren OperationsSegmentChildren { get; }
                OperationsSegmentOperationsSegmentParent OperationsSegmentParent { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }


                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                OperationsDefinitionWhereOperationsSegment OperationsDefinitionWhereOperationsSegment { get; }
                OperationsSegmentWhereOperationsSegmentChild OperationsSegmentWhereOperationsSegmentChild { get; }
                OperationsSegmentsWhereOperationsSegmentParent OperationsSegmentsWhereOperationsSegmentParent { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
                IMethodType Delete { get; }
    }
    public partial interface OperationsType : IClass {

        M M { get; }

                OperationsTypeName Name { get; }
                OperationsTypeIsActive IsActive { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }


                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                JobOrdersWhereWorkType JobOrdersWhereWorkType { get; }
                JobResponsesWhereWorkType JobResponsesWhereWorkType { get; }
                OperationsDefinitionsWhereOperationsType OperationsDefinitionsWhereOperationsType { get; }
                OperationsSegmentsWhereOperationsType OperationsSegmentsWhereOperationsType { get; }
                WorkMastersWhereWorkType WorkMastersWhereWorkType { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
    }
    public partial interface Person : IClass {

        M M { get; }

                PersonFirstName FirstName { get; }
                PersonLastName LastName { get; }
                PersonUser User { get; }
                PersonPersonnelClasses PersonnelClasses { get; }
                PersonPersonProperties PersonProperties { get; }
                PersonDisplayName DisplayName { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }


                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                JobOrdersWhereAssignedTo JobOrdersWhereAssignedTo { get; }
                PersonnelActualsWherePerson PersonnelActualsWherePerson { get; }
                PersonnelRequirementsWherePerson PersonnelRequirementsWherePerson { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
                IMethodType Delete { get; }
    }
    public partial interface PersonnelActual : IClass {

        M M { get; }

                PersonnelActualPerson Person { get; }
                PersonnelActualPersonnelClass PersonnelClass { get; }
                PersonnelActualDescription Description { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }


                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                JobResponseWherePersonnelActual JobResponseWherePersonnelActual { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
                IMethodType Delete { get; }
    }
    public partial interface PersonnelClass : IClass {

        M M { get; }

                PersonnelClassName Name { get; }
                PersonnelClassDescription Description { get; }
                PersonnelClassPersonnelClassProperties PersonnelClassProperties { get; }
                PersonnelClassPersonnelClassParent PersonnelClassParent { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }


                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                PeopleWherePersonnelClass PeopleWherePersonnelClass { get; }
                PersonnelActualsWherePersonnelClass PersonnelActualsWherePersonnelClass { get; }
                PersonnelClassesWherePersonnelClassParent PersonnelClassesWherePersonnelClassParent { get; }
                PersonnelRequirementsWherePersonnelClass PersonnelRequirementsWherePersonnelClass { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
                IMethodType Delete { get; }
    }
    public partial interface PersonnelClassProperty : IClass {

        M M { get; }

                PersonnelClassPropertyName Name { get; }
                PersonnelClassPropertyDescription Description { get; }
                PersonnelClassPropertyDefaultValue DefaultValue { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }


                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                PersonnelClassWherePersonnelClassProperty PersonnelClassWherePersonnelClassProperty { get; }
                PersonPropertiesWherePersonnelClassProperty PersonPropertiesWherePersonnelClassProperty { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
                IMethodType Delete { get; }
    }
    public partial interface PersonnelRequirement : IClass {

        M M { get; }

                PersonnelRequirementPersonnelClass PersonnelClass { get; }
                PersonnelRequirementPerson Person { get; }
                PersonnelRequirementQuantity Quantity { get; }
                PersonnelRequirementDescription Description { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }


                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                JobOrderWherePersonnelRequirement JobOrderWherePersonnelRequirement { get; }
                OperationsSegmentWherePersonnelSpecification OperationsSegmentWherePersonnelSpecification { get; }
                WorkMasterWherePersonnelSpecification WorkMasterWherePersonnelSpecification { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
                IMethodType Delete { get; }
    }
    public partial interface PersonProperty : IClass {

        M M { get; }

                PersonPropertyName Name { get; }
                PersonPropertyValue Value { get; }
                PersonPropertyPersonnelClassProperty PersonnelClassProperty { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }


                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                PersonWherePersonProperty PersonWherePersonProperty { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
                IMethodType Delete { get; }
    }
    public partial interface PhysicalAsset : IClass {

        M M { get; }

                PhysicalAssetName Name { get; }
                PhysicalAssetDescription Description { get; }
                PhysicalAssetSerialNumber SerialNumber { get; }
                PhysicalAssetManufacturer Manufacturer { get; }
                PhysicalAssetModelNumber ModelNumber { get; }
                PhysicalAssetInstallationDate InstallationDate { get; }
                PhysicalAssetPhysicalAssetProperties PhysicalAssetProperties { get; }
                PhysicalAssetPhysicalAssetChildren PhysicalAssetChildren { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }


                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                EquipmentsWherePhysicalAsset EquipmentsWherePhysicalAsset { get; }
                PhysicalAssetWherePhysicalAssetChild PhysicalAssetWherePhysicalAssetChild { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
                IMethodType Delete { get; }
    }
    public partial interface PhysicalAssetProperty : IClass {

        M M { get; }

                PhysicalAssetPropertyName Name { get; }
                PhysicalAssetPropertyValue Value { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }


                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                PhysicalAssetWherePhysicalAssetProperty PhysicalAssetWherePhysicalAssetProperty { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
                IMethodType Delete { get; }
    }
    public partial interface WorkMaster : IClass {

        M M { get; }

                WorkMasterName Name { get; }
                WorkMasterDescription Description { get; }
                WorkMasterVersion Version { get; }
                WorkMasterWorkType WorkType { get; }
                WorkMasterDuration Duration { get; }
                WorkMasterOperationsDefinition OperationsDefinition { get; }
                WorkMasterPersonnelSpecifications PersonnelSpecifications { get; }
                WorkMasterEquipmentSpecifications EquipmentSpecifications { get; }
                WorkMasterMaterialSpecifications MaterialSpecifications { get; }
                WorkMasterWorkMasterChildren WorkMasterChildren { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }


                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                JobOrdersWhereWorkMaster JobOrdersWhereWorkMaster { get; }
                WorkMasterWhereWorkMasterChild WorkMasterWhereWorkMasterChild { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
                IMethodType Delete { get; }
    }
    public partial interface Grant : IClass {

        M M { get; }

                GrantSubjectGroups SubjectGroups { get; }
                GrantSubjects Subjects { get; }
                GrantRole Role { get; }
                GrantEffectivePermissions EffectivePermissions { get; }
                GrantEffectiveUsers EffectiveUsers { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }


                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                SecurityTokensWhereGrant SecurityTokensWhereGrant { get; }
                SecurityTokenOwnerWhereOwnerGrant SecurityTokenOwnerWhereOwnerGrant { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
                IMethodType Delete { get; }
    }
    public partial interface CreatePermission : IClass {

        M M { get; }


                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                PermissionClassPointer ClassPointer { get; }



                GrantsWhereEffectivePermission GrantsWhereEffectivePermission { get; }
                RevocationsWhereDeniedPermission RevocationsWhereDeniedPermission { get; }
                RolesWherePermission RolesWherePermission { get; }
                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
                IMethodType Delete { get; }
    }
    public partial interface ExecutePermission : IClass {

        M M { get; }

                ExecutePermissionMethodTypePointer MethodTypePointer { get; }

                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                PermissionClassPointer ClassPointer { get; }



                GrantsWhereEffectivePermission GrantsWhereEffectivePermission { get; }
                RevocationsWhereDeniedPermission RevocationsWhereDeniedPermission { get; }
                RolesWherePermission RolesWherePermission { get; }
                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
                IMethodType Delete { get; }
    }
    public partial interface ReadPermission : IClass {

        M M { get; }

                ReadPermissionRelationTypePointer RelationTypePointer { get; }

                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                PermissionClassPointer ClassPointer { get; }



                GrantsWhereEffectivePermission GrantsWhereEffectivePermission { get; }
                RevocationsWhereDeniedPermission RevocationsWhereDeniedPermission { get; }
                RolesWherePermission RolesWherePermission { get; }
                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
                IMethodType Delete { get; }
    }
    public partial interface WritePermission : IClass {

        M M { get; }

                WritePermissionRelationTypePointer RelationTypePointer { get; }

                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                PermissionClassPointer ClassPointer { get; }



                GrantsWhereEffectivePermission GrantsWhereEffectivePermission { get; }
                RevocationsWhereDeniedPermission RevocationsWhereDeniedPermission { get; }
                RolesWherePermission RolesWherePermission { get; }
                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
                IMethodType Delete { get; }
    }
    public partial interface Revocation : IClass {

        M M { get; }

                RevocationDeniedPermissions DeniedPermissions { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }


                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                ObjectsWhereRevocation ObjectsWhereRevocation { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
                IMethodType Delete { get; }
    }
    public partial interface Role : IClass {

        M M { get; }

                RolePermissions Permissions { get; }
                RoleName Name { get; }

                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                UniquelyIdentifiableUniqueId UniqueId { get; }


                GrantsWhereRole GrantsWhereRole { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
    }
    public partial interface SecurityToken : IClass {

        M M { get; }

                SecurityTokenGrants Grants { get; }
                SecurityTokenSecurityStamp SecurityStamp { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }


                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                ObjectsWhereSecurityToken ObjectsWhereSecurityToken { get; }
                SecurityTokenOwnerWhereOwnerSecurityToken SecurityTokenOwnerWhereOwnerSecurityToken { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
                IMethodType Delete { get; }
    }
    public partial interface UserGroup : IClass {

        M M { get; }

                UserGroupMembers Members { get; }
                UserGroupName Name { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }


                ObjectRevocations Revocations { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                GrantsWhereSubjectGroup GrantsWhereSubjectGroup { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }
    }
}