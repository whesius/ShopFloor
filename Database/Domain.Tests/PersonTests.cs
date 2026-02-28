namespace Allors.Database.Domain.Tests
{
    using Xunit;

    public class PersonTests : ShopFloorTestBase
    {
        [Fact]
        public void PersonDisplayName_ShouldDeriveFromFirstAndLastName()
        {
            var person = this.Transaction.Build<Person>();
            person.FirstName = "John";
            person.LastName = "Smith";

            this.Transaction.Derive();

            Assert.Equal("John Smith", person.DisplayName);
        }

        [Fact]
        public void PersonDisplayName_ShouldHandleFirstNameOnly()
        {
            var person = this.Transaction.Build<Person>();
            person.FirstName = "Jane";

            this.Transaction.Derive();

            Assert.Equal("Jane", person.DisplayName);
        }
    }
}
