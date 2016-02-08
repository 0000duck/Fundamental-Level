namespace HotelBookingSystem.Tests
{
    using System;
    using System.Text;
    using Controllers;
    using Data;
    using Identity;
    using Interfaces;
    using Models;
    using Moq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ControllerTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAuthorize_NoLoggedUser_ShouldReturnException()
        {
            var database = new HotelBookingSystemData();
            var controller = new VenuesController(database, null);

            controller.Details(1);
        }

        [TestMethod]
        [ExpectedException(typeof(AuthorizationFailedException))]
        public void TestAuthorize_NoSufficientRights_ShouldReturnException()
        {
            var database = new HotelBookingSystemData();
            var controller = new VenuesController(database, new User("No admin", "admina", Roles.User));

            controller.Add("No name", "No address", "No description");
        }

        [TestMethod]
        public void TestAuthorize_ValidUser_ShouldPass()
        {
            var database = new HotelBookingSystemData();
            var controller = new VenuesController(database, new User("No admin", "admina", Roles.VenueAdmin));

            controller.Add("No name", "No address", "No description");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestLogout_WithoutLoggedUser_ShouldThrowException()
        {
            var database = new HotelBookingSystemData();
            var controller = new UsersController(database, null);

            controller.Logout();
        }

        [TestMethod]
        public void TestLogout_WithLoggedUser_CurrentUserIsNull()
        {
            var database = new HotelBookingSystemData();
            var controller = new UsersController(database, new User("No admin", "admina", Roles.VenueAdmin));

            controller.Logout();
            var result = controller.CurrentUser;

            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestAllVenues_WithoutVenues_CorrectReturnedString()
        {
            const string expected = "There are currently no venues to show.";

            var database = new HotelBookingSystemData();
            var controller = new VenuesController(database, null);

            var result = controller.All().Display();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAllVenues_WithVenues_CorrectReturnedString()
        {
            var resultString = new StringBuilder();
            resultString.AppendLine("*[1] first venue, located at Chepelare")
                .AppendLine("Free rooms: 0");
            resultString.AppendLine("*[2] second venue, located at Sofia")
                .AppendLine("Free rooms: 0");
            resultString.AppendLine("*[3] third venue, located at Plovdiv")
                .AppendLine("Free rooms: 0");
            string expected = resultString.ToString().Trim();

            var database = new HotelBookingSystemData();
            var controller = new VenuesController(database, new User("No admin", "admina", Roles.VenueAdmin));

            controller.Add("first venue", "Chepelare", "no");
            controller.Add("second venue", "Sofia", "no");
            controller.Add("third venue", "Plovdiv", "no");
            var result = controller.All().Display();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestRoomAdd_ValidRoomDetails_RoomShouldBePresent()
        {
            const string expected = "The room with ID 2 has been created successfully.";

            var user = new User("admin", "admina", Roles.VenueAdmin);
            int nextId = 1;

            var roomsRepositoryMoq = new Mock<IRepository<Room>>();
            roomsRepositoryMoq.Setup(b => b.Add(It.IsAny<Room>())).Callback((Room r) => r.Id = nextId++);

            var venueRepositoryMoq = new Mock<IRepository<Venue>>();
            venueRepositoryMoq.Setup(v => v.Get(It.IsAny<int>())).Returns(new Venue("Venue1", "Sofia", "Description1", user));

            var moqData  = new Mock<IHotelBookingSystemData>();
            moqData.Setup(d => d.RoomsRepository).Returns(roomsRepositoryMoq.Object);
            moqData.Setup(d => d.VenuesRepository).Returns(venueRepositoryMoq.Object);

            var controller = new RoomsController(moqData.Object, user);

            controller.Add(1, 100, 100m);
            var result = controller.Add(2, 100, 100m).Display();

            Assert.AreEqual(expected, result);
        }
    }
}