using System;
using System.Globalization;
using System.Linq;

namespace FootballLeague.Models
{
    public static class LeagueManager
    {
        public static void HandleInput(string input)
        {
            var inputArgs = input.Split();
            switch (inputArgs[0])
            {
                case "AddTeam":
                    AddTeam(new Team(inputArgs[1], inputArgs[2], DateTime.ParseExact(inputArgs[3], "yyyy/MM/dd", CultureInfo.InvariantCulture)));
                    break;
                case "AddMatch":
                    AddMatch(inputArgs[1], inputArgs[2], inputArgs[3], inputArgs[4], inputArgs[5]);
                    break;
                case "AddPlayerToTeam":
                    AddPlayerToTeam(inputArgs[1], inputArgs[2], inputArgs[3], inputArgs[4], inputArgs[5]);
                    break;
                case "ListTeams":
                    ListTeams();
                    break;
                case "ListMatches":
                    ListMatches();
                    break;
            }
        }

        private static void AddPlayerToTeam(string firstName, string lastName, string salary, string dateOfBirth, string teamName)
        {
            if (League.Teams.All(t => t.Name != teamName))
            {
                throw new InvalidOperationException("There is no team with the name " + teamName + " in the league.");
            }
            League.Teams.First(t => t.Name == teamName)
                .AddPlayer(new Player(firstName, lastName, DateTime.ParseExact(dateOfBirth, "yyyy/MM/dd", CultureInfo.InvariantCulture), decimal.Parse(salary),
                    League.Teams.First(t => t.Name == teamName)));
        }

        private static void AddMatch(string homeTeamName, string awayTeamName, string idString, string homeTeamGoalsStr, string awayTeamGoalsStr)
        {
            if (League.Teams.All(t => t.Name != homeTeamName))
            {
                throw new InvalidOperationException("There is no team with the name " + homeTeamName + " in the league.");
            }

            if (League.Teams.All(t => t.Name != awayTeamName))
            {
                throw new InvalidOperationException("There is no team with the name " + awayTeamName + " in the league.");
            }


            League.AddMatch(new Match(League.Teams.First(t => t.Name == homeTeamName),
                        League.Teams.First(t => t.Name == awayTeamName),
                        new Score(int.Parse(homeTeamGoalsStr), int.Parse(awayTeamGoalsStr)), int.Parse(idString)));
            Console.WriteLine("Match with ID: " + idString + " has been added succesfully");
        }

        private static void AddTeam(Team newTeam)
        {
            League.AddTeam(newTeam);
            Console.WriteLine("The {0} has been added successfully", newTeam.Name);
        }

        private static void ListTeams()
        {
            foreach (Team team in League.Teams)
            {
                Console.WriteLine(team);
            }
        }

        private static void ListMatches()
        {
            foreach (Match match in League.Matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}