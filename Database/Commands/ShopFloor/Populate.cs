namespace Commands
{
    using Allors.Database.Domain;

    public static class Populate
    {
        public static int Execute(ProgramContext context)
        {
            var database = context.Database;

            database.Init();

            var config = new Config { DataPath = context.DataPath };
            new Setup(database, config).Apply();

            using (var transaction = database.CreateTransaction())
            {
                // Seed demo data
                SeedDemoData(transaction);

                transaction.Derive();
                transaction.Commit();
            }

            return ExitCode.Success;
        }

        private static void SeedDemoData(Allors.Database.ITransaction transaction)
        {
            var m = transaction.Database.Services.Get<Allors.Database.Meta.M>();

            // Create demo equipment hierarchy
            var equipmentLevels = new EquipmentLevels(transaction);
            var siteLevel = equipmentLevels.FindBy(m.EquipmentLevel.UniqueId, new System.Guid("b0000001-0001-4000-8000-000000000002"));
            var areaLevel = equipmentLevels.FindBy(m.EquipmentLevel.UniqueId, new System.Guid("b0000001-0001-4000-8000-000000000003"));
            var workCenterLevel = equipmentLevels.FindBy(m.EquipmentLevel.UniqueId, new System.Guid("b0000001-0001-4000-8000-000000000004"));

            // Equipment Class: CNC Mill
            var cncMillClass = transaction.Build<EquipmentClass>();
            cncMillClass.Name = "CNC Mill";
            cncMillClass.Description = "Computer Numerical Control Milling Machine";
            cncMillClass.EquipmentLevel = workCenterLevel;

            var spindleSpeedProp = transaction.Build<EquipmentClassProperty>();
            spindleSpeedProp.Name = "Max Spindle Speed";
            spindleSpeedProp.DefaultValue = "12000";
            spindleSpeedProp.PropertyType = "number";
            cncMillClass.AddEquipmentClassProperty(spindleSpeedProp);

            var axesProp = transaction.Build<EquipmentClassProperty>();
            axesProp.Name = "Number of Axes";
            axesProp.DefaultValue = "3";
            axesProp.PropertyType = "number";
            cncMillClass.AddEquipmentClassProperty(axesProp);

            // Equipment hierarchy
            var mainSite = transaction.Build<Equipment>();
            mainSite.Name = "Main Plant";
            mainSite.EquipmentLevel = siteLevel;

            var machineShop = transaction.Build<Equipment>();
            machineShop.Name = "Machine Shop";
            machineShop.EquipmentLevel = areaLevel;
            machineShop.EquipmentParent = mainSite;
            mainSite.AddEquipmentChild(machineShop);

            var cncMill1 = transaction.Build<Equipment>();
            cncMill1.Name = "CNC Mill Bay 1";
            cncMill1.EquipmentLevel = workCenterLevel;
            cncMill1.EquipmentParent = machineShop;
            cncMill1.AddEquipmentClass(cncMillClass);
            machineShop.AddEquipmentChild(cncMill1);

            // Physical Asset
            var physicalAsset = transaction.Build<PhysicalAsset>();
            physicalAsset.Name = "Haas VF-2";
            physicalAsset.SerialNumber = "SN-2024-001";
            physicalAsset.Manufacturer = "Haas Automation";
            physicalAsset.ModelNumber = "VF-2";
            cncMill1.PhysicalAsset = physicalAsset;

            // Personnel
            var technicianClass = transaction.Build<PersonnelClass>();
            technicianClass.Name = "Maintenance Technician";
            technicianClass.Description = "Qualified to perform maintenance on shop floor equipment";

            var operatorClass = transaction.Build<PersonnelClass>();
            operatorClass.Name = "Machine Operator";
            operatorClass.Description = "Qualified to operate CNC and manual machines";

            var person1 = transaction.Build<Person>();
            person1.FirstName = "John";
            person1.LastName = "Smith";
            person1.AddPersonnelClass(technicianClass);

            var person2 = transaction.Build<Person>();
            person2.FirstName = "Jane";
            person2.LastName = "Doe";
            person2.AddPersonnelClass(operatorClass);

            // Operations Definitions & Work Masters
            var operationsTypes = new OperationsTypes(transaction);
            var maintenanceType = operationsTypes.FindBy(m.OperationsType.UniqueId, new System.Guid("b0000002-0001-4000-8000-000000000002"));

            var pmDefinition = transaction.Build<OperationsDefinition>();
            pmDefinition.Name = "Preventive Maintenance - CNC Mill";
            pmDefinition.Description = "Standard preventive maintenance procedure for CNC milling machines";
            pmDefinition.Version = "1.0";
            pmDefinition.OperationsType = maintenanceType;

            var workMaster = transaction.Build<WorkMaster>();
            workMaster.Name = "PM-CNC-001: CNC Mill Monthly PM";
            workMaster.Description = "Monthly preventive maintenance for CNC milling machines. Includes lubrication, belt inspection, coolant check, and axis calibration.";
            workMaster.Version = "1.0";
            workMaster.WorkType = maintenanceType;
            workMaster.Duration = 120;
            workMaster.OperationsDefinition = pmDefinition;

            // Create a sample job order
            var dispatchStatuses = new DispatchStatuses(transaction);
            var waitingStatus = dispatchStatuses.FindBy(m.DispatchStatus.UniqueId, new System.Guid("b0000003-0001-4000-8000-000000000001"));

            var jobOrder = transaction.Build<JobOrder>();
            jobOrder.Name = "JO-2026-001";
            jobOrder.Description = "Monthly PM for CNC Mill Bay 1";
            jobOrder.WorkType = maintenanceType;
            jobOrder.WorkMaster = workMaster;
            jobOrder.Equipment = cncMill1;
            jobOrder.Priority = 2;
            jobOrder.DispatchStatus = waitingStatus;
            jobOrder.AssignedTo = person1;
        }
    }
}
