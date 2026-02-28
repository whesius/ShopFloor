namespace Allors.Database.Meta
{
    public partial interface M : IMetaPopulation {
        Binary Binary { get; }
        Boolean Boolean { get; }
        DateTime DateTime { get; }
        Decimal Decimal { get; }
        Float Float { get; }
        Integer Integer { get; }
        String String { get; }
        Unique Unique { get; }
        Deletable Deletable { get; }
        Object Object { get; }
        UniquelyIdentifiable UniquelyIdentifiable { get; }
        DelegatedAccessObject DelegatedAccessObject { get; }
        Permission Permission { get; }
        SecurityTokenOwner SecurityTokenOwner { get; }
        User User { get; }
        DispatchStatus DispatchStatus { get; }
        Equipment Equipment { get; }
        EquipmentActual EquipmentActual { get; }
        EquipmentClass EquipmentClass { get; }
        EquipmentClassProperty EquipmentClassProperty { get; }
        EquipmentLevel EquipmentLevel { get; }
        EquipmentProperty EquipmentProperty { get; }
        EquipmentRequirement EquipmentRequirement { get; }
        HierarchyScope HierarchyScope { get; }
        JobOrder JobOrder { get; }
        JobResponse JobResponse { get; }
        MaterialActual MaterialActual { get; }
        MaterialRequirement MaterialRequirement { get; }
        OperationsDefinition OperationsDefinition { get; }
        OperationsSegment OperationsSegment { get; }
        OperationsType OperationsType { get; }
        Person Person { get; }
        PersonnelActual PersonnelActual { get; }
        PersonnelClass PersonnelClass { get; }
        PersonnelClassProperty PersonnelClassProperty { get; }
        PersonnelRequirement PersonnelRequirement { get; }
        PersonProperty PersonProperty { get; }
        PhysicalAsset PhysicalAsset { get; }
        PhysicalAssetProperty PhysicalAssetProperty { get; }
        WorkMaster WorkMaster { get; }
        Grant Grant { get; }
        CreatePermission CreatePermission { get; }
        ExecutePermission ExecutePermission { get; }
        ReadPermission ReadPermission { get; }
        WritePermission WritePermission { get; }
        Revocation Revocation { get; }
        Role Role { get; }
        SecurityToken SecurityToken { get; }
        UserGroup UserGroup { get; }
    }
}