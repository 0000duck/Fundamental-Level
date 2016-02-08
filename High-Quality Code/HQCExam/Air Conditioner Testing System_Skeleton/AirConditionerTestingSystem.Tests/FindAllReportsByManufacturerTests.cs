namespace AirConditionerTestingSystem.Tests
{
    using System.Text;
    using Core;
    using Core.UI;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Views;

    [TestClass]
    public class FindAllReportsByManufacturerTests
    {
        [TestMethod]
        public void Reports_WithRegisteredProducts_ShouldReturnCorrectly()
        {
            var userInterface = new ConsoleUserInterface();
            var engine = new AirConditionerTestingSystemEngine(userInterface);
            var view = new AirConditionerView(engine);

            var firstAc = view.RegisterStationaryAirConditioner("Toshiba", "EX1000", "B", 1000);
            var secondAc = view.RegisterPlaneAirConditioner("Hitachi", "P320", 25, 750);
            var thirdAc = view.RegisterStationaryAirConditioner("Toshiba", "C60", "A", 780);

            var firstTest = view.TestAirConditioner("Toshiba", "EX1000");
            var secondTest = view.TestAirConditioner("Hitachi", "P320");
            var thirdTest = view.TestAirConditioner("Toshiba", "C60");

            var result = view.FindAllReportsByManufacturer("Toshiba");
            var expected = new StringBuilder();
            expected.AppendLine("Reports from Toshiba:");
            expected.AppendLine("Report");
            expected.AppendLine("====================");
            expected.AppendLine("Manufacturer: Toshiba");
            expected.AppendLine("Model: C60");
            expected.AppendLine("Mark: Passed");
            expected.AppendLine("====================");
            expected.AppendLine("Report");
            expected.AppendLine("====================");
            expected.AppendLine("Manufacturer: Toshiba");
            expected.AppendLine("Model: EX1000");
            expected.AppendLine("Mark: Passed");
            expected.Append("====================");

            Assert.AreEqual(expected.ToString(), result);
        }

        [TestMethod]
        public void Reports_WithNoRegisteredProducts_ShouldReturnCorrectly()
        {
            var userInterface = new ConsoleUserInterface();
            var engine = new AirConditionerTestingSystemEngine(userInterface);
            var view = new AirConditionerView(engine);

            var result = view.FindAllReportsByManufacturer("Toshiba");
            var expected = "No reports.";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Reports_WithRegisteredProducts_ShouldReturnNoReports()
        {
            var userInterface = new ConsoleUserInterface();
            var engine = new AirConditionerTestingSystemEngine(userInterface);
            var view = new AirConditionerView(engine);

            var firstAc = view.RegisterStationaryAirConditioner("Toshiba", "EX1000", "B", 1000);
            var secondAc = view.RegisterPlaneAirConditioner("Hitachi", "P320", 25, 750);
            var thirdAc = view.RegisterStationaryAirConditioner("Toshiba", "C60", "A", 780);

            var firstTest = view.TestAirConditioner("Toshiba", "EX1000");
            var secondTest = view.TestAirConditioner("Toshiba", "C60");

            var result = view.FindAllReportsByManufacturer("Hitachi");
            var expected = "No reports.";

            Assert.AreEqual(expected, result);
        }
    }
}