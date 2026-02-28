namespace Allors.Database.Domain
{
    using System;
    using Meta;

    public partial class Setup
    {
        private void ShopFloorOnPrePrepare()
        {
        }

        private void ShopFloorOnPostPrepare()
        {
        }

        private void ShopFloorOnPreSetup()
        {
        }

        private void ShopFloorOnPostSetup(Config config)
        {
            var transaction = this.transaction;
            var m = transaction.Database.Services.Get<M>();

            SeedEquipmentLevels(transaction, m);
            SeedOperationsTypes(transaction, m);
            SeedDispatchStatuses(transaction, m);
        }

        private static void SeedEquipmentLevels(ITransaction transaction, M m)
        {
            var levels = new (Guid UniqueId, string Name)[]
            {
                (new Guid("b0000001-0001-4000-8000-000000000001"), "Enterprise"),
                (new Guid("b0000001-0001-4000-8000-000000000002"), "Site"),
                (new Guid("b0000001-0001-4000-8000-000000000003"), "Area"),
                (new Guid("b0000001-0001-4000-8000-000000000004"), "WorkCenter"),
                (new Guid("b0000001-0001-4000-8000-000000000005"), "WorkUnit"),
            };

            foreach (var (uniqueId, name) in levels)
            {
                var existing = new EquipmentLevels(transaction).FindBy(m.EquipmentLevel.UniqueId, uniqueId);
                if (existing == null)
                {
                    var level = transaction.Build<EquipmentLevel>();
                    level.UniqueId = uniqueId;
                    level.Name = name;
                    level.IsActive = true;
                }
            }
        }

        private static void SeedOperationsTypes(ITransaction transaction, M m)
        {
            var types = new (Guid UniqueId, string Name)[]
            {
                (new Guid("b0000002-0001-4000-8000-000000000001"), "Production"),
                (new Guid("b0000002-0001-4000-8000-000000000002"), "Maintenance"),
                (new Guid("b0000002-0001-4000-8000-000000000003"), "Quality"),
                (new Guid("b0000002-0001-4000-8000-000000000004"), "Inventory"),
            };

            foreach (var (uniqueId, name) in types)
            {
                var existing = new OperationsTypes(transaction).FindBy(m.OperationsType.UniqueId, uniqueId);
                if (existing == null)
                {
                    var operationsType = transaction.Build<OperationsType>();
                    operationsType.UniqueId = uniqueId;
                    operationsType.Name = name;
                    operationsType.IsActive = true;
                }
            }
        }

        private static void SeedDispatchStatuses(ITransaction transaction, M m)
        {
            var statuses = new (Guid UniqueId, string Name)[]
            {
                (new Guid("b0000003-0001-4000-8000-000000000001"), "Waiting"),
                (new Guid("b0000003-0001-4000-8000-000000000002"), "Pending"),
                (new Guid("b0000003-0001-4000-8000-000000000003"), "Cancelled"),
                (new Guid("b0000003-0001-4000-8000-000000000004"), "Dispatched"),
                (new Guid("b0000003-0001-4000-8000-000000000005"), "Ready"),
                (new Guid("b0000003-0001-4000-8000-000000000006"), "Running"),
                (new Guid("b0000003-0001-4000-8000-000000000007"), "Completed"),
                (new Guid("b0000003-0001-4000-8000-000000000008"), "Aborted"),
                (new Guid("b0000003-0001-4000-8000-000000000009"), "Held"),
                (new Guid("b0000003-0001-4000-8000-00000000000a"), "Suspended"),
                (new Guid("b0000003-0001-4000-8000-00000000000b"), "Closed"),
            };

            foreach (var (uniqueId, name) in statuses)
            {
                var existing = new DispatchStatuses(transaction).FindBy(m.DispatchStatus.UniqueId, uniqueId);
                if (existing == null)
                {
                    var status = transaction.Build<DispatchStatus>();
                    status.UniqueId = uniqueId;
                    status.Name = name;
                    status.IsActive = true;
                }
            }
        }
    }
}
