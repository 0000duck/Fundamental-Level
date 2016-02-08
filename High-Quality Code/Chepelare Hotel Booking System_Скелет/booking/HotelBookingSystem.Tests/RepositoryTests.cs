namespace HotelBookingSystem.Tests
{
    using Data;
    using Interfaces;
    using Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RepositoryTests
    {
        private IRepository<Venue> repository;

        [TestInitialize]
        public void SetUp()
        {
            this.repository = new Repository<Venue>();
        }

        [TestMethod]
        public void TestGet_NoItems_ShouldReturnNull()
        {
            var result = this.repository.Get(6);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestGet_ItemPresent_ShouldReturnItemName()
        {
            var user = new User("admin", "admina", Roles.VenueAdmin);
            this.repository.Add(new Venue("Venue1", "Sofia", "None", user));
            this.repository.Add(new Venue("Venue2", "Sofia", "None", user));
            this.repository.Add(new Venue("Venue3", "Sofia", "None", user));

            var result = this.repository.Get(2);

            Assert.AreEqual("Venue2", result.Name);
        }

        [TestMethod]
        public void TestGet_ItemPresent_ShouldReturnItemAddress()
        {
            var user = new User("admin", "admina", Roles.VenueAdmin);
            this.repository.Add(new Venue("Venue1", "Sofia", "None", user));
            this.repository.Add(new Venue("Venue2", "Sofia2", "None", user));
            this.repository.Add(new Venue("Venue3", "Sofia", "None", user));

            var result = this.repository.Get(2);

            Assert.AreEqual("Sofia2", result.Address);
        }

        [TestMethod]
        public void TestGet_ItemPresent_ShouldReturnItemDescription()
        {
            var user = new User("admin", "admina", Roles.VenueAdmin);
            this.repository.Add(new Venue("Venue1", "Sofia", "None", user));
            this.repository.Add(new Venue("Venue2", "Sofia", "None", user));
            this.repository.Add(new Venue("Venue3", "Sofia", "None", user));

            var result = this.repository.Get(2);

            Assert.AreEqual("None", result.Description);
        }

        [TestMethod]
        public void TestGet_ItemPresent_ShouldReturnItemId()
        {
            var user = new User("admin", "admina", Roles.VenueAdmin);
            this.repository.Add(new Venue("Venue1", "Sofia", "None", user));
            this.repository.Add(new Venue("Venue2", "Sofia", "None", user));
            this.repository.Add(new Venue("Venue3", "Sofia", "None", user));

            var result = this.repository.Get(2);

            Assert.AreEqual(2, result.Id);
        }
    }
}
