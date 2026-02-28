namespace Allors.Database.Meta.Configuration
{
    using System;

    public partial class Ids {
        public static readonly Guid ShopFloor = new Guid("e2c3e380-4535-4739-8b1b-9c1c3e470a3b");
        public static readonly Guid Core = new Guid("770538dd-7b19-4694-bdce-cf04dcf9cf62");

        public static readonly Guid Binary = new Guid("c28e515b-cae8-4d6b-95bf-062aec8042fc");
        public static readonly Guid Boolean = new Guid("b5ee6cea-4e2b-498e-a5dd-24671d896477");
        public static readonly Guid DateTime = new Guid("c4c09343-61d3-418c-ade2-fe6fd588f128");
        public static readonly Guid Decimal = new Guid("da866d8e-2c40-41a8-ae5b-5f6dae0b89c8");
        public static readonly Guid Float = new Guid("ffcabd07-f35f-4083-bef6-f6c47970ca5d");
        public static readonly Guid Integer = new Guid("ccd6f134-26de-4103-bff9-a37ec3e997a3");
        public static readonly Guid String = new Guid("ad7f5ddc-bedb-4aaa-97ac-d6693a009ba9");
        public static readonly Guid Unique = new Guid("6dc0a1a8-88a4-4614-adb4-92dd3d017c0e");

        public static readonly Guid DispatchStatus = new Guid("a1b2c3d4-0011-4000-8000-000000000001");
        public static readonly Guid DispatchStatusName = new Guid("a1b2c3d4-0011-4000-8000-000000000011");
        public static readonly Guid DispatchStatusIsActive = new Guid("a1b2c3d4-0011-4000-8000-000000000012");

        public static readonly Guid Equipment = new Guid("a1b2c3d4-0004-4000-8000-000000000001");
        public static readonly Guid EquipmentName = new Guid("a1b2c3d4-0004-4000-8000-000000000011");
        public static readonly Guid EquipmentDescription = new Guid("a1b2c3d4-0004-4000-8000-000000000012");
        public static readonly Guid EquipmentEquipmentLevel = new Guid("a1b2c3d4-0004-4000-8000-000000000013");
        public static readonly Guid EquipmentEquipmentClasses = new Guid("a1b2c3d4-0004-4000-8000-000000000014");
        public static readonly Guid EquipmentEquipmentProperties = new Guid("a1b2c3d4-0004-4000-8000-000000000015");
        public static readonly Guid EquipmentEquipmentChildren = new Guid("a1b2c3d4-0004-4000-8000-000000000016");
        public static readonly Guid EquipmentEquipmentParent = new Guid("a1b2c3d4-0004-4000-8000-000000000017");
        public static readonly Guid EquipmentPhysicalAsset = new Guid("a1b2c3d4-0004-4000-8000-000000000018");
        public static readonly Guid EquipmentHierarchyScope = new Guid("a1b2c3d4-0004-4000-8000-000000000019");
        public static readonly Guid EquipmentDisplayName = new Guid("a1b2c3d4-0004-4000-8000-00000000001a");

        public static readonly Guid EquipmentActual = new Guid("a1b2c3d4-0018-4000-8000-000000000001");
        public static readonly Guid EquipmentActualEquipment = new Guid("a1b2c3d4-0018-4000-8000-000000000011");
        public static readonly Guid EquipmentActualEquipmentClass = new Guid("a1b2c3d4-0018-4000-8000-000000000012");
        public static readonly Guid EquipmentActualDescription = new Guid("a1b2c3d4-0018-4000-8000-000000000013");

        public static readonly Guid EquipmentClass = new Guid("a1b2c3d4-0002-4000-8000-000000000001");
        public static readonly Guid EquipmentClassName = new Guid("a1b2c3d4-0002-4000-8000-000000000011");
        public static readonly Guid EquipmentClassDescription = new Guid("a1b2c3d4-0002-4000-8000-000000000012");
        public static readonly Guid EquipmentClassEquipmentLevel = new Guid("a1b2c3d4-0002-4000-8000-000000000013");
        public static readonly Guid EquipmentClassEquipmentClassProperties = new Guid("a1b2c3d4-0002-4000-8000-000000000014");
        public static readonly Guid EquipmentClassEquipmentClassChildren = new Guid("a1b2c3d4-0002-4000-8000-000000000015");
        public static readonly Guid EquipmentClassEquipmentClassParent = new Guid("a1b2c3d4-0002-4000-8000-000000000016");

        public static readonly Guid EquipmentClassProperty = new Guid("a1b2c3d4-0003-4000-8000-000000000001");
        public static readonly Guid EquipmentClassPropertyName = new Guid("a1b2c3d4-0003-4000-8000-000000000011");
        public static readonly Guid EquipmentClassPropertyDescription = new Guid("a1b2c3d4-0003-4000-8000-000000000012");
        public static readonly Guid EquipmentClassPropertyDefaultValue = new Guid("a1b2c3d4-0003-4000-8000-000000000013");
        public static readonly Guid EquipmentClassPropertyPropertyType = new Guid("a1b2c3d4-0003-4000-8000-000000000014");
        public static readonly Guid EquipmentClassPropertyEquipmentClassPropertyChildren = new Guid("a1b2c3d4-0003-4000-8000-000000000015");

        public static readonly Guid EquipmentLevel = new Guid("a1b2c3d4-0001-4000-8000-000000000001");
        public static readonly Guid EquipmentLevelName = new Guid("a1b2c3d4-0001-4000-8000-000000000011");
        public static readonly Guid EquipmentLevelIsActive = new Guid("a1b2c3d4-0001-4000-8000-000000000012");

        public static readonly Guid EquipmentProperty = new Guid("a1b2c3d4-0005-4000-8000-000000000001");
        public static readonly Guid EquipmentPropertyName = new Guid("a1b2c3d4-0005-4000-8000-000000000011");
        public static readonly Guid EquipmentPropertyDescription = new Guid("a1b2c3d4-0005-4000-8000-000000000012");
        public static readonly Guid EquipmentPropertyValue = new Guid("a1b2c3d4-0005-4000-8000-000000000013");
        public static readonly Guid EquipmentPropertyEquipmentClassProperty = new Guid("a1b2c3d4-0005-4000-8000-000000000014");
        public static readonly Guid EquipmentPropertyEquipmentPropertyChildren = new Guid("a1b2c3d4-0005-4000-8000-000000000015");

        public static readonly Guid EquipmentRequirement = new Guid("a1b2c3d4-0015-4000-8000-000000000001");
        public static readonly Guid EquipmentRequirementEquipmentClass = new Guid("a1b2c3d4-0015-4000-8000-000000000011");
        public static readonly Guid EquipmentRequirementEquipment = new Guid("a1b2c3d4-0015-4000-8000-000000000012");
        public static readonly Guid EquipmentRequirementQuantity = new Guid("a1b2c3d4-0015-4000-8000-000000000013");
        public static readonly Guid EquipmentRequirementDescription = new Guid("a1b2c3d4-0015-4000-8000-000000000014");

        public static readonly Guid HierarchyScope = new Guid("a1b2c3d4-0008-4000-8000-000000000001");
        public static readonly Guid HierarchyScopeScopedEquipment = new Guid("a1b2c3d4-0008-4000-8000-000000000011");
        public static readonly Guid HierarchyScopeEquipmentLevel = new Guid("a1b2c3d4-0008-4000-8000-000000000012");

        public static readonly Guid JobOrder = new Guid("a1b2c3d4-0012-4000-8000-000000000001");
        public static readonly Guid JobOrderName = new Guid("a1b2c3d4-0012-4000-8000-000000000011");
        public static readonly Guid JobOrderDescription = new Guid("a1b2c3d4-0012-4000-8000-000000000012");
        public static readonly Guid JobOrderWorkType = new Guid("a1b2c3d4-0012-4000-8000-000000000013");
        public static readonly Guid JobOrderWorkMaster = new Guid("a1b2c3d4-0012-4000-8000-000000000014");
        public static readonly Guid JobOrderEquipment = new Guid("a1b2c3d4-0012-4000-8000-000000000015");
        public static readonly Guid JobOrderPriority = new Guid("a1b2c3d4-0012-4000-8000-000000000016");
        public static readonly Guid JobOrderDispatchStatus = new Guid("a1b2c3d4-0012-4000-8000-000000000017");
        public static readonly Guid JobOrderStartTime = new Guid("a1b2c3d4-0012-4000-8000-000000000018");
        public static readonly Guid JobOrderEndTime = new Guid("a1b2c3d4-0012-4000-8000-000000000019");
        public static readonly Guid JobOrderHierarchyScope = new Guid("a1b2c3d4-0012-4000-8000-00000000001a");
        public static readonly Guid JobOrderPersonnelRequirements = new Guid("a1b2c3d4-0012-4000-8000-00000000001b");
        public static readonly Guid JobOrderEquipmentRequirements = new Guid("a1b2c3d4-0012-4000-8000-00000000001c");
        public static readonly Guid JobOrderMaterialRequirements = new Guid("a1b2c3d4-0012-4000-8000-00000000001d");
        public static readonly Guid JobOrderAssignedTo = new Guid("a1b2c3d4-0012-4000-8000-00000000001e");
        public static readonly Guid JobOrderResponse = new Guid("a1b2c3d4-0012-4000-8000-00000000001f");

        public static readonly Guid JobResponse = new Guid("a1b2c3d4-0013-4000-8000-000000000001");
        public static readonly Guid JobResponseDescription = new Guid("a1b2c3d4-0013-4000-8000-000000000011");
        public static readonly Guid JobResponseWorkType = new Guid("a1b2c3d4-0013-4000-8000-000000000012");
        public static readonly Guid JobResponseJobOrder = new Guid("a1b2c3d4-0013-4000-8000-000000000013");
        public static readonly Guid JobResponseStartTime = new Guid("a1b2c3d4-0013-4000-8000-000000000014");
        public static readonly Guid JobResponseEndTime = new Guid("a1b2c3d4-0013-4000-8000-000000000015");
        public static readonly Guid JobResponseJobState = new Guid("a1b2c3d4-0013-4000-8000-000000000016");
        public static readonly Guid JobResponsePersonnelActuals = new Guid("a1b2c3d4-0013-4000-8000-000000000017");
        public static readonly Guid JobResponseEquipmentActuals = new Guid("a1b2c3d4-0013-4000-8000-000000000018");
        public static readonly Guid JobResponseMaterialActuals = new Guid("a1b2c3d4-0013-4000-8000-000000000019");

        public static readonly Guid MaterialActual = new Guid("a1b2c3d4-0019-4000-8000-000000000001");
        public static readonly Guid MaterialActualName = new Guid("a1b2c3d4-0019-4000-8000-000000000011");
        public static readonly Guid MaterialActualQuantity = new Guid("a1b2c3d4-0019-4000-8000-000000000012");
        public static readonly Guid MaterialActualDescription = new Guid("a1b2c3d4-0019-4000-8000-000000000013");

        public static readonly Guid MaterialRequirement = new Guid("a1b2c3d4-0016-4000-8000-000000000001");
        public static readonly Guid MaterialRequirementName = new Guid("a1b2c3d4-0016-4000-8000-000000000011");
        public static readonly Guid MaterialRequirementQuantity = new Guid("a1b2c3d4-0016-4000-8000-000000000012");
        public static readonly Guid MaterialRequirementDescription = new Guid("a1b2c3d4-0016-4000-8000-000000000013");

        public static readonly Guid OperationsDefinition = new Guid("a1b2c3d4-000e-4000-8000-000000000001");
        public static readonly Guid OperationsDefinitionName = new Guid("a1b2c3d4-000e-4000-8000-000000000011");
        public static readonly Guid OperationsDefinitionDescription = new Guid("a1b2c3d4-000e-4000-8000-000000000012");
        public static readonly Guid OperationsDefinitionVersion = new Guid("a1b2c3d4-000e-4000-8000-000000000013");
        public static readonly Guid OperationsDefinitionOperationsType = new Guid("a1b2c3d4-000e-4000-8000-000000000014");
        public static readonly Guid OperationsDefinitionOperationsSegments = new Guid("a1b2c3d4-000e-4000-8000-000000000015");
        public static readonly Guid OperationsDefinitionEffectiveStartDate = new Guid("a1b2c3d4-000e-4000-8000-000000000016");
        public static readonly Guid OperationsDefinitionEffectiveEndDate = new Guid("a1b2c3d4-000e-4000-8000-000000000017");
        public static readonly Guid OperationsDefinitionHierarchyScope = new Guid("a1b2c3d4-000e-4000-8000-000000000018");

        public static readonly Guid OperationsSegment = new Guid("a1b2c3d4-000f-4000-8000-000000000001");
        public static readonly Guid OperationsSegmentName = new Guid("a1b2c3d4-000f-4000-8000-000000000011");
        public static readonly Guid OperationsSegmentDescription = new Guid("a1b2c3d4-000f-4000-8000-000000000012");
        public static readonly Guid OperationsSegmentDuration = new Guid("a1b2c3d4-000f-4000-8000-000000000013");
        public static readonly Guid OperationsSegmentOperationsType = new Guid("a1b2c3d4-000f-4000-8000-000000000014");
        public static readonly Guid OperationsSegmentPersonnelSpecifications = new Guid("a1b2c3d4-000f-4000-8000-000000000015");
        public static readonly Guid OperationsSegmentEquipmentSpecifications = new Guid("a1b2c3d4-000f-4000-8000-000000000016");
        public static readonly Guid OperationsSegmentMaterialSpecifications = new Guid("a1b2c3d4-000f-4000-8000-000000000017");
        public static readonly Guid OperationsSegmentOperationsSegmentChildren = new Guid("a1b2c3d4-000f-4000-8000-000000000018");
        public static readonly Guid OperationsSegmentOperationsSegmentParent = new Guid("a1b2c3d4-000f-4000-8000-000000000019");

        public static readonly Guid OperationsType = new Guid("a1b2c3d4-000d-4000-8000-000000000001");
        public static readonly Guid OperationsTypeName = new Guid("a1b2c3d4-000d-4000-8000-000000000011");
        public static readonly Guid OperationsTypeIsActive = new Guid("a1b2c3d4-000d-4000-8000-000000000012");

        public static readonly Guid Person = new Guid("a1b2c3d4-000b-4000-8000-000000000001");
        public static readonly Guid PersonFirstName = new Guid("a1b2c3d4-000b-4000-8000-000000000011");
        public static readonly Guid PersonLastName = new Guid("a1b2c3d4-000b-4000-8000-000000000012");
        public static readonly Guid PersonUser = new Guid("a1b2c3d4-000b-4000-8000-000000000013");
        public static readonly Guid PersonPersonnelClasses = new Guid("a1b2c3d4-000b-4000-8000-000000000014");
        public static readonly Guid PersonPersonProperties = new Guid("a1b2c3d4-000b-4000-8000-000000000015");
        public static readonly Guid PersonDisplayName = new Guid("a1b2c3d4-000b-4000-8000-000000000016");

        public static readonly Guid PersonnelActual = new Guid("a1b2c3d4-0017-4000-8000-000000000001");
        public static readonly Guid PersonnelActualPerson = new Guid("a1b2c3d4-0017-4000-8000-000000000011");
        public static readonly Guid PersonnelActualPersonnelClass = new Guid("a1b2c3d4-0017-4000-8000-000000000012");
        public static readonly Guid PersonnelActualDescription = new Guid("a1b2c3d4-0017-4000-8000-000000000013");

        public static readonly Guid PersonnelClass = new Guid("a1b2c3d4-0009-4000-8000-000000000001");
        public static readonly Guid PersonnelClassName = new Guid("a1b2c3d4-0009-4000-8000-000000000011");
        public static readonly Guid PersonnelClassDescription = new Guid("a1b2c3d4-0009-4000-8000-000000000012");
        public static readonly Guid PersonnelClassPersonnelClassProperties = new Guid("a1b2c3d4-0009-4000-8000-000000000013");
        public static readonly Guid PersonnelClassPersonnelClassParent = new Guid("a1b2c3d4-0009-4000-8000-000000000014");

        public static readonly Guid PersonnelClassProperty = new Guid("a1b2c3d4-000a-4000-8000-000000000001");
        public static readonly Guid PersonnelClassPropertyName = new Guid("a1b2c3d4-000a-4000-8000-000000000011");
        public static readonly Guid PersonnelClassPropertyDescription = new Guid("a1b2c3d4-000a-4000-8000-000000000012");
        public static readonly Guid PersonnelClassPropertyDefaultValue = new Guid("a1b2c3d4-000a-4000-8000-000000000013");

        public static readonly Guid PersonnelRequirement = new Guid("a1b2c3d4-0014-4000-8000-000000000001");
        public static readonly Guid PersonnelRequirementPersonnelClass = new Guid("a1b2c3d4-0014-4000-8000-000000000011");
        public static readonly Guid PersonnelRequirementPerson = new Guid("a1b2c3d4-0014-4000-8000-000000000012");
        public static readonly Guid PersonnelRequirementQuantity = new Guid("a1b2c3d4-0014-4000-8000-000000000013");
        public static readonly Guid PersonnelRequirementDescription = new Guid("a1b2c3d4-0014-4000-8000-000000000014");

        public static readonly Guid PersonProperty = new Guid("a1b2c3d4-000c-4000-8000-000000000001");
        public static readonly Guid PersonPropertyName = new Guid("a1b2c3d4-000c-4000-8000-000000000011");
        public static readonly Guid PersonPropertyValue = new Guid("a1b2c3d4-000c-4000-8000-000000000012");
        public static readonly Guid PersonPropertyPersonnelClassProperty = new Guid("a1b2c3d4-000c-4000-8000-000000000013");

        public static readonly Guid PhysicalAsset = new Guid("a1b2c3d4-0006-4000-8000-000000000001");
        public static readonly Guid PhysicalAssetName = new Guid("a1b2c3d4-0006-4000-8000-000000000011");
        public static readonly Guid PhysicalAssetDescription = new Guid("a1b2c3d4-0006-4000-8000-000000000012");
        public static readonly Guid PhysicalAssetSerialNumber = new Guid("a1b2c3d4-0006-4000-8000-000000000013");
        public static readonly Guid PhysicalAssetManufacturer = new Guid("a1b2c3d4-0006-4000-8000-000000000014");
        public static readonly Guid PhysicalAssetModelNumber = new Guid("a1b2c3d4-0006-4000-8000-000000000015");
        public static readonly Guid PhysicalAssetInstallationDate = new Guid("a1b2c3d4-0006-4000-8000-000000000016");
        public static readonly Guid PhysicalAssetPhysicalAssetProperties = new Guid("a1b2c3d4-0006-4000-8000-000000000017");
        public static readonly Guid PhysicalAssetPhysicalAssetChildren = new Guid("a1b2c3d4-0006-4000-8000-000000000018");

        public static readonly Guid PhysicalAssetProperty = new Guid("a1b2c3d4-0007-4000-8000-000000000001");
        public static readonly Guid PhysicalAssetPropertyName = new Guid("a1b2c3d4-0007-4000-8000-000000000011");
        public static readonly Guid PhysicalAssetPropertyValue = new Guid("a1b2c3d4-0007-4000-8000-000000000012");

        public static readonly Guid WorkMaster = new Guid("a1b2c3d4-0010-4000-8000-000000000001");
        public static readonly Guid WorkMasterName = new Guid("a1b2c3d4-0010-4000-8000-000000000011");
        public static readonly Guid WorkMasterDescription = new Guid("a1b2c3d4-0010-4000-8000-000000000012");
        public static readonly Guid WorkMasterVersion = new Guid("a1b2c3d4-0010-4000-8000-000000000013");
        public static readonly Guid WorkMasterWorkType = new Guid("a1b2c3d4-0010-4000-8000-000000000014");
        public static readonly Guid WorkMasterDuration = new Guid("a1b2c3d4-0010-4000-8000-000000000015");
        public static readonly Guid WorkMasterOperationsDefinition = new Guid("a1b2c3d4-0010-4000-8000-000000000016");
        public static readonly Guid WorkMasterPersonnelSpecifications = new Guid("a1b2c3d4-0010-4000-8000-000000000017");
        public static readonly Guid WorkMasterEquipmentSpecifications = new Guid("a1b2c3d4-0010-4000-8000-000000000018");
        public static readonly Guid WorkMasterMaterialSpecifications = new Guid("a1b2c3d4-0010-4000-8000-000000000019");
        public static readonly Guid WorkMasterWorkMasterChildren = new Guid("a1b2c3d4-0010-4000-8000-00000000001a");

        public static readonly Guid Grant = new Guid("c4d93d5e-34c3-4731-9d37-47a8e801d9a8");
        public static readonly Guid GrantSubjectGroups = new Guid("0dbbff5c-3dca-4257-b2da-442d263dcd86");
        public static readonly Guid GrantSubjects = new Guid("37dd1e27-ba75-404c-9410-c6399d28317c");
        public static readonly Guid GrantRole = new Guid("69a9dae8-678d-4c1c-a464-2e5aa5caf39e");
        public static readonly Guid GrantEffectivePermissions = new Guid("5e218f37-3b07-4002-87a4-7581a53f01ba");
        public static readonly Guid GrantEffectiveUsers = new Guid("50ecae85-e5a9-467e-99a3-78703d954b2f");

        public static readonly Guid CreatePermission = new Guid("412994f9-4d0e-4d75-ae27-3063046869f0");

        public static readonly Guid ExecutePermission = new Guid("2e839427-58d6-4567-b9aa-fbe6071590e3");
        public static readonly Guid ExecutePermissionMethodTypePointer = new Guid("CB76C8B7-681E-450B-A3EC-95C32E1ED5B6");

        public static readonly Guid ReadPermission = new Guid("0716c285-841c-419b-a8c4-a67bfa585cda");
        public static readonly Guid ReadPermissionRelationTypePointer = new Guid("88A27D41-E97E-4446-86D7-2E2FC10C5004");

        public static readonly Guid WritePermission = new Guid("4f00e50d-4324-4005-a405-6dfd1232982a");
        public static readonly Guid WritePermissionRelationTypePointer = new Guid("86675DEA-D9F0-4930-99EC-13F2137CFB45");

        public static readonly Guid Revocation = new Guid("753a230e-6c29-4c3c-9592-323be0778ed6");
        public static readonly Guid RevocationDeniedPermissions = new Guid("F7F98147-FD94-4BB1-A974-6405A3AB369E");

        public static readonly Guid Role = new Guid("af6fe5f4-e5bc-4099-bcd1-97528af6505d");
        public static readonly Guid RolePermissions = new Guid("51e56ae1-72dc-443f-a2a3-f5aa3650f8d2");
        public static readonly Guid RoleName = new Guid("934bcbbe-5286-445c-a1bd-e2fcc786c448");

        public static readonly Guid SecurityToken = new Guid("a53f1aed-0e3f-4c3c-9600-dc579cccf893");
        public static readonly Guid SecurityTokenGrants = new Guid("6503574b-8bab-4da8-a19d-23a9bcffe01e");
        public static readonly Guid SecurityTokenSecurityStamp = new Guid("E094E1DD-A3B0-4B6A-B2FA-B00E98BDC0D6");

        public static readonly Guid UserGroup = new Guid("60065f5d-a3c2-4418-880d-1026ab607319");
        public static readonly Guid UserGroupMembers = new Guid("585bb5cf-9ba4-4865-9027-3667185abc4f");
        public static readonly Guid UserGroupName = new Guid("e94e7f05-78bd-4291-923f-38f82d00e3f4");

        public static readonly Guid Deletable = new Guid("9279e337-c658-4086-946d-03c75cdb1ad3");
        public static readonly Guid DeletableDelete = new Guid("430702D2-E02B-45AD-9B22-B8331DC75A3F");

        public static readonly Guid Object = new Guid("12504f04-02c6-4778-98fe-04eba12ef8b2");
        public static readonly Guid ObjectSecurityTokens = new Guid("b816fccd-08e0-46e0-a49c-7213c3604416");
        public static readonly Guid ObjectRevocations = new Guid("E989F7D2-A4AC-43D8-AC7C-CBCDA2CFB6D3");
        public static readonly Guid ObjectOnBuild = new Guid("FDD32313-CF62-4166-9167-EF90BE3A3C75");
        public static readonly Guid ObjectOnPostBuild = new Guid("2B827E22-155D-4AA8-BA9F-46A64D7C79C8");
        public static readonly Guid ObjectOnInit = new Guid("4E5A4C91-C430-49FB-B15D-D4CB0155C551");
        public static readonly Guid ObjectOnPostDerive = new Guid("07AFF35D-F4CB-48FE-A39A-176B1931FAB7");

        public static readonly Guid UniquelyIdentifiable = new Guid("122ccfe1-f902-44c1-9d6c-6f6a0afa9469");
        public static readonly Guid UniquelyIdentifiableUniqueId = new Guid("e1842d87-8157-40e7-b06e-4375f311f2c3");

        public static readonly Guid DelegatedAccessObject = new Guid("842fa7b5-2668-43e9-bfef-21b6f5b20e8b");
        public static readonly Guid DelegatedAccessObjectDelegatedAccess = new Guid("4277EB04-A800-4EA9-B19F-A2268D903D5F");

        public static readonly Guid Permission = new Guid("7fded183-3337-4196-afb0-3266377944bc");
        public static readonly Guid PermissionClassPointer = new Guid("29b80857-e51b-4dec-b859-887ed74b1626");

        public static readonly Guid SecurityTokenOwner = new Guid("a69cad9c-c2f1-463f-9af1-873ce65aeea6");
        public static readonly Guid SecurityTokenOwnerOwnerSecurityToken = new Guid("5fb15e8b-011c-46f7-83dd-485d4cc4f9f2");
        public static readonly Guid SecurityTokenOwnerOwnerGrant = new Guid("056914ed-a658-4ae5-b859-97300e1b8911");

        public static readonly Guid User = new Guid("a0309c3b-6f80-4777-983e-6e69800df5be");
        public static readonly Guid UserUserName = new Guid("5e8ab257-1a1c-4448-aacc-71dbaaba525b");
        public static readonly Guid UserNormalizedUserName = new Guid("7397B596-D8FA-4E3C-8E0E-EA24790FE2E4");

    }
}