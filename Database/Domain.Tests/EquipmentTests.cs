namespace Allors.Database.Domain.Tests
{
    using System.Linq;
    using Xunit;

    public class EquipmentTests : ShopFloorTestBase
    {
        [Fact]
        public void EquipmentDisplayName_ShouldDeriveFromHierarchy()
        {
            var site = this.Transaction.Build<Equipment>();
            site.Name = "Main Plant";

            var area = this.Transaction.Build<Equipment>();
            area.Name = "Machine Shop";
            area.EquipmentParent = site;

            var workCenter = this.Transaction.Build<Equipment>();
            workCenter.Name = "CNC Mill 1";
            workCenter.EquipmentParent = area;

            this.Transaction.Derive();

            Assert.Equal("Main Plant > Machine Shop > CNC Mill 1", workCenter.DisplayName);
            Assert.Equal("Main Plant > Machine Shop", area.DisplayName);
            Assert.Equal("Main Plant", site.DisplayName);
        }

        [Fact]
        public void EquipmentLevel_ShouldBeSeedData()
        {
            var levels = this.Transaction.Extent<EquipmentLevel>().ToArray();
            Assert.Equal(5, levels.Length);
            Assert.Contains(levels, l => l.Name == "Enterprise");
            Assert.Contains(levels, l => l.Name == "Site");
            Assert.Contains(levels, l => l.Name == "Area");
            Assert.Contains(levels, l => l.Name == "WorkCenter");
            Assert.Contains(levels, l => l.Name == "WorkUnit");
        }

        [Fact]
        public void EquipmentPropertyInheritance_ShouldCreatePropertiesFromClass()
        {
            var equipmentClass = this.Transaction.Build<EquipmentClass>();
            equipmentClass.Name = "Test Class";

            var classProp = this.Transaction.Build<EquipmentClassProperty>();
            classProp.Name = "Test Property";
            classProp.DefaultValue = "42";
            equipmentClass.AddEquipmentClassProperty(classProp);

            var equipment = this.Transaction.Build<Equipment>();
            equipment.Name = "Test Equipment";
            equipment.AddEquipmentClass(equipmentClass);

            this.Transaction.Derive();

            Assert.NotNull(equipment.EquipmentProperties);
            Assert.Single(equipment.EquipmentProperties);
            Assert.Equal("Test Property", equipment.EquipmentProperties.First().Name);
            Assert.Equal("42", equipment.EquipmentProperties.First().Value);
        }
    }
}
