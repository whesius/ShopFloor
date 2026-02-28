namespace Allors.Database.Domain.Tests
{
    using System;
    using System.Linq;
    using Xunit;

    public class JobOrderTests : ShopFloorTestBase
    {
        [Fact]
        public void OperationsType_ShouldBeSeedData()
        {
            var types = this.Transaction.Extent<OperationsType>().ToArray();
            Assert.Equal(4, types.Length);
            Assert.Contains(types, t => t.Name == "Production");
            Assert.Contains(types, t => t.Name == "Maintenance");
            Assert.Contains(types, t => t.Name == "Quality");
            Assert.Contains(types, t => t.Name == "Inventory");
        }

        [Fact]
        public void DispatchStatus_ShouldBeSeedData()
        {
            var statuses = this.Transaction.Extent<DispatchStatus>().ToArray();
            Assert.Equal(11, statuses.Length);
            Assert.Contains(statuses, s => s.Name == "Waiting");
            Assert.Contains(statuses, s => s.Name == "Completed");
            Assert.Contains(statuses, s => s.Name == "Closed");
        }

        [Fact]
        public void JobOrder_ShouldTransitionToCompletedOnJobResponseEnd()
        {
            var maintenanceType = this.Transaction.Extent<OperationsType>()
                .First(t => t.Name == "Maintenance");
            var waitingStatus = this.Transaction.Extent<DispatchStatus>()
                .First(s => s.Name == "Waiting");

            var equipment = this.Transaction.Build<Equipment>();
            equipment.Name = "Test Equipment";

            var jobOrder = this.Transaction.Build<JobOrder>();
            jobOrder.Name = "JO-TEST-001";
            jobOrder.WorkType = maintenanceType;
            jobOrder.DispatchStatus = waitingStatus;
            jobOrder.Equipment = equipment;

            var jobResponse = this.Transaction.Build<JobResponse>();
            jobResponse.JobOrder = jobOrder;
            jobResponse.StartTime = DateTime.UtcNow.AddHours(-2);
            jobResponse.EndTime = DateTime.UtcNow;
            jobOrder.Response = jobResponse;

            this.Transaction.Derive();

            Assert.Equal("Completed", jobOrder.DispatchStatus.Name);
        }
    }
}
