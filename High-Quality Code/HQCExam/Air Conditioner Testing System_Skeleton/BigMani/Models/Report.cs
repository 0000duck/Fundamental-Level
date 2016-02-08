namespace AirConditionerTestingSystem.Models
{
    using Interfaces;

    public class Report : IReport
    {
        public Report(string manufacturer, string model, bool mark)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Mark = mark;
        }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public bool Mark { get; set; }

        public override string ToString()
        {
            string result = string.Empty;
            if (!this.Mark)
            {
                result = "Failed";
            }
            else if (this.Mark)
            {
                result = "Passed";
            }

            result = "Report" + "\r\n" + "====================" + "\r\n" + "Manufacturer: " + this.Manufacturer + "\r\n" +
                      "Model: " + this.Model + "\r\n" + "Mark: " + result + "\r\n" + "====================";

            return result;
        }
    }
}
