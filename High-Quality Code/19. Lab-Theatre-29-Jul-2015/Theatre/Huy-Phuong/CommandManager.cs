using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
using Theatre.Interfaces;

namespace Theatre
{
    public class CommandManager
    {
        public static readonly IPerformanceDatabase Universal = new PerformanceDatabase();

        public string CommandExecute(string data)
        {
            var commands = data.Split(new[] { '(', ',', ')' }, StringSplitOptions.RemoveEmptyEntries);
            var command = commands[0].Trim();
            var commandParameters = commands.Skip(1).Select(performance => performance.Trim()).ToArray();

            string output;

            switch (command)
            {
                case "AddTheatre":
                    output = ExecuteAddTheatreCommmand(commandParameters);
                    break;
                case "PrintAllTheatres":
                    output = ExecutePrintAllTheatresCommand();
                    break;
                case "AddPerformance":
                    output = ExecuteAddPerformanceCommand(commandParameters);
                    break;
                case "PrintAllPerformances":
                    output = ExecutePrintAllPerformancesCommand();
                    break;
                case "PrintPerformances":
                    output = ExecutePrintPerformancesCommand(commandParameters);
                    break;
                default:
                    output = "Invalid command!";
                    break;
            }

            return output;
        }

        private static string ExecuteAddTheatreCommmand(IReadOnlyList<string> parameters)
        {
            var theatreName = parameters[0];
            Universal.AddTheatre(theatreName);
            return "Theatre added";
        }

        private static string ExecutePrintAllTheatresCommand()
        {
            var theatresCount = Universal.ListTheatres().Count();
            return theatresCount <= 0 ? "No theatres" : string.Join(", ", Universal.ListTheatres());
        }

        private static string ExecuteAddPerformanceCommand(IReadOnlyList<string> parameters)
        {
            string theatreName = parameters[0];
            string performanceTitle = parameters[1];
            DateTime result = DateTime.ParseExact(parameters[2], "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture);
            DateTime startDateTime = result;
            TimeSpan result2 = TimeSpan.Parse(parameters[3]);
            TimeSpan duration = result2;
            decimal result3 = decimal.Parse(parameters[4], NumberStyles.Float);
            decimal price = result3;
            Universal.AddPerformance(theatreName, performanceTitle, startDateTime, duration, price);
            const string output = "Performance added";

            return output;
        }

        private static string ExecutePrintAllPerformancesCommand()
        {
            var performances = Universal.ListAllPerformances().ToList();
            if (!performances.Any())
            {
                return "No performances";
            }

            var allPerformancesInfo = performances.Select(p => string.Format(
                        "({0}, {1}, {2})",
                        p.Title,
                        p.Theatre,
                        p.StartDateTime.ToString("dd.MM.yyyy HH:mm")));

            return string.Join(", ", allPerformancesInfo);
        }

        private static string ExecutePrintPerformancesCommand(IReadOnlyList<string> parameters)
        {
            string theatre = parameters[0];
            var performances = Universal.ListPerformances(theatre).Select(p =>
            {
                string startTime = p.StartDateTime.ToString("dd.MM.yyyy HH:mm");
                return string.Format("({0}, {1})", p.Title, startTime);
            }).ToList();

            if (!performances.Any())
            {
                return "No performances";
            }

            return string.Join(", ", performances);
        }
    }
}
