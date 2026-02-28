namespace Allors.Database.Meta
{
    public partial interface Deletable : IInterface {

        M M { get; }

                Equipment AsEquipment { get; }
                EquipmentActual AsEquipmentActual { get; }
                EquipmentClass AsEquipmentClass { get; }
                EquipmentClassProperty AsEquipmentClassProperty { get; }
                EquipmentProperty AsEquipmentProperty { get; }
                EquipmentRequirement AsEquipmentRequirement { get; }
                HierarchyScope AsHierarchyScope { get; }
                JobOrder AsJobOrder { get; }
                JobResponse AsJobResponse { get; }
                MaterialActual AsMaterialActual { get; }
                MaterialRequirement AsMaterialRequirement { get; }
                OperationsDefinition AsOperationsDefinition { get; }
                OperationsSegment AsOperationsSegment { get; }
                Person AsPerson { get; }
                PersonnelActual AsPersonnelActual { get; }
                PersonnelClass AsPersonnelClass { get; }
                PersonnelClassProperty AsPersonnelClassProperty { get; }
                PersonnelRequirement AsPersonnelRequirement { get; }
                PersonProperty AsPersonProperty { get; }
                PhysicalAsset AsPhysicalAsset { get; }
                PhysicalAssetProperty AsPhysicalAssetProperty { get; }
                WorkMaster AsWorkMaster { get; }
                Grant AsGrant { get; }
                CreatePermission AsCreatePermission { get; }
                ExecutePermission AsExecutePermission { get; }
                Permission AsPermission { get; }
                ReadPermission AsReadPermission { get; }
                WritePermission AsWritePermission { get; }
                Revocation AsRevocation { get; }
                SecurityToken AsSecurityToken { get; }
                User AsUser { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                ObjectRevocations Revocations { get; }



                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }

                IMethodType Delete { get; }

    }
    public partial interface Object : IInterface {

        M M { get; }

                DispatchStatus AsDispatchStatus { get; }
                Equipment AsEquipment { get; }
                EquipmentActual AsEquipmentActual { get; }
                EquipmentClass AsEquipmentClass { get; }
                EquipmentClassProperty AsEquipmentClassProperty { get; }
                EquipmentLevel AsEquipmentLevel { get; }
                EquipmentProperty AsEquipmentProperty { get; }
                EquipmentRequirement AsEquipmentRequirement { get; }
                HierarchyScope AsHierarchyScope { get; }
                JobOrder AsJobOrder { get; }
                JobResponse AsJobResponse { get; }
                MaterialActual AsMaterialActual { get; }
                MaterialRequirement AsMaterialRequirement { get; }
                OperationsDefinition AsOperationsDefinition { get; }
                OperationsSegment AsOperationsSegment { get; }
                OperationsType AsOperationsType { get; }
                Person AsPerson { get; }
                PersonnelActual AsPersonnelActual { get; }
                PersonnelClass AsPersonnelClass { get; }
                PersonnelClassProperty AsPersonnelClassProperty { get; }
                PersonnelRequirement AsPersonnelRequirement { get; }
                PersonProperty AsPersonProperty { get; }
                PhysicalAsset AsPhysicalAsset { get; }
                PhysicalAssetProperty AsPhysicalAssetProperty { get; }
                WorkMaster AsWorkMaster { get; }
                Deletable AsDeletable { get; }
                UniquelyIdentifiable AsUniquelyIdentifiable { get; }
                DelegatedAccessObject AsDelegatedAccessObject { get; }
                Grant AsGrant { get; }
                CreatePermission AsCreatePermission { get; }
                ExecutePermission AsExecutePermission { get; }
                Permission AsPermission { get; }
                ReadPermission AsReadPermission { get; }
                WritePermission AsWritePermission { get; }
                Revocation AsRevocation { get; }
                Role AsRole { get; }
                SecurityToken AsSecurityToken { get; }
                SecurityTokenOwner AsSecurityTokenOwner { get; }
                User AsUser { get; }
                UserGroup AsUserGroup { get; }

                ObjectSecurityTokens SecurityTokens { get; }
                ObjectRevocations Revocations { get; }


                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


                IMethodType OnBuild { get; }
                IMethodType OnPostBuild { get; }
                IMethodType OnInit { get; }
                IMethodType OnPostDerive { get; }

    }
    public partial interface UniquelyIdentifiable : IInterface {

        M M { get; }

                DispatchStatus AsDispatchStatus { get; }
                Equipment AsEquipment { get; }
                EquipmentActual AsEquipmentActual { get; }
                EquipmentClass AsEquipmentClass { get; }
                EquipmentClassProperty AsEquipmentClassProperty { get; }
                EquipmentLevel AsEquipmentLevel { get; }
                EquipmentProperty AsEquipmentProperty { get; }
                EquipmentRequirement AsEquipmentRequirement { get; }
                HierarchyScope AsHierarchyScope { get; }
                JobOrder AsJobOrder { get; }
                JobResponse AsJobResponse { get; }
                MaterialActual AsMaterialActual { get; }
                MaterialRequirement AsMaterialRequirement { get; }
                OperationsDefinition AsOperationsDefinition { get; }
                OperationsSegment AsOperationsSegment { get; }
                OperationsType AsOperationsType { get; }
                Person AsPerson { get; }
                PersonnelActual AsPersonnelActual { get; }
                PersonnelClass AsPersonnelClass { get; }
                PersonnelClassProperty AsPersonnelClassProperty { get; }
                PersonnelRequirement AsPersonnelRequirement { get; }
                PersonProperty AsPersonProperty { get; }
                PhysicalAsset AsPhysicalAsset { get; }
                PhysicalAssetProperty AsPhysicalAssetProperty { get; }
                WorkMaster AsWorkMaster { get; }
                Grant AsGrant { get; }
                Revocation AsRevocation { get; }
                Role AsRole { get; }
                SecurityToken AsSecurityToken { get; }
                User AsUser { get; }
                UserGroup AsUserGroup { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }

                ObjectSecurityTokens SecurityTokens { get; }


                ObjectRevocations Revocations { get; }



                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


    }
    public partial interface DelegatedAccessObject : IInterface {

        M M { get; }


                DelegatedAccessObjectDelegatedAccess DelegatedAccess { get; }

                ObjectSecurityTokens SecurityTokens { get; }


                ObjectRevocations Revocations { get; }



                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


    }
    public partial interface Permission : IInterface {

        M M { get; }

                CreatePermission AsCreatePermission { get; }
                ExecutePermission AsExecutePermission { get; }
                ReadPermission AsReadPermission { get; }
                WritePermission AsWritePermission { get; }

                PermissionClassPointer ClassPointer { get; }

                ObjectSecurityTokens SecurityTokens { get; }


                ObjectRevocations Revocations { get; }


                GrantsWhereEffectivePermission GrantsWhereEffectivePermission { get; }
                RevocationsWhereDeniedPermission RevocationsWhereDeniedPermission { get; }
                RolesWherePermission RolesWherePermission { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


    }
    public partial interface SecurityTokenOwner : IInterface {

        M M { get; }

                User AsUser { get; }

                SecurityTokenOwnerOwnerSecurityToken OwnerSecurityToken { get; }
                SecurityTokenOwnerOwnerGrant OwnerGrant { get; }

                ObjectSecurityTokens SecurityTokens { get; }


                ObjectRevocations Revocations { get; }



                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


    }
    public partial interface User : IInterface {

        M M { get; }


                UserUserName UserName { get; }
                UserNormalizedUserName NormalizedUserName { get; }

                UniquelyIdentifiableUniqueId UniqueId { get; }


                SecurityTokenOwnerOwnerSecurityToken OwnerSecurityToken { get; }


                SecurityTokenOwnerOwnerGrant OwnerGrant { get; }


                ObjectSecurityTokens SecurityTokens { get; }


                ObjectRevocations Revocations { get; }


                PersonWhereUser PersonWhereUser { get; }
                GrantsWhereSubject GrantsWhereSubject { get; }
                GrantsWhereEffectiveUser GrantsWhereEffectiveUser { get; }
                UserGroupsWhereMember UserGroupsWhereMember { get; }

                DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess { get; }


    }
}