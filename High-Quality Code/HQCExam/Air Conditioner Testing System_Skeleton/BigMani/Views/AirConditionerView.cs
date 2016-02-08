namespace AirConditionerTestingSystem.Views
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Core;
    using Core.UI;
    using Exceptions;
    using Infrastructure;
    using Models;
    using Utilities;

    public class AirConditionerView
    {
        public AirConditionerView(AirConditionerTestingSystemEngine run)
        {
            this.Run = run;
        }

        public AirConditionerTestingSystemEngine Run { get; set; }

        public void ExecuteCommands()
        {
            var ui = new ConsoleUserInterface();
            var command = this.Run.Command;
            try
            {
                switch (command.Name)
                {
                    case "RegisterStationaryAirConditioner":
                        this.ValidateParametersCount(command, 4);
                        ui.WriteLine(this.RegisterStationaryAirConditioner(
                            command.Parameters[0],
                            command.Parameters[1],
                            command.Parameters[2],
                            int.Parse(command.Parameters[3])));
                        break;

                    case "RegisterCarAirConditioner":
                        this.ValidateParametersCount(command, 3);
                        ui.WriteLine(this.RegisterCarAirConditioner(
                            command.Parameters[0],
                            command.Parameters[1],
                            int.Parse(command.Parameters[2])));
                        break;

                    case "RegisterPlaneAirConditioner":
                        this.ValidateParametersCount(command, 4);
                        ui.WriteLine(this.RegisterPlaneAirConditioner(
                            command.Parameters[0],
                            command.Parameters[1],
                            int.Parse(command.Parameters[2]),
                            int.Parse(command.Parameters[3])));
                        break;

                    case "TestAirConditioner":
                        this.ValidateParametersCount(command, 2);
                        ui.WriteLine(this.TestAirConditioner(
                            command.Parameters[0],
                            command.Parameters[1]));
                        break;

                    case "FindAirConditioner":
                        this.ValidateParametersCount(command, 2);
                        ui.WriteLine(this.FindAirConditioner(
                            command.Parameters[1],
                            command.Parameters[0]));
                        break;

                    case "FindReport":
                        this.ValidateParametersCount(command, 2);
                        ui.WriteLine(this.FindReport(
                            command.Parameters[0],
                            command.Parameters[1]));
                        break;

                    case "FindAllReportsByManufacturer":
                        this.ValidateParametersCount(command, 1);
                        ui.WriteLine(this.FindAllReportsByManufacturer(
                            command.Parameters[0]));
                        break;

                    case "Status":
                        this.ValidateParametersCount(command, 0);
                        ui.WriteLine(this.Status());
                        break;

                    default:
                        throw new IndexOutOfRangeException(Constants.Invalidcommand);
                }
            }
            catch (ArgumentException ex)
            {
                ui.WriteLine(ex.Message);
            }
            catch (NonExistantEntryException ex)
            {
                ui.WriteLine(ex.Message);
            }
            catch (DuplicateEntryException ex)
            {
                ui.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                throw new InvalidOperationException(Constants.Invalidcommand, ex.InnerException);
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new InvalidOperationException(Constants.Invalidcommand, ex.InnerException);
            }
        }

        /// <summary>
        /// Registers the stationary air conditioner with the parameters given.
        /// It adds the air conditioner to the enumeration of lists.
        /// </summary>
        /// <param name="manufacturer">Manufacturer name</param>
        /// <param name="model">Model name</param>
        /// <param name="energyEfficiencyRating">The Energy Efficiency Rating of the air conditioner.</param>
        /// <param name="powerUsage">The Power Usage of the air conditioner</param>
        /// <returns>Registered Air Conditioner with Manufacturer and Model names.</returns>
        public string RegisterStationaryAirConditioner(string manufacturer, string model, string energyEfficiencyRating, int powerUsage)
        {
            if (energyEfficiencyRating.ToCharArray()[0] < 'A' || energyEfficiencyRating.ToCharArray()[0] > 'E')
            {
                throw new ArgumentException(Constants.Incorrectrating);
            }

            if (manufacturer.Length < Constants.ManufacturerMinLength)
            {
                throw new ArgumentException(string.Format(Constants.IncorrectPropertyLength, "Manufacturer", Constants.ManufacturerMinLength));
            }

            if (model.Length < Constants.ModelMinLength)
            {
                throw new ArgumentException(string.Format(Constants.IncorrectPropertyLength, "Model", Constants.ModelMinLength));
            }

            if (powerUsage <= 0)
            {
                throw new ArgumentException(string.Format(Constants.Nonpositive, "Power Usage"));
            }
                      
            if (Controller.GetAirConditionersCount() != 0)
            {
                if (Controller.AirConditioners.Any(airCon => airCon.Manufacturer == manufacturer && airCon.Model == model))
                {
                    throw new DuplicateEntryException(Constants.Duplicate);
                }
            }

            AirConditioner airConditioner = new AirConditioner(manufacturer, model, energyEfficiencyRating, powerUsage);
            Controller.AirConditioners.Add(airConditioner);

            return string.Format(Constants.Register, airConditioner.Model, airConditioner.Manufacturer);
        }

        public string RegisterCarAirConditioner(string manufacturer, string model, int volumeCoverage)
        {
            if (manufacturer.Length < Constants.ManufacturerMinLength)
            {
                throw new ArgumentException(string.Format(Constants.IncorrectPropertyLength, "Manufacturer", Constants.ManufacturerMinLength));
            }

            if (model.Length < Constants.ModelMinLength)
            {
                throw new ArgumentException(string.Format(Constants.IncorrectPropertyLength, "Model", Constants.ModelMinLength));
            }

            if (volumeCoverage <= 0)
            {
                throw new ArgumentException(string.Format(Constants.Nonpositive, "Volume Covered"));
            }

            if (Controller.GetAirConditionersCount() != 0)
            {
                if (Controller.AirConditioners.Any(airCon => airCon.Manufacturer == manufacturer && airCon.Model == model))
                {
                    throw new DuplicateEntryException(Constants.Duplicate);
                }
            }

            AirConditioner airConditioner = new AirConditioner(manufacturer, model, volumeCoverage);
            Controller.AirConditioners.Add(airConditioner);

            return string.Format(Constants.Register, airConditioner.Model, airConditioner.Manufacturer);
        }

        public string RegisterPlaneAirConditioner(string manufacturer, string model, int volumeCoverage, int electricityUsed)
        {
            if (manufacturer.Length < Constants.ManufacturerMinLength)
            {
                throw new ArgumentException(string.Format(Constants.IncorrectPropertyLength, "Manufacturer", Constants.ManufacturerMinLength));
            }

            if (model.Length < Constants.ModelMinLength)
            {
                throw new ArgumentException(string.Format(Constants.IncorrectPropertyLength, "Model", Constants.ModelMinLength));
            }

            if (volumeCoverage <= 0)
            {
                throw new ArgumentException(string.Format(Constants.Nonpositive, "Volume Covered"));
            }

            if (electricityUsed <= 0)
            {
                throw new ArgumentException(string.Format(Constants.Nonpositive, "Electricity Used"));
            }

            if (Controller.GetAirConditionersCount() != 0)
            {
                if (Controller.AirConditioners.Any(airCon => airCon.Manufacturer == manufacturer && airCon.Model == model))
                {
                    throw new DuplicateEntryException(Constants.Duplicate);
                }
            }

            AirConditioner airConditioner = new AirConditioner(manufacturer, model, volumeCoverage, electricityUsed);
            Controller.AirConditioners.Add(airConditioner);

            return string.Format(Constants.Register, airConditioner.Model, airConditioner.Manufacturer);
        }

        public string TestAirConditioner(string manufacturer, string model)
        {
            if (Controller.GetReportsCount() != 0)
            {
                if (Controller.Reports.Any(rep => rep.Manufacturer == manufacturer && rep.Model == model))
                {
                    throw new DuplicateEntryException(Constants.Duplicate);
                }
            }

            if (Controller.GetAirConditionersCount() != 0)
            {
                if (Controller.AirConditioners.Any(airCon => airCon.Manufacturer == manufacturer && airCon.Model == model))
                {
                    AirConditioner airConditioner = Controller.GetAirConditioner(manufacturer, model);
                    ///// airConditioner.energyRating += 5;
                    var mark = airConditioner.Test();
                    Controller.Reports.Add(new Report(airConditioner.Manufacturer, airConditioner.Model, mark));
                    return string.Format(Constants.Test, model, manufacturer);
                }
            }

            return string.Format(Constants.Nonexist);
        }

        /// <summary>
        /// Finds if an air conditioner with given manufacturer and model name exists.
        /// </summary>
        /// <param name="manufacturer">The manufacturer name.</param>
        /// <param name="model">The model name.</param>
        /// <returns>Returns the air conditioner if found.</returns>
        public string FindAirConditioner(string manufacturer, string model)
        {
            if (Controller.GetAirConditionersCount() != 0)
            {
                if (Controller.AirConditioners.Any(airCon => airCon.Manufacturer == manufacturer && airCon.Model == model))
                {
                    throw new NonExistantEntryException(Constants.Nonexist);
                }
            }

            AirConditioner airConditioner = Controller.GetAirConditioner(manufacturer, model);

            return airConditioner.ToString();
        }

        public string FindReport(string manufacturer, string model)
        {
            if (Controller.GetReportsCount() != 0)
            {
                if (!Controller.Reports.Any(rep => rep.Manufacturer == manufacturer && rep.Model == model))
                {
                    throw new NonExistantEntryException(Constants.Nonexist);
                }
            }

            Report report = Controller.GetReport(manufacturer, model);

            return report.ToString();
        }

        /// <summary>
        /// Finds all reports by a given manufacturer name.
        /// It orders them by Mark and adds them to list.
        /// Then appends the data to a StringBuilder.
        /// </summary>
        /// <param name="manufacturer">The manufacturer name.</param>
        /// <returns>Returns all the reports from the manufacturer.</returns>
        public string FindAllReportsByManufacturer(string manufacturer)
        {
            List<Report> reports = Controller.GetReportsByManufacturer(manufacturer);
            if (reports.Count == 0)
            {
                return Constants.Noreports;
            }

            reports = reports.OrderBy(x => x.Mark).ToList();
            StringBuilder reportsPrint = new StringBuilder();
            reportsPrint.AppendLine(string.Format("Reports from {0}:", manufacturer));
            reportsPrint.Append(string.Join(Environment.NewLine, reports));

            return reportsPrint.ToString();
        }

        /// <summary>
        /// Gets the count of all reports and the count of all air conditioners.
        /// After than it finds the percentage of all air conditioners tested.
        /// </summary>
        /// <returns>Percentage of all air conditioners tested.</returns>
        public string Status()
        {
            int reports = Controller.GetReportsCount();
            double airConditioners = Controller.GetAirConditionersCount();

            double percent = reports / airConditioners;
            percent = percent * 100;
            return string.Format(Constants.Status, percent);
        }

        public void ValidateParametersCount(Command command, int count)
        {
            if (command.Parameters.Length != count)
            {
                throw new InvalidOperationException(Constants.Invalidcommand);
            }
        }
    }
}
