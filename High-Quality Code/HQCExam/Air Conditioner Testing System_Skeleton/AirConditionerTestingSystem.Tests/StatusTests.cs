namespace AirConditionerTestingSystem.Tests
{
    using Core;
    using Core.UI;
    using Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Views;

    [TestClass]
    public class StatusTests
    {
        [TestMethod]
        public void Status_WithThreeRegistered_Should_ReturnCorrectResult()
        {
            var userInterface = new ConsoleUserInterface();
            var engine = new AirConditionerTestingSystemEngine(userInterface);
            var view = new AirConditionerView(engine);

            var firstAc = view.RegisterStationaryAirConditioner("Toshiba", "EX1000", "B", 1000);
            var secondAc = view.RegisterPlaneAirConditioner("Hitachi", "P320", 25, 750);
            var thirdAc = view.RegisterCarAirConditioner("Toshiba", "C60", 9);

            var firstTest = view.TestAirConditioner("Toshiba", "EX1000");
            var secondTest = view.TestAirConditioner("Hitachi", "P320");
            var thirdTest = view.TestAirConditioner("Toshiba", "C60");

            var result = view.Status();

            Assert.AreEqual("Jobs complete: 100,00%", result);
        }

        [TestMethod]
        public void Status_WithNoTested_Should_ReturnInCorrectly()
        {
            var userInterface = new ConsoleUserInterface();
            var engine = new AirConditionerTestingSystemEngine(userInterface);
            var view = new AirConditionerView(engine);

            var firstAc = view.RegisterStationaryAirConditioner("Toshiba", "EX1000", "B", 1000);
            var secondAc = view.RegisterPlaneAirConditioner("Hitachi", "P320", 25, 750);
            var thirdAc = view.RegisterCarAirConditioner("Toshiba", "C60", 9);

            var result = view.Status();

            Assert.AreEqual("Jobs complete: 0,00%", result);
        }

        [TestMethod]
        public void Status_WithNoRegistered_Should_ReturnIncorrectly()
        {
            var userInterface = new ConsoleUserInterface();
            var engine = new AirConditionerTestingSystemEngine(userInterface);
            var view = new AirConditionerView(engine);

            var result = view.Status();

            Assert.AreEqual("Jobs complete: 0,00%", result);
        }
    }
}