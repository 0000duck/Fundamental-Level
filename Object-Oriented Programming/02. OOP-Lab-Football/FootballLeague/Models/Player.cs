using System;

namespace FootballLeague.Models
{
    public class Player
    {
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private decimal salary;
        private Team team;
        private const int MinimumAllowedYear = 1980;

        public Player(string firstName, string lastName, DateTime dateOfBirth, decimal salary, Team team)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Salary = salary;
            this.Team = team;
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("First name should be at least 3 chars long");
                }

                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("Last name should be at least 3 chars long");
                }

                lastName = value;
            }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                if (value.Year < MinimumAllowedYear)
                {
                    throw new ArgumentException("Date of Birth cannot be earlier than " + MinimumAllowedYear);
                }

                dateOfBirth = value;
            }
        }

        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be negative");
                }

                salary = value;
            }
        }

        public Team Team
        {
            get { return team; }
            set { team = value; }
        }

        public override string ToString()
        {
            return "Name: " + this.firstName + " " + this.lastName + ", Salary: " + this.salary + ", Date of Birth: " +
                   this.dateOfBirth.ToShortDateString() + ", Team: " + Team.Name;
        }
    }
}