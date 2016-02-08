namespace AirConditionerTestingSystem.Tests
{
    using System;
    using Core;
    using Core.UI;
    using Views;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RegisterStationaryAirConditionerTests
    {
        [TestMethod]
        public void Registering_CorrectAC_ShouldReturnCorrectly()
        {
            var userInterface = new ConsoleUserInterface();
            var engine = new AirConditionerTestingSystemEngine(userInterface);
            var view = new AirConditionerView(engine);

            var registeredAc = view.RegisterStationaryAirConditioner("Toshiba", "EX1000", "B", 1000);
            var expected = "Air Conditioner model EX1000 from Toshiba registered successfully.";

            Assert.AreEqual(expected, registeredAc);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Registering_IncorrectACManufacturerName_ShouldThrowException()
        {
            var userInterface = new ConsoleUserInterface();
            var engine = new AirConditionerTestingSystemEngine(userInterface);
            var view = new AirConditionerView(engine);

            var registeredAc = view.RegisterStationaryAirConditioner("Toshiba", "EX1000", "B", 1000);
            var secondAc = view.RegisterPlaneAirConditioner("Hit", "P320", 25, 750);
            var thirdAc = view.RegisterCarAirConditioner("Toshiba", "C60", 9);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Registering_IncorrectACModelName_ShouldThrowException()
        {
            var userInterface = new ConsoleUserInterface();
            var engine = new AirConditionerTestingSystemEngine(userInterface);
            var view = new AirConditionerView(engine);

            var registeredAc = view.RegisterStationaryAirConditioner("Toshiba", "EX1000", "B", 1000);
            var secondAc = view.RegisterPlaneAirConditioner("Hitachi", "", 25, 750);
            var thirdAc = view.RegisterCarAirConditioner("Toshiba", "C60", 9);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Registering_IncorrectACPowerUsage_ShouldThrowException()
        {
            var userInterface = new ConsoleUserInterface();
            var engine = new AirConditionerTestingSystemEngine(userInterface);
            var view = new AirConditionerView(engine);

            var registeredAc = view.RegisterStationaryAirConditioner("Toshiba", "EX1000", "B", 1000);
            var secondAc = view.RegisterPlaneAirConditioner("Hitachi", "", 25, -200);
            var thirdAc = view.RegisterCarAirConditioner("Toshiba", "C60", 9);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Registering_IncorrectACEfficiencyRating_ShouldThrowException()
        {
            var userInterface = new ConsoleUserInterface();
            var engine = new AirConditionerTestingSystemEngine(userInterface);
            var view = new AirConditionerView(engine);

            var registeredAc = view.RegisterStationaryAirConditioner("Toshiba", "EX1000", "F", 1000);
            var secondAc = view.RegisterPlaneAirConditioner("Hitachi", "", 25, 750);
            var thirdAc = view.RegisterCarAirConditioner("Toshiba", "C60", 9);
        }
    }
}