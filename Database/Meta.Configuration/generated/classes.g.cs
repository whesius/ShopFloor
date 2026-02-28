namespace Allors.Database.Meta.Configuration
{
    public partial class DispatchStatus : Class, Meta.DispatchStatus {
        public DispatchStatus(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.DispatchStatus.M => (Meta.M)this.MetaPopulation;

        public DispatchStatusName Name;
        Meta.DispatchStatusName Meta.DispatchStatus.Name => this.Name;
        public DispatchStatusIsActive IsActive;
        Meta.DispatchStatusIsActive Meta.DispatchStatus.IsActive => this.IsActive;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.DispatchStatus.UniqueId => UniqueId;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.DispatchStatus.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.DispatchStatus.SecurityTokens => SecurityTokens;


        public JobOrdersWhereDispatchStatus JobOrdersWhereDispatchStatus;
        Meta.JobOrdersWhereDispatchStatus Meta.DispatchStatus.JobOrdersWhereDispatchStatus => this.JobOrdersWhereDispatchStatus;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.DispatchStatus.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.DispatchStatus.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.DispatchStatus.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.DispatchStatus.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.DispatchStatus.OnPostDerive => this.OnPostDerive;
    }
    public partial class Equipment : Class, Meta.Equipment {
        public Equipment(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.Equipment.M => (Meta.M)this.MetaPopulation;

        public EquipmentName Name;
        Meta.EquipmentName Meta.Equipment.Name => this.Name;
        public EquipmentDescription Description;
        Meta.EquipmentDescription Meta.Equipment.Description => this.Description;
        public EquipmentEquipmentLevel EquipmentLevel;
        Meta.EquipmentEquipmentLevel Meta.Equipment.EquipmentLevel => this.EquipmentLevel;
        public EquipmentEquipmentClasses EquipmentClasses;
        Meta.EquipmentEquipmentClasses Meta.Equipment.EquipmentClasses => this.EquipmentClasses;
        public EquipmentEquipmentProperties EquipmentProperties;
        Meta.EquipmentEquipmentProperties Meta.Equipment.EquipmentProperties => this.EquipmentProperties;
        public EquipmentEquipmentChildren EquipmentChildren;
        Meta.EquipmentEquipmentChildren Meta.Equipment.EquipmentChildren => this.EquipmentChildren;
        public EquipmentEquipmentParent EquipmentParent;
        Meta.EquipmentEquipmentParent Meta.Equipment.EquipmentParent => this.EquipmentParent;
        public EquipmentPhysicalAsset PhysicalAsset;
        Meta.EquipmentPhysicalAsset Meta.Equipment.PhysicalAsset => this.PhysicalAsset;
        public EquipmentHierarchyScope HierarchyScope;
        Meta.EquipmentHierarchyScope Meta.Equipment.HierarchyScope => this.HierarchyScope;
        public EquipmentDisplayName DisplayName;
        Meta.EquipmentDisplayName Meta.Equipment.DisplayName => this.DisplayName;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.Equipment.UniqueId => UniqueId;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.Equipment.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.Equipment.SecurityTokens => SecurityTokens;


        public EquipmentWhereEquipmentChild EquipmentWhereEquipmentChild;
        Meta.EquipmentWhereEquipmentChild Meta.Equipment.EquipmentWhereEquipmentChild => this.EquipmentWhereEquipmentChild;
        public EquipmentsWhereEquipmentParent EquipmentsWhereEquipmentParent;
        Meta.EquipmentsWhereEquipmentParent Meta.Equipment.EquipmentsWhereEquipmentParent => this.EquipmentsWhereEquipmentParent;
        public EquipmentActualsWhereEquipment EquipmentActualsWhereEquipment;
        Meta.EquipmentActualsWhereEquipment Meta.Equipment.EquipmentActualsWhereEquipment => this.EquipmentActualsWhereEquipment;
        public EquipmentRequirementsWhereEquipment EquipmentRequirementsWhereEquipment;
        Meta.EquipmentRequirementsWhereEquipment Meta.Equipment.EquipmentRequirementsWhereEquipment => this.EquipmentRequirementsWhereEquipment;
        public HierarchyScopesWhereScopedEquipment HierarchyScopesWhereScopedEquipment;
        Meta.HierarchyScopesWhereScopedEquipment Meta.Equipment.HierarchyScopesWhereScopedEquipment => this.HierarchyScopesWhereScopedEquipment;
        public JobOrdersWhereEquipment JobOrdersWhereEquipment;
        Meta.JobOrdersWhereEquipment Meta.Equipment.JobOrdersWhereEquipment => this.JobOrdersWhereEquipment;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.Equipment.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.Equipment.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.Equipment.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.Equipment.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.Equipment.OnPostDerive => this.OnPostDerive;
        public MethodType Delete;
        IMethodType Meta.Equipment.Delete => this.Delete;
    }
    public partial class EquipmentActual : Class, Meta.EquipmentActual {
        public EquipmentActual(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.EquipmentActual.M => (Meta.M)this.MetaPopulation;

        public EquipmentActualEquipment Equipment;
        Meta.EquipmentActualEquipment Meta.EquipmentActual.Equipment => this.Equipment;
        public EquipmentActualEquipmentClass EquipmentClass;
        Meta.EquipmentActualEquipmentClass Meta.EquipmentActual.EquipmentClass => this.EquipmentClass;
        public EquipmentActualDescription Description;
        Meta.EquipmentActualDescription Meta.EquipmentActual.Description => this.Description;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.EquipmentActual.UniqueId => UniqueId;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.EquipmentActual.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.EquipmentActual.SecurityTokens => SecurityTokens;


        public JobResponseWhereEquipmentActual JobResponseWhereEquipmentActual;
        Meta.JobResponseWhereEquipmentActual Meta.EquipmentActual.JobResponseWhereEquipmentActual => this.JobResponseWhereEquipmentActual;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.EquipmentActual.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.EquipmentActual.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.EquipmentActual.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.EquipmentActual.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.EquipmentActual.OnPostDerive => this.OnPostDerive;
        public MethodType Delete;
        IMethodType Meta.EquipmentActual.Delete => this.Delete;
    }
    public partial class EquipmentClass : Class, Meta.EquipmentClass {
        public EquipmentClass(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.EquipmentClass.M => (Meta.M)this.MetaPopulation;

        public EquipmentClassName Name;
        Meta.EquipmentClassName Meta.EquipmentClass.Name => this.Name;
        public EquipmentClassDescription Description;
        Meta.EquipmentClassDescription Meta.EquipmentClass.Description => this.Description;
        public EquipmentClassEquipmentLevel EquipmentLevel;
        Meta.EquipmentClassEquipmentLevel Meta.EquipmentClass.EquipmentLevel => this.EquipmentLevel;
        public EquipmentClassEquipmentClassProperties EquipmentClassProperties;
        Meta.EquipmentClassEquipmentClassProperties Meta.EquipmentClass.EquipmentClassProperties => this.EquipmentClassProperties;
        public EquipmentClassEquipmentClassChildren EquipmentClassChildren;
        Meta.EquipmentClassEquipmentClassChildren Meta.EquipmentClass.EquipmentClassChildren => this.EquipmentClassChildren;
        public EquipmentClassEquipmentClassParent EquipmentClassParent;
        Meta.EquipmentClassEquipmentClassParent Meta.EquipmentClass.EquipmentClassParent => this.EquipmentClassParent;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.EquipmentClass.UniqueId => UniqueId;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.EquipmentClass.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.EquipmentClass.SecurityTokens => SecurityTokens;


        public EquipmentsWhereEquipmentClass EquipmentsWhereEquipmentClass;
        Meta.EquipmentsWhereEquipmentClass Meta.EquipmentClass.EquipmentsWhereEquipmentClass => this.EquipmentsWhereEquipmentClass;
        public EquipmentActualsWhereEquipmentClass EquipmentActualsWhereEquipmentClass;
        Meta.EquipmentActualsWhereEquipmentClass Meta.EquipmentClass.EquipmentActualsWhereEquipmentClass => this.EquipmentActualsWhereEquipmentClass;
        public EquipmentClassWhereEquipmentClassChild EquipmentClassWhereEquipmentClassChild;
        Meta.EquipmentClassWhereEquipmentClassChild Meta.EquipmentClass.EquipmentClassWhereEquipmentClassChild => this.EquipmentClassWhereEquipmentClassChild;
        public EquipmentClassesWhereEquipmentClassParent EquipmentClassesWhereEquipmentClassParent;
        Meta.EquipmentClassesWhereEquipmentClassParent Meta.EquipmentClass.EquipmentClassesWhereEquipmentClassParent => this.EquipmentClassesWhereEquipmentClassParent;
        public EquipmentRequirementsWhereEquipmentClass EquipmentRequirementsWhereEquipmentClass;
        Meta.EquipmentRequirementsWhereEquipmentClass Meta.EquipmentClass.EquipmentRequirementsWhereEquipmentClass => this.EquipmentRequirementsWhereEquipmentClass;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.EquipmentClass.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.EquipmentClass.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.EquipmentClass.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.EquipmentClass.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.EquipmentClass.OnPostDerive => this.OnPostDerive;
        public MethodType Delete;
        IMethodType Meta.EquipmentClass.Delete => this.Delete;
    }
    public partial class EquipmentClassProperty : Class, Meta.EquipmentClassProperty {
        public EquipmentClassProperty(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.EquipmentClassProperty.M => (Meta.M)this.MetaPopulation;

        public EquipmentClassPropertyName Name;
        Meta.EquipmentClassPropertyName Meta.EquipmentClassProperty.Name => this.Name;
        public EquipmentClassPropertyDescription Description;
        Meta.EquipmentClassPropertyDescription Meta.EquipmentClassProperty.Description => this.Description;
        public EquipmentClassPropertyDefaultValue DefaultValue;
        Meta.EquipmentClassPropertyDefaultValue Meta.EquipmentClassProperty.DefaultValue => this.DefaultValue;
        public EquipmentClassPropertyPropertyType PropertyType;
        Meta.EquipmentClassPropertyPropertyType Meta.EquipmentClassProperty.PropertyType => this.PropertyType;
        public EquipmentClassPropertyEquipmentClassPropertyChildren EquipmentClassPropertyChildren;
        Meta.EquipmentClassPropertyEquipmentClassPropertyChildren Meta.EquipmentClassProperty.EquipmentClassPropertyChildren => this.EquipmentClassPropertyChildren;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.EquipmentClassProperty.UniqueId => UniqueId;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.EquipmentClassProperty.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.EquipmentClassProperty.SecurityTokens => SecurityTokens;


        public EquipmentClassWhereEquipmentClassProperty EquipmentClassWhereEquipmentClassProperty;
        Meta.EquipmentClassWhereEquipmentClassProperty Meta.EquipmentClassProperty.EquipmentClassWhereEquipmentClassProperty => this.EquipmentClassWhereEquipmentClassProperty;
        public EquipmentClassPropertyWhereEquipmentClassPropertyChild EquipmentClassPropertyWhereEquipmentClassPropertyChild;
        Meta.EquipmentClassPropertyWhereEquipmentClassPropertyChild Meta.EquipmentClassProperty.EquipmentClassPropertyWhereEquipmentClassPropertyChild => this.EquipmentClassPropertyWhereEquipmentClassPropertyChild;
        public EquipmentPropertiesWhereEquipmentClassProperty EquipmentPropertiesWhereEquipmentClassProperty;
        Meta.EquipmentPropertiesWhereEquipmentClassProperty Meta.EquipmentClassProperty.EquipmentPropertiesWhereEquipmentClassProperty => this.EquipmentPropertiesWhereEquipmentClassProperty;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.EquipmentClassProperty.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.EquipmentClassProperty.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.EquipmentClassProperty.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.EquipmentClassProperty.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.EquipmentClassProperty.OnPostDerive => this.OnPostDerive;
        public MethodType Delete;
        IMethodType Meta.EquipmentClassProperty.Delete => this.Delete;
    }
    public partial class EquipmentLevel : Class, Meta.EquipmentLevel {
        public EquipmentLevel(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.EquipmentLevel.M => (Meta.M)this.MetaPopulation;

        public EquipmentLevelName Name;
        Meta.EquipmentLevelName Meta.EquipmentLevel.Name => this.Name;
        public EquipmentLevelIsActive IsActive;
        Meta.EquipmentLevelIsActive Meta.EquipmentLevel.IsActive => this.IsActive;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.EquipmentLevel.UniqueId => UniqueId;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.EquipmentLevel.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.EquipmentLevel.SecurityTokens => SecurityTokens;


        public EquipmentsWhereEquipmentLevel EquipmentsWhereEquipmentLevel;
        Meta.EquipmentsWhereEquipmentLevel Meta.EquipmentLevel.EquipmentsWhereEquipmentLevel => this.EquipmentsWhereEquipmentLevel;
        public EquipmentClassesWhereEquipmentLevel EquipmentClassesWhereEquipmentLevel;
        Meta.EquipmentClassesWhereEquipmentLevel Meta.EquipmentLevel.EquipmentClassesWhereEquipmentLevel => this.EquipmentClassesWhereEquipmentLevel;
        public HierarchyScopesWhereEquipmentLevel HierarchyScopesWhereEquipmentLevel;
        Meta.HierarchyScopesWhereEquipmentLevel Meta.EquipmentLevel.HierarchyScopesWhereEquipmentLevel => this.HierarchyScopesWhereEquipmentLevel;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.EquipmentLevel.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.EquipmentLevel.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.EquipmentLevel.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.EquipmentLevel.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.EquipmentLevel.OnPostDerive => this.OnPostDerive;
    }
    public partial class EquipmentProperty : Class, Meta.EquipmentProperty {
        public EquipmentProperty(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.EquipmentProperty.M => (Meta.M)this.MetaPopulation;

        public EquipmentPropertyName Name;
        Meta.EquipmentPropertyName Meta.EquipmentProperty.Name => this.Name;
        public EquipmentPropertyDescription Description;
        Meta.EquipmentPropertyDescription Meta.EquipmentProperty.Description => this.Description;
        public EquipmentPropertyValue Value;
        Meta.EquipmentPropertyValue Meta.EquipmentProperty.Value => this.Value;
        public EquipmentPropertyEquipmentClassProperty EquipmentClassProperty;
        Meta.EquipmentPropertyEquipmentClassProperty Meta.EquipmentProperty.EquipmentClassProperty => this.EquipmentClassProperty;
        public EquipmentPropertyEquipmentPropertyChildren EquipmentPropertyChildren;
        Meta.EquipmentPropertyEquipmentPropertyChildren Meta.EquipmentProperty.EquipmentPropertyChildren => this.EquipmentPropertyChildren;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.EquipmentProperty.UniqueId => UniqueId;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.EquipmentProperty.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.EquipmentProperty.SecurityTokens => SecurityTokens;


        public EquipmentWhereEquipmentProperty EquipmentWhereEquipmentProperty;
        Meta.EquipmentWhereEquipmentProperty Meta.EquipmentProperty.EquipmentWhereEquipmentProperty => this.EquipmentWhereEquipmentProperty;
        public EquipmentPropertyWhereEquipmentPropertyChild EquipmentPropertyWhereEquipmentPropertyChild;
        Meta.EquipmentPropertyWhereEquipmentPropertyChild Meta.EquipmentProperty.EquipmentPropertyWhereEquipmentPropertyChild => this.EquipmentPropertyWhereEquipmentPropertyChild;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.EquipmentProperty.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.EquipmentProperty.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.EquipmentProperty.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.EquipmentProperty.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.EquipmentProperty.OnPostDerive => this.OnPostDerive;
        public MethodType Delete;
        IMethodType Meta.EquipmentProperty.Delete => this.Delete;
    }
    public partial class EquipmentRequirement : Class, Meta.EquipmentRequirement {
        public EquipmentRequirement(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.EquipmentRequirement.M => (Meta.M)this.MetaPopulation;

        public EquipmentRequirementEquipmentClass EquipmentClass;
        Meta.EquipmentRequirementEquipmentClass Meta.EquipmentRequirement.EquipmentClass => this.EquipmentClass;
        public EquipmentRequirementEquipment Equipment;
        Meta.EquipmentRequirementEquipment Meta.EquipmentRequirement.Equipment => this.Equipment;
        public EquipmentRequirementQuantity Quantity;
        Meta.EquipmentRequirementQuantity Meta.EquipmentRequirement.Quantity => this.Quantity;
        public EquipmentRequirementDescription Description;
        Meta.EquipmentRequirementDescription Meta.EquipmentRequirement.Description => this.Description;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.EquipmentRequirement.UniqueId => UniqueId;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.EquipmentRequirement.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.EquipmentRequirement.SecurityTokens => SecurityTokens;


        public JobOrderWhereEquipmentRequirement JobOrderWhereEquipmentRequirement;
        Meta.JobOrderWhereEquipmentRequirement Meta.EquipmentRequirement.JobOrderWhereEquipmentRequirement => this.JobOrderWhereEquipmentRequirement;
        public OperationsSegmentWhereEquipmentSpecification OperationsSegmentWhereEquipmentSpecification;
        Meta.OperationsSegmentWhereEquipmentSpecification Meta.EquipmentRequirement.OperationsSegmentWhereEquipmentSpecification => this.OperationsSegmentWhereEquipmentSpecification;
        public WorkMasterWhereEquipmentSpecification WorkMasterWhereEquipmentSpecification;
        Meta.WorkMasterWhereEquipmentSpecification Meta.EquipmentRequirement.WorkMasterWhereEquipmentSpecification => this.WorkMasterWhereEquipmentSpecification;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.EquipmentRequirement.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.EquipmentRequirement.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.EquipmentRequirement.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.EquipmentRequirement.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.EquipmentRequirement.OnPostDerive => this.OnPostDerive;
        public MethodType Delete;
        IMethodType Meta.EquipmentRequirement.Delete => this.Delete;
    }
    public partial class HierarchyScope : Class, Meta.HierarchyScope {
        public HierarchyScope(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.HierarchyScope.M => (Meta.M)this.MetaPopulation;

        public HierarchyScopeScopedEquipment ScopedEquipment;
        Meta.HierarchyScopeScopedEquipment Meta.HierarchyScope.ScopedEquipment => this.ScopedEquipment;
        public HierarchyScopeEquipmentLevel EquipmentLevel;
        Meta.HierarchyScopeEquipmentLevel Meta.HierarchyScope.EquipmentLevel => this.EquipmentLevel;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.HierarchyScope.UniqueId => UniqueId;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.HierarchyScope.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.HierarchyScope.SecurityTokens => SecurityTokens;


        public EquipmentsWhereHierarchyScope EquipmentsWhereHierarchyScope;
        Meta.EquipmentsWhereHierarchyScope Meta.HierarchyScope.EquipmentsWhereHierarchyScope => this.EquipmentsWhereHierarchyScope;
        public JobOrdersWhereHierarchyScope JobOrdersWhereHierarchyScope;
        Meta.JobOrdersWhereHierarchyScope Meta.HierarchyScope.JobOrdersWhereHierarchyScope => this.JobOrdersWhereHierarchyScope;
        public OperationsDefinitionsWhereHierarchyScope OperationsDefinitionsWhereHierarchyScope;
        Meta.OperationsDefinitionsWhereHierarchyScope Meta.HierarchyScope.OperationsDefinitionsWhereHierarchyScope => this.OperationsDefinitionsWhereHierarchyScope;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.HierarchyScope.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.HierarchyScope.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.HierarchyScope.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.HierarchyScope.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.HierarchyScope.OnPostDerive => this.OnPostDerive;
        public MethodType Delete;
        IMethodType Meta.HierarchyScope.Delete => this.Delete;
    }
    public partial class JobOrder : Class, Meta.JobOrder {
        public JobOrder(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.JobOrder.M => (Meta.M)this.MetaPopulation;

        public JobOrderName Name;
        Meta.JobOrderName Meta.JobOrder.Name => this.Name;
        public JobOrderDescription Description;
        Meta.JobOrderDescription Meta.JobOrder.Description => this.Description;
        public JobOrderWorkType WorkType;
        Meta.JobOrderWorkType Meta.JobOrder.WorkType => this.WorkType;
        public JobOrderWorkMaster WorkMaster;
        Meta.JobOrderWorkMaster Meta.JobOrder.WorkMaster => this.WorkMaster;
        public JobOrderEquipment Equipment;
        Meta.JobOrderEquipment Meta.JobOrder.Equipment => this.Equipment;
        public JobOrderPriority Priority;
        Meta.JobOrderPriority Meta.JobOrder.Priority => this.Priority;
        public JobOrderDispatchStatus DispatchStatus;
        Meta.JobOrderDispatchStatus Meta.JobOrder.DispatchStatus => this.DispatchStatus;
        public JobOrderStartTime StartTime;
        Meta.JobOrderStartTime Meta.JobOrder.StartTime => this.StartTime;
        public JobOrderEndTime EndTime;
        Meta.JobOrderEndTime Meta.JobOrder.EndTime => this.EndTime;
        public JobOrderHierarchyScope HierarchyScope;
        Meta.JobOrderHierarchyScope Meta.JobOrder.HierarchyScope => this.HierarchyScope;
        public JobOrderPersonnelRequirements PersonnelRequirements;
        Meta.JobOrderPersonnelRequirements Meta.JobOrder.PersonnelRequirements => this.PersonnelRequirements;
        public JobOrderEquipmentRequirements EquipmentRequirements;
        Meta.JobOrderEquipmentRequirements Meta.JobOrder.EquipmentRequirements => this.EquipmentRequirements;
        public JobOrderMaterialRequirements MaterialRequirements;
        Meta.JobOrderMaterialRequirements Meta.JobOrder.MaterialRequirements => this.MaterialRequirements;
        public JobOrderAssignedTo AssignedTo;
        Meta.JobOrderAssignedTo Meta.JobOrder.AssignedTo => this.AssignedTo;
        public JobOrderResponse Response;
        Meta.JobOrderResponse Meta.JobOrder.Response => this.Response;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.JobOrder.UniqueId => UniqueId;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.JobOrder.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.JobOrder.SecurityTokens => SecurityTokens;


        public JobResponsesWhereJobOrder JobResponsesWhereJobOrder;
        Meta.JobResponsesWhereJobOrder Meta.JobOrder.JobResponsesWhereJobOrder => this.JobResponsesWhereJobOrder;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.JobOrder.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.JobOrder.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.JobOrder.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.JobOrder.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.JobOrder.OnPostDerive => this.OnPostDerive;
        public MethodType Delete;
        IMethodType Meta.JobOrder.Delete => this.Delete;
    }
    public partial class JobResponse : Class, Meta.JobResponse {
        public JobResponse(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.JobResponse.M => (Meta.M)this.MetaPopulation;

        public JobResponseDescription Description;
        Meta.JobResponseDescription Meta.JobResponse.Description => this.Description;
        public JobResponseWorkType WorkType;
        Meta.JobResponseWorkType Meta.JobResponse.WorkType => this.WorkType;
        public JobResponseJobOrder JobOrder;
        Meta.JobResponseJobOrder Meta.JobResponse.JobOrder => this.JobOrder;
        public JobResponseStartTime StartTime;
        Meta.JobResponseStartTime Meta.JobResponse.StartTime => this.StartTime;
        public JobResponseEndTime EndTime;
        Meta.JobResponseEndTime Meta.JobResponse.EndTime => this.EndTime;
        public JobResponseJobState JobState;
        Meta.JobResponseJobState Meta.JobResponse.JobState => this.JobState;
        public JobResponsePersonnelActuals PersonnelActuals;
        Meta.JobResponsePersonnelActuals Meta.JobResponse.PersonnelActuals => this.PersonnelActuals;
        public JobResponseEquipmentActuals EquipmentActuals;
        Meta.JobResponseEquipmentActuals Meta.JobResponse.EquipmentActuals => this.EquipmentActuals;
        public JobResponseMaterialActuals MaterialActuals;
        Meta.JobResponseMaterialActuals Meta.JobResponse.MaterialActuals => this.MaterialActuals;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.JobResponse.UniqueId => UniqueId;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.JobResponse.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.JobResponse.SecurityTokens => SecurityTokens;


        public JobOrderWhereResponse JobOrderWhereResponse;
        Meta.JobOrderWhereResponse Meta.JobResponse.JobOrderWhereResponse => this.JobOrderWhereResponse;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.JobResponse.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.JobResponse.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.JobResponse.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.JobResponse.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.JobResponse.OnPostDerive => this.OnPostDerive;
        public MethodType Delete;
        IMethodType Meta.JobResponse.Delete => this.Delete;
    }
    public partial class MaterialActual : Class, Meta.MaterialActual {
        public MaterialActual(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.MaterialActual.M => (Meta.M)this.MetaPopulation;

        public MaterialActualName Name;
        Meta.MaterialActualName Meta.MaterialActual.Name => this.Name;
        public MaterialActualQuantity Quantity;
        Meta.MaterialActualQuantity Meta.MaterialActual.Quantity => this.Quantity;
        public MaterialActualDescription Description;
        Meta.MaterialActualDescription Meta.MaterialActual.Description => this.Description;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.MaterialActual.UniqueId => UniqueId;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.MaterialActual.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.MaterialActual.SecurityTokens => SecurityTokens;


        public JobResponseWhereMaterialActual JobResponseWhereMaterialActual;
        Meta.JobResponseWhereMaterialActual Meta.MaterialActual.JobResponseWhereMaterialActual => this.JobResponseWhereMaterialActual;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.MaterialActual.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.MaterialActual.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.MaterialActual.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.MaterialActual.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.MaterialActual.OnPostDerive => this.OnPostDerive;
        public MethodType Delete;
        IMethodType Meta.MaterialActual.Delete => this.Delete;
    }
    public partial class MaterialRequirement : Class, Meta.MaterialRequirement {
        public MaterialRequirement(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.MaterialRequirement.M => (Meta.M)this.MetaPopulation;

        public MaterialRequirementName Name;
        Meta.MaterialRequirementName Meta.MaterialRequirement.Name => this.Name;
        public MaterialRequirementQuantity Quantity;
        Meta.MaterialRequirementQuantity Meta.MaterialRequirement.Quantity => this.Quantity;
        public MaterialRequirementDescription Description;
        Meta.MaterialRequirementDescription Meta.MaterialRequirement.Description => this.Description;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.MaterialRequirement.UniqueId => UniqueId;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.MaterialRequirement.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.MaterialRequirement.SecurityTokens => SecurityTokens;


        public JobOrderWhereMaterialRequirement JobOrderWhereMaterialRequirement;
        Meta.JobOrderWhereMaterialRequirement Meta.MaterialRequirement.JobOrderWhereMaterialRequirement => this.JobOrderWhereMaterialRequirement;
        public OperationsSegmentWhereMaterialSpecification OperationsSegmentWhereMaterialSpecification;
        Meta.OperationsSegmentWhereMaterialSpecification Meta.MaterialRequirement.OperationsSegmentWhereMaterialSpecification => this.OperationsSegmentWhereMaterialSpecification;
        public WorkMasterWhereMaterialSpecification WorkMasterWhereMaterialSpecification;
        Meta.WorkMasterWhereMaterialSpecification Meta.MaterialRequirement.WorkMasterWhereMaterialSpecification => this.WorkMasterWhereMaterialSpecification;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.MaterialRequirement.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.MaterialRequirement.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.MaterialRequirement.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.MaterialRequirement.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.MaterialRequirement.OnPostDerive => this.OnPostDerive;
        public MethodType Delete;
        IMethodType Meta.MaterialRequirement.Delete => this.Delete;
    }
    public partial class OperationsDefinition : Class, Meta.OperationsDefinition {
        public OperationsDefinition(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.OperationsDefinition.M => (Meta.M)this.MetaPopulation;

        public OperationsDefinitionName Name;
        Meta.OperationsDefinitionName Meta.OperationsDefinition.Name => this.Name;
        public OperationsDefinitionDescription Description;
        Meta.OperationsDefinitionDescription Meta.OperationsDefinition.Description => this.Description;
        public OperationsDefinitionVersion Version;
        Meta.OperationsDefinitionVersion Meta.OperationsDefinition.Version => this.Version;
        public OperationsDefinitionOperationsType OperationsType;
        Meta.OperationsDefinitionOperationsType Meta.OperationsDefinition.OperationsType => this.OperationsType;
        public OperationsDefinitionOperationsSegments OperationsSegments;
        Meta.OperationsDefinitionOperationsSegments Meta.OperationsDefinition.OperationsSegments => this.OperationsSegments;
        public OperationsDefinitionEffectiveStartDate EffectiveStartDate;
        Meta.OperationsDefinitionEffectiveStartDate Meta.OperationsDefinition.EffectiveStartDate => this.EffectiveStartDate;
        public OperationsDefinitionEffectiveEndDate EffectiveEndDate;
        Meta.OperationsDefinitionEffectiveEndDate Meta.OperationsDefinition.EffectiveEndDate => this.EffectiveEndDate;
        public OperationsDefinitionHierarchyScope HierarchyScope;
        Meta.OperationsDefinitionHierarchyScope Meta.OperationsDefinition.HierarchyScope => this.HierarchyScope;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.OperationsDefinition.UniqueId => UniqueId;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.OperationsDefinition.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.OperationsDefinition.SecurityTokens => SecurityTokens;


        public WorkMastersWhereOperationsDefinition WorkMastersWhereOperationsDefinition;
        Meta.WorkMastersWhereOperationsDefinition Meta.OperationsDefinition.WorkMastersWhereOperationsDefinition => this.WorkMastersWhereOperationsDefinition;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.OperationsDefinition.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.OperationsDefinition.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.OperationsDefinition.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.OperationsDefinition.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.OperationsDefinition.OnPostDerive => this.OnPostDerive;
        public MethodType Delete;
        IMethodType Meta.OperationsDefinition.Delete => this.Delete;
    }
    public partial class OperationsSegment : Class, Meta.OperationsSegment {
        public OperationsSegment(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.OperationsSegment.M => (Meta.M)this.MetaPopulation;

        public OperationsSegmentName Name;
        Meta.OperationsSegmentName Meta.OperationsSegment.Name => this.Name;
        public OperationsSegmentDescription Description;
        Meta.OperationsSegmentDescription Meta.OperationsSegment.Description => this.Description;
        public OperationsSegmentDuration Duration;
        Meta.OperationsSegmentDuration Meta.OperationsSegment.Duration => this.Duration;
        public OperationsSegmentOperationsType OperationsType;
        Meta.OperationsSegmentOperationsType Meta.OperationsSegment.OperationsType => this.OperationsType;
        public OperationsSegmentPersonnelSpecifications PersonnelSpecifications;
        Meta.OperationsSegmentPersonnelSpecifications Meta.OperationsSegment.PersonnelSpecifications => this.PersonnelSpecifications;
        public OperationsSegmentEquipmentSpecifications EquipmentSpecifications;
        Meta.OperationsSegmentEquipmentSpecifications Meta.OperationsSegment.EquipmentSpecifications => this.EquipmentSpecifications;
        public OperationsSegmentMaterialSpecifications MaterialSpecifications;
        Meta.OperationsSegmentMaterialSpecifications Meta.OperationsSegment.MaterialSpecifications => this.MaterialSpecifications;
        public OperationsSegmentOperationsSegmentChildren OperationsSegmentChildren;
        Meta.OperationsSegmentOperationsSegmentChildren Meta.OperationsSegment.OperationsSegmentChildren => this.OperationsSegmentChildren;
        public OperationsSegmentOperationsSegmentParent OperationsSegmentParent;
        Meta.OperationsSegmentOperationsSegmentParent Meta.OperationsSegment.OperationsSegmentParent => this.OperationsSegmentParent;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.OperationsSegment.UniqueId => UniqueId;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.OperationsSegment.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.OperationsSegment.SecurityTokens => SecurityTokens;


        public OperationsDefinitionWhereOperationsSegment OperationsDefinitionWhereOperationsSegment;
        Meta.OperationsDefinitionWhereOperationsSegment Meta.OperationsSegment.OperationsDefinitionWhereOperationsSegment => this.OperationsDefinitionWhereOperationsSegment;
        public OperationsSegmentWhereOperationsSegmentChild OperationsSegmentWhereOperationsSegmentChild;
        Meta.OperationsSegmentWhereOperationsSegmentChild Meta.OperationsSegment.OperationsSegmentWhereOperationsSegmentChild => this.OperationsSegmentWhereOperationsSegmentChild;
        public OperationsSegmentsWhereOperationsSegmentParent OperationsSegmentsWhereOperationsSegmentParent;
        Meta.OperationsSegmentsWhereOperationsSegmentParent Meta.OperationsSegment.OperationsSegmentsWhereOperationsSegmentParent => this.OperationsSegmentsWhereOperationsSegmentParent;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.OperationsSegment.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.OperationsSegment.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.OperationsSegment.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.OperationsSegment.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.OperationsSegment.OnPostDerive => this.OnPostDerive;
        public MethodType Delete;
        IMethodType Meta.OperationsSegment.Delete => this.Delete;
    }
    public partial class OperationsType : Class, Meta.OperationsType {
        public OperationsType(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.OperationsType.M => (Meta.M)this.MetaPopulation;

        public OperationsTypeName Name;
        Meta.OperationsTypeName Meta.OperationsType.Name => this.Name;
        public OperationsTypeIsActive IsActive;
        Meta.OperationsTypeIsActive Meta.OperationsType.IsActive => this.IsActive;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.OperationsType.UniqueId => UniqueId;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.OperationsType.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.OperationsType.SecurityTokens => SecurityTokens;


        public JobOrdersWhereWorkType JobOrdersWhereWorkType;
        Meta.JobOrdersWhereWorkType Meta.OperationsType.JobOrdersWhereWorkType => this.JobOrdersWhereWorkType;
        public JobResponsesWhereWorkType JobResponsesWhereWorkType;
        Meta.JobResponsesWhereWorkType Meta.OperationsType.JobResponsesWhereWorkType => this.JobResponsesWhereWorkType;
        public OperationsDefinitionsWhereOperationsType OperationsDefinitionsWhereOperationsType;
        Meta.OperationsDefinitionsWhereOperationsType Meta.OperationsType.OperationsDefinitionsWhereOperationsType => this.OperationsDefinitionsWhereOperationsType;
        public OperationsSegmentsWhereOperationsType OperationsSegmentsWhereOperationsType;
        Meta.OperationsSegmentsWhereOperationsType Meta.OperationsType.OperationsSegmentsWhereOperationsType => this.OperationsSegmentsWhereOperationsType;
        public WorkMastersWhereWorkType WorkMastersWhereWorkType;
        Meta.WorkMastersWhereWorkType Meta.OperationsType.WorkMastersWhereWorkType => this.WorkMastersWhereWorkType;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.OperationsType.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.OperationsType.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.OperationsType.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.OperationsType.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.OperationsType.OnPostDerive => this.OnPostDerive;
    }
    public partial class Person : Class, Meta.Person {
        public Person(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.Person.M => (Meta.M)this.MetaPopulation;

        public PersonFirstName FirstName;
        Meta.PersonFirstName Meta.Person.FirstName => this.FirstName;
        public PersonLastName LastName;
        Meta.PersonLastName Meta.Person.LastName => this.LastName;
        public PersonUser User;
        Meta.PersonUser Meta.Person.User => this.User;
        public PersonPersonnelClasses PersonnelClasses;
        Meta.PersonPersonnelClasses Meta.Person.PersonnelClasses => this.PersonnelClasses;
        public PersonPersonProperties PersonProperties;
        Meta.PersonPersonProperties Meta.Person.PersonProperties => this.PersonProperties;
        public PersonDisplayName DisplayName;
        Meta.PersonDisplayName Meta.Person.DisplayName => this.DisplayName;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.Person.UniqueId => UniqueId;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.Person.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.Person.SecurityTokens => SecurityTokens;


        public JobOrdersWhereAssignedTo JobOrdersWhereAssignedTo;
        Meta.JobOrdersWhereAssignedTo Meta.Person.JobOrdersWhereAssignedTo => this.JobOrdersWhereAssignedTo;
        public PersonnelActualsWherePerson PersonnelActualsWherePerson;
        Meta.PersonnelActualsWherePerson Meta.Person.PersonnelActualsWherePerson => this.PersonnelActualsWherePerson;
        public PersonnelRequirementsWherePerson PersonnelRequirementsWherePerson;
        Meta.PersonnelRequirementsWherePerson Meta.Person.PersonnelRequirementsWherePerson => this.PersonnelRequirementsWherePerson;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.Person.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.Person.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.Person.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.Person.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.Person.OnPostDerive => this.OnPostDerive;
        public MethodType Delete;
        IMethodType Meta.Person.Delete => this.Delete;
    }
    public partial class PersonnelActual : Class, Meta.PersonnelActual {
        public PersonnelActual(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.PersonnelActual.M => (Meta.M)this.MetaPopulation;

        public PersonnelActualPerson Person;
        Meta.PersonnelActualPerson Meta.PersonnelActual.Person => this.Person;
        public PersonnelActualPersonnelClass PersonnelClass;
        Meta.PersonnelActualPersonnelClass Meta.PersonnelActual.PersonnelClass => this.PersonnelClass;
        public PersonnelActualDescription Description;
        Meta.PersonnelActualDescription Meta.PersonnelActual.Description => this.Description;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.PersonnelActual.UniqueId => UniqueId;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.PersonnelActual.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.PersonnelActual.SecurityTokens => SecurityTokens;


        public JobResponseWherePersonnelActual JobResponseWherePersonnelActual;
        Meta.JobResponseWherePersonnelActual Meta.PersonnelActual.JobResponseWherePersonnelActual => this.JobResponseWherePersonnelActual;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.PersonnelActual.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.PersonnelActual.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.PersonnelActual.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.PersonnelActual.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.PersonnelActual.OnPostDerive => this.OnPostDerive;
        public MethodType Delete;
        IMethodType Meta.PersonnelActual.Delete => this.Delete;
    }
    public partial class PersonnelClass : Class, Meta.PersonnelClass {
        public PersonnelClass(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.PersonnelClass.M => (Meta.M)this.MetaPopulation;

        public PersonnelClassName Name;
        Meta.PersonnelClassName Meta.PersonnelClass.Name => this.Name;
        public PersonnelClassDescription Description;
        Meta.PersonnelClassDescription Meta.PersonnelClass.Description => this.Description;
        public PersonnelClassPersonnelClassProperties PersonnelClassProperties;
        Meta.PersonnelClassPersonnelClassProperties Meta.PersonnelClass.PersonnelClassProperties => this.PersonnelClassProperties;
        public PersonnelClassPersonnelClassParent PersonnelClassParent;
        Meta.PersonnelClassPersonnelClassParent Meta.PersonnelClass.PersonnelClassParent => this.PersonnelClassParent;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.PersonnelClass.UniqueId => UniqueId;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.PersonnelClass.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.PersonnelClass.SecurityTokens => SecurityTokens;


        public PeopleWherePersonnelClass PeopleWherePersonnelClass;
        Meta.PeopleWherePersonnelClass Meta.PersonnelClass.PeopleWherePersonnelClass => this.PeopleWherePersonnelClass;
        public PersonnelActualsWherePersonnelClass PersonnelActualsWherePersonnelClass;
        Meta.PersonnelActualsWherePersonnelClass Meta.PersonnelClass.PersonnelActualsWherePersonnelClass => this.PersonnelActualsWherePersonnelClass;
        public PersonnelClassesWherePersonnelClassParent PersonnelClassesWherePersonnelClassParent;
        Meta.PersonnelClassesWherePersonnelClassParent Meta.PersonnelClass.PersonnelClassesWherePersonnelClassParent => this.PersonnelClassesWherePersonnelClassParent;
        public PersonnelRequirementsWherePersonnelClass PersonnelRequirementsWherePersonnelClass;
        Meta.PersonnelRequirementsWherePersonnelClass Meta.PersonnelClass.PersonnelRequirementsWherePersonnelClass => this.PersonnelRequirementsWherePersonnelClass;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.PersonnelClass.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.PersonnelClass.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.PersonnelClass.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.PersonnelClass.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.PersonnelClass.OnPostDerive => this.OnPostDerive;
        public MethodType Delete;
        IMethodType Meta.PersonnelClass.Delete => this.Delete;
    }
    public partial class PersonnelClassProperty : Class, Meta.PersonnelClassProperty {
        public PersonnelClassProperty(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.PersonnelClassProperty.M => (Meta.M)this.MetaPopulation;

        public PersonnelClassPropertyName Name;
        Meta.PersonnelClassPropertyName Meta.PersonnelClassProperty.Name => this.Name;
        public PersonnelClassPropertyDescription Description;
        Meta.PersonnelClassPropertyDescription Meta.PersonnelClassProperty.Description => this.Description;
        public PersonnelClassPropertyDefaultValue DefaultValue;
        Meta.PersonnelClassPropertyDefaultValue Meta.PersonnelClassProperty.DefaultValue => this.DefaultValue;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.PersonnelClassProperty.UniqueId => UniqueId;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.PersonnelClassProperty.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.PersonnelClassProperty.SecurityTokens => SecurityTokens;


        public PersonnelClassWherePersonnelClassProperty PersonnelClassWherePersonnelClassProperty;
        Meta.PersonnelClassWherePersonnelClassProperty Meta.PersonnelClassProperty.PersonnelClassWherePersonnelClassProperty => this.PersonnelClassWherePersonnelClassProperty;
        public PersonPropertiesWherePersonnelClassProperty PersonPropertiesWherePersonnelClassProperty;
        Meta.PersonPropertiesWherePersonnelClassProperty Meta.PersonnelClassProperty.PersonPropertiesWherePersonnelClassProperty => this.PersonPropertiesWherePersonnelClassProperty;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.PersonnelClassProperty.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.PersonnelClassProperty.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.PersonnelClassProperty.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.PersonnelClassProperty.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.PersonnelClassProperty.OnPostDerive => this.OnPostDerive;
        public MethodType Delete;
        IMethodType Meta.PersonnelClassProperty.Delete => this.Delete;
    }
    public partial class PersonnelRequirement : Class, Meta.PersonnelRequirement {
        public PersonnelRequirement(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.PersonnelRequirement.M => (Meta.M)this.MetaPopulation;

        public PersonnelRequirementPersonnelClass PersonnelClass;
        Meta.PersonnelRequirementPersonnelClass Meta.PersonnelRequirement.PersonnelClass => this.PersonnelClass;
        public PersonnelRequirementPerson Person;
        Meta.PersonnelRequirementPerson Meta.PersonnelRequirement.Person => this.Person;
        public PersonnelRequirementQuantity Quantity;
        Meta.PersonnelRequirementQuantity Meta.PersonnelRequirement.Quantity => this.Quantity;
        public PersonnelRequirementDescription Description;
        Meta.PersonnelRequirementDescription Meta.PersonnelRequirement.Description => this.Description;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.PersonnelRequirement.UniqueId => UniqueId;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.PersonnelRequirement.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.PersonnelRequirement.SecurityTokens => SecurityTokens;


        public JobOrderWherePersonnelRequirement JobOrderWherePersonnelRequirement;
        Meta.JobOrderWherePersonnelRequirement Meta.PersonnelRequirement.JobOrderWherePersonnelRequirement => this.JobOrderWherePersonnelRequirement;
        public OperationsSegmentWherePersonnelSpecification OperationsSegmentWherePersonnelSpecification;
        Meta.OperationsSegmentWherePersonnelSpecification Meta.PersonnelRequirement.OperationsSegmentWherePersonnelSpecification => this.OperationsSegmentWherePersonnelSpecification;
        public WorkMasterWherePersonnelSpecification WorkMasterWherePersonnelSpecification;
        Meta.WorkMasterWherePersonnelSpecification Meta.PersonnelRequirement.WorkMasterWherePersonnelSpecification => this.WorkMasterWherePersonnelSpecification;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.PersonnelRequirement.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.PersonnelRequirement.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.PersonnelRequirement.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.PersonnelRequirement.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.PersonnelRequirement.OnPostDerive => this.OnPostDerive;
        public MethodType Delete;
        IMethodType Meta.PersonnelRequirement.Delete => this.Delete;
    }
    public partial class PersonProperty : Class, Meta.PersonProperty {
        public PersonProperty(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.PersonProperty.M => (Meta.M)this.MetaPopulation;

        public PersonPropertyName Name;
        Meta.PersonPropertyName Meta.PersonProperty.Name => this.Name;
        public PersonPropertyValue Value;
        Meta.PersonPropertyValue Meta.PersonProperty.Value => this.Value;
        public PersonPropertyPersonnelClassProperty PersonnelClassProperty;
        Meta.PersonPropertyPersonnelClassProperty Meta.PersonProperty.PersonnelClassProperty => this.PersonnelClassProperty;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.PersonProperty.UniqueId => UniqueId;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.PersonProperty.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.PersonProperty.SecurityTokens => SecurityTokens;


        public PersonWherePersonProperty PersonWherePersonProperty;
        Meta.PersonWherePersonProperty Meta.PersonProperty.PersonWherePersonProperty => this.PersonWherePersonProperty;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.PersonProperty.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.PersonProperty.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.PersonProperty.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.PersonProperty.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.PersonProperty.OnPostDerive => this.OnPostDerive;
        public MethodType Delete;
        IMethodType Meta.PersonProperty.Delete => this.Delete;
    }
    public partial class PhysicalAsset : Class, Meta.PhysicalAsset {
        public PhysicalAsset(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.PhysicalAsset.M => (Meta.M)this.MetaPopulation;

        public PhysicalAssetName Name;
        Meta.PhysicalAssetName Meta.PhysicalAsset.Name => this.Name;
        public PhysicalAssetDescription Description;
        Meta.PhysicalAssetDescription Meta.PhysicalAsset.Description => this.Description;
        public PhysicalAssetSerialNumber SerialNumber;
        Meta.PhysicalAssetSerialNumber Meta.PhysicalAsset.SerialNumber => this.SerialNumber;
        public PhysicalAssetManufacturer Manufacturer;
        Meta.PhysicalAssetManufacturer Meta.PhysicalAsset.Manufacturer => this.Manufacturer;
        public PhysicalAssetModelNumber ModelNumber;
        Meta.PhysicalAssetModelNumber Meta.PhysicalAsset.ModelNumber => this.ModelNumber;
        public PhysicalAssetInstallationDate InstallationDate;
        Meta.PhysicalAssetInstallationDate Meta.PhysicalAsset.InstallationDate => this.InstallationDate;
        public PhysicalAssetPhysicalAssetProperties PhysicalAssetProperties;
        Meta.PhysicalAssetPhysicalAssetProperties Meta.PhysicalAsset.PhysicalAssetProperties => this.PhysicalAssetProperties;
        public PhysicalAssetPhysicalAssetChildren PhysicalAssetChildren;
        Meta.PhysicalAssetPhysicalAssetChildren Meta.PhysicalAsset.PhysicalAssetChildren => this.PhysicalAssetChildren;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.PhysicalAsset.UniqueId => UniqueId;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.PhysicalAsset.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.PhysicalAsset.SecurityTokens => SecurityTokens;


        public EquipmentsWherePhysicalAsset EquipmentsWherePhysicalAsset;
        Meta.EquipmentsWherePhysicalAsset Meta.PhysicalAsset.EquipmentsWherePhysicalAsset => this.EquipmentsWherePhysicalAsset;
        public PhysicalAssetWherePhysicalAssetChild PhysicalAssetWherePhysicalAssetChild;
        Meta.PhysicalAssetWherePhysicalAssetChild Meta.PhysicalAsset.PhysicalAssetWherePhysicalAssetChild => this.PhysicalAssetWherePhysicalAssetChild;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.PhysicalAsset.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.PhysicalAsset.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.PhysicalAsset.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.PhysicalAsset.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.PhysicalAsset.OnPostDerive => this.OnPostDerive;
        public MethodType Delete;
        IMethodType Meta.PhysicalAsset.Delete => this.Delete;
    }
    public partial class PhysicalAssetProperty : Class, Meta.PhysicalAssetProperty {
        public PhysicalAssetProperty(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.PhysicalAssetProperty.M => (Meta.M)this.MetaPopulation;

        public PhysicalAssetPropertyName Name;
        Meta.PhysicalAssetPropertyName Meta.PhysicalAssetProperty.Name => this.Name;
        public PhysicalAssetPropertyValue Value;
        Meta.PhysicalAssetPropertyValue Meta.PhysicalAssetProperty.Value => this.Value;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.PhysicalAssetProperty.UniqueId => UniqueId;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.PhysicalAssetProperty.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.PhysicalAssetProperty.SecurityTokens => SecurityTokens;


        public PhysicalAssetWherePhysicalAssetProperty PhysicalAssetWherePhysicalAssetProperty;
        Meta.PhysicalAssetWherePhysicalAssetProperty Meta.PhysicalAssetProperty.PhysicalAssetWherePhysicalAssetProperty => this.PhysicalAssetWherePhysicalAssetProperty;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.PhysicalAssetProperty.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.PhysicalAssetProperty.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.PhysicalAssetProperty.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.PhysicalAssetProperty.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.PhysicalAssetProperty.OnPostDerive => this.OnPostDerive;
        public MethodType Delete;
        IMethodType Meta.PhysicalAssetProperty.Delete => this.Delete;
    }
    public partial class WorkMaster : Class, Meta.WorkMaster {
        public WorkMaster(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.WorkMaster.M => (Meta.M)this.MetaPopulation;

        public WorkMasterName Name;
        Meta.WorkMasterName Meta.WorkMaster.Name => this.Name;
        public WorkMasterDescription Description;
        Meta.WorkMasterDescription Meta.WorkMaster.Description => this.Description;
        public WorkMasterVersion Version;
        Meta.WorkMasterVersion Meta.WorkMaster.Version => this.Version;
        public WorkMasterWorkType WorkType;
        Meta.WorkMasterWorkType Meta.WorkMaster.WorkType => this.WorkType;
        public WorkMasterDuration Duration;
        Meta.WorkMasterDuration Meta.WorkMaster.Duration => this.Duration;
        public WorkMasterOperationsDefinition OperationsDefinition;
        Meta.WorkMasterOperationsDefinition Meta.WorkMaster.OperationsDefinition => this.OperationsDefinition;
        public WorkMasterPersonnelSpecifications PersonnelSpecifications;
        Meta.WorkMasterPersonnelSpecifications Meta.WorkMaster.PersonnelSpecifications => this.PersonnelSpecifications;
        public WorkMasterEquipmentSpecifications EquipmentSpecifications;
        Meta.WorkMasterEquipmentSpecifications Meta.WorkMaster.EquipmentSpecifications => this.EquipmentSpecifications;
        public WorkMasterMaterialSpecifications MaterialSpecifications;
        Meta.WorkMasterMaterialSpecifications Meta.WorkMaster.MaterialSpecifications => this.MaterialSpecifications;
        public WorkMasterWorkMasterChildren WorkMasterChildren;
        Meta.WorkMasterWorkMasterChildren Meta.WorkMaster.WorkMasterChildren => this.WorkMasterChildren;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.WorkMaster.UniqueId => UniqueId;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.WorkMaster.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.WorkMaster.SecurityTokens => SecurityTokens;


        public JobOrdersWhereWorkMaster JobOrdersWhereWorkMaster;
        Meta.JobOrdersWhereWorkMaster Meta.WorkMaster.JobOrdersWhereWorkMaster => this.JobOrdersWhereWorkMaster;
        public WorkMasterWhereWorkMasterChild WorkMasterWhereWorkMasterChild;
        Meta.WorkMasterWhereWorkMasterChild Meta.WorkMaster.WorkMasterWhereWorkMasterChild => this.WorkMasterWhereWorkMasterChild;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.WorkMaster.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.WorkMaster.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.WorkMaster.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.WorkMaster.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.WorkMaster.OnPostDerive => this.OnPostDerive;
        public MethodType Delete;
        IMethodType Meta.WorkMaster.Delete => this.Delete;
    }
    public partial class Grant : Class, Meta.Grant {
        public Grant(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.Grant.M => (Meta.M)this.MetaPopulation;

        public GrantSubjectGroups SubjectGroups;
        Meta.GrantSubjectGroups Meta.Grant.SubjectGroups => this.SubjectGroups;
        public GrantSubjects Subjects;
        Meta.GrantSubjects Meta.Grant.Subjects => this.Subjects;
        public GrantRole Role;
        Meta.GrantRole Meta.Grant.Role => this.Role;
        public GrantEffectivePermissions EffectivePermissions;
        Meta.GrantEffectivePermissions Meta.Grant.EffectivePermissions => this.EffectivePermissions;
        public GrantEffectiveUsers EffectiveUsers;
        Meta.GrantEffectiveUsers Meta.Grant.EffectiveUsers => this.EffectiveUsers;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.Grant.UniqueId => UniqueId;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.Grant.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.Grant.SecurityTokens => SecurityTokens;


        public SecurityTokensWhereGrant SecurityTokensWhereGrant;
        Meta.SecurityTokensWhereGrant Meta.Grant.SecurityTokensWhereGrant => this.SecurityTokensWhereGrant;
        public SecurityTokenOwnerWhereOwnerGrant SecurityTokenOwnerWhereOwnerGrant;
        Meta.SecurityTokenOwnerWhereOwnerGrant Meta.Grant.SecurityTokenOwnerWhereOwnerGrant => this.SecurityTokenOwnerWhereOwnerGrant;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.Grant.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.Grant.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.Grant.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.Grant.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.Grant.OnPostDerive => this.OnPostDerive;
        public MethodType Delete;
        IMethodType Meta.Grant.Delete => this.Delete;
    }
    public partial class CreatePermission : Class, Meta.CreatePermission {
        public CreatePermission(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.CreatePermission.M => (Meta.M)this.MetaPopulation;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.CreatePermission.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.CreatePermission.SecurityTokens => SecurityTokens;


        public PermissionClassPointer ClassPointer;
        Meta.PermissionClassPointer Meta.CreatePermission.ClassPointer => ClassPointer;



        public GrantsWhereEffectivePermission GrantsWhereEffectivePermission;
        Meta.GrantsWhereEffectivePermission Meta.CreatePermission.GrantsWhereEffectivePermission => this.GrantsWhereEffectivePermission ;
        public RevocationsWhereDeniedPermission RevocationsWhereDeniedPermission;
        Meta.RevocationsWhereDeniedPermission Meta.CreatePermission.RevocationsWhereDeniedPermission => this.RevocationsWhereDeniedPermission ;
        public RolesWherePermission RolesWherePermission;
        Meta.RolesWherePermission Meta.CreatePermission.RolesWherePermission => this.RolesWherePermission ;
        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.CreatePermission.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.CreatePermission.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.CreatePermission.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.CreatePermission.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.CreatePermission.OnPostDerive => this.OnPostDerive;
        public MethodType Delete;
        IMethodType Meta.CreatePermission.Delete => this.Delete;
    }
    public partial class ExecutePermission : Class, Meta.ExecutePermission {
        public ExecutePermission(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.ExecutePermission.M => (Meta.M)this.MetaPopulation;

        public ExecutePermissionMethodTypePointer MethodTypePointer;
        Meta.ExecutePermissionMethodTypePointer Meta.ExecutePermission.MethodTypePointer => this.MethodTypePointer;

        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.ExecutePermission.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.ExecutePermission.SecurityTokens => SecurityTokens;


        public PermissionClassPointer ClassPointer;
        Meta.PermissionClassPointer Meta.ExecutePermission.ClassPointer => ClassPointer;



        public GrantsWhereEffectivePermission GrantsWhereEffectivePermission;
        Meta.GrantsWhereEffectivePermission Meta.ExecutePermission.GrantsWhereEffectivePermission => this.GrantsWhereEffectivePermission ;
        public RevocationsWhereDeniedPermission RevocationsWhereDeniedPermission;
        Meta.RevocationsWhereDeniedPermission Meta.ExecutePermission.RevocationsWhereDeniedPermission => this.RevocationsWhereDeniedPermission ;
        public RolesWherePermission RolesWherePermission;
        Meta.RolesWherePermission Meta.ExecutePermission.RolesWherePermission => this.RolesWherePermission ;
        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.ExecutePermission.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.ExecutePermission.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.ExecutePermission.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.ExecutePermission.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.ExecutePermission.OnPostDerive => this.OnPostDerive;
        public MethodType Delete;
        IMethodType Meta.ExecutePermission.Delete => this.Delete;
    }
    public partial class ReadPermission : Class, Meta.ReadPermission {
        public ReadPermission(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.ReadPermission.M => (Meta.M)this.MetaPopulation;

        public ReadPermissionRelationTypePointer RelationTypePointer;
        Meta.ReadPermissionRelationTypePointer Meta.ReadPermission.RelationTypePointer => this.RelationTypePointer;

        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.ReadPermission.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.ReadPermission.SecurityTokens => SecurityTokens;


        public PermissionClassPointer ClassPointer;
        Meta.PermissionClassPointer Meta.ReadPermission.ClassPointer => ClassPointer;



        public GrantsWhereEffectivePermission GrantsWhereEffectivePermission;
        Meta.GrantsWhereEffectivePermission Meta.ReadPermission.GrantsWhereEffectivePermission => this.GrantsWhereEffectivePermission ;
        public RevocationsWhereDeniedPermission RevocationsWhereDeniedPermission;
        Meta.RevocationsWhereDeniedPermission Meta.ReadPermission.RevocationsWhereDeniedPermission => this.RevocationsWhereDeniedPermission ;
        public RolesWherePermission RolesWherePermission;
        Meta.RolesWherePermission Meta.ReadPermission.RolesWherePermission => this.RolesWherePermission ;
        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.ReadPermission.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.ReadPermission.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.ReadPermission.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.ReadPermission.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.ReadPermission.OnPostDerive => this.OnPostDerive;
        public MethodType Delete;
        IMethodType Meta.ReadPermission.Delete => this.Delete;
    }
    public partial class WritePermission : Class, Meta.WritePermission {
        public WritePermission(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.WritePermission.M => (Meta.M)this.MetaPopulation;

        public WritePermissionRelationTypePointer RelationTypePointer;
        Meta.WritePermissionRelationTypePointer Meta.WritePermission.RelationTypePointer => this.RelationTypePointer;

        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.WritePermission.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.WritePermission.SecurityTokens => SecurityTokens;


        public PermissionClassPointer ClassPointer;
        Meta.PermissionClassPointer Meta.WritePermission.ClassPointer => ClassPointer;



        public GrantsWhereEffectivePermission GrantsWhereEffectivePermission;
        Meta.GrantsWhereEffectivePermission Meta.WritePermission.GrantsWhereEffectivePermission => this.GrantsWhereEffectivePermission ;
        public RevocationsWhereDeniedPermission RevocationsWhereDeniedPermission;
        Meta.RevocationsWhereDeniedPermission Meta.WritePermission.RevocationsWhereDeniedPermission => this.RevocationsWhereDeniedPermission ;
        public RolesWherePermission RolesWherePermission;
        Meta.RolesWherePermission Meta.WritePermission.RolesWherePermission => this.RolesWherePermission ;
        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.WritePermission.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.WritePermission.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.WritePermission.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.WritePermission.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.WritePermission.OnPostDerive => this.OnPostDerive;
        public MethodType Delete;
        IMethodType Meta.WritePermission.Delete => this.Delete;
    }
    public partial class Revocation : Class, Meta.Revocation {
        public Revocation(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.Revocation.M => (Meta.M)this.MetaPopulation;

        public RevocationDeniedPermissions DeniedPermissions;
        Meta.RevocationDeniedPermissions Meta.Revocation.DeniedPermissions => this.DeniedPermissions;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.Revocation.UniqueId => UniqueId;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.Revocation.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.Revocation.SecurityTokens => SecurityTokens;


        public ObjectsWhereRevocation ObjectsWhereRevocation;
        Meta.ObjectsWhereRevocation Meta.Revocation.ObjectsWhereRevocation => this.ObjectsWhereRevocation;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.Revocation.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.Revocation.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.Revocation.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.Revocation.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.Revocation.OnPostDerive => this.OnPostDerive;
        public MethodType Delete;
        IMethodType Meta.Revocation.Delete => this.Delete;
    }
    public partial class Role : Class, Meta.Role {
        public Role(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.Role.M => (Meta.M)this.MetaPopulation;

        public RolePermissions Permissions;
        Meta.RolePermissions Meta.Role.Permissions => this.Permissions;
        public RoleName Name;
        Meta.RoleName Meta.Role.Name => this.Name;

        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.Role.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.Role.SecurityTokens => SecurityTokens;


        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.Role.UniqueId => UniqueId;


        public GrantsWhereRole GrantsWhereRole;
        Meta.GrantsWhereRole Meta.Role.GrantsWhereRole => this.GrantsWhereRole;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.Role.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.Role.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.Role.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.Role.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.Role.OnPostDerive => this.OnPostDerive;
    }
    public partial class SecurityToken : Class, Meta.SecurityToken {
        public SecurityToken(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.SecurityToken.M => (Meta.M)this.MetaPopulation;

        public SecurityTokenGrants Grants;
        Meta.SecurityTokenGrants Meta.SecurityToken.Grants => this.Grants;
        public SecurityTokenSecurityStamp SecurityStamp;
        Meta.SecurityTokenSecurityStamp Meta.SecurityToken.SecurityStamp => this.SecurityStamp;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.SecurityToken.UniqueId => UniqueId;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.SecurityToken.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.SecurityToken.SecurityTokens => SecurityTokens;


        public ObjectsWhereSecurityToken ObjectsWhereSecurityToken;
        Meta.ObjectsWhereSecurityToken Meta.SecurityToken.ObjectsWhereSecurityToken => this.ObjectsWhereSecurityToken;
        public SecurityTokenOwnerWhereOwnerSecurityToken SecurityTokenOwnerWhereOwnerSecurityToken;
        Meta.SecurityTokenOwnerWhereOwnerSecurityToken Meta.SecurityToken.SecurityTokenOwnerWhereOwnerSecurityToken => this.SecurityTokenOwnerWhereOwnerSecurityToken;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.SecurityToken.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.SecurityToken.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.SecurityToken.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.SecurityToken.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.SecurityToken.OnPostDerive => this.OnPostDerive;
        public MethodType Delete;
        IMethodType Meta.SecurityToken.Delete => this.Delete;
    }
    public partial class UserGroup : Class, Meta.UserGroup {
        public UserGroup(MetaPopulation metaPopulation, System.Guid id, string tag = null) : base(metaPopulation, id, tag)
        {
        }

        Meta.M Meta.UserGroup.M => (Meta.M)this.MetaPopulation;

        public UserGroupMembers Members;
        Meta.UserGroupMembers Meta.UserGroup.Members => this.Members;
        public UserGroupName Name;
        Meta.UserGroupName Meta.UserGroup.Name => this.Name;

        public UniquelyIdentifiableUniqueId UniqueId;
        Meta.UniquelyIdentifiableUniqueId Meta.UserGroup.UniqueId => UniqueId;


        public ObjectRevocations Revocations;
        Meta.ObjectRevocations Meta.UserGroup.Revocations => Revocations;


        public ObjectSecurityTokens SecurityTokens;
        Meta.ObjectSecurityTokens Meta.UserGroup.SecurityTokens => SecurityTokens;


        public GrantsWhereSubjectGroup GrantsWhereSubjectGroup;
        Meta.GrantsWhereSubjectGroup Meta.UserGroup.GrantsWhereSubjectGroup => this.GrantsWhereSubjectGroup;

        public DelegatedAccessObjectsWhereDelegatedAccess DelegatedAccessObjectsWhereDelegatedAccess;
        Meta.DelegatedAccessObjectsWhereDelegatedAccess Meta.UserGroup.DelegatedAccessObjectsWhereDelegatedAccess => this.DelegatedAccessObjectsWhereDelegatedAccess ;


        public MethodType OnBuild;
        IMethodType Meta.UserGroup.OnBuild => this.OnBuild;
        public MethodType OnPostBuild;
        IMethodType Meta.UserGroup.OnPostBuild => this.OnPostBuild;
        public MethodType OnInit;
        IMethodType Meta.UserGroup.OnInit => this.OnInit;
        public MethodType OnPostDerive;
        IMethodType Meta.UserGroup.OnPostDerive => this.OnPostDerive;
    }
}