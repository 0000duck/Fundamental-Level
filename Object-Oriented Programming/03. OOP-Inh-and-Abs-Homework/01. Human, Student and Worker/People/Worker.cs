using System;
using System.Text;
using _01.Human__Student_and_Worker.Interfaces;

namespace _01.Human__Student_and_Worker.People
{
    public class Worker : Human, IHuman
    {
        private int weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public int WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Week salary cannot be negative.");
                }

                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentOutOfRangeException("Work hours per day must be in range [0 ... 24].");
                }

                this.workHoursPerDay = value;
            }
        }

        public int MoneyPerHour()
        {
            if (this.workHoursPerDay == 0)
            {
                return 0;
            }

            return (this.weekSalary / 5 ) / this.workHoursPerDay;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(base.ToString());
            output.AppendFormat("Week salary: {0}{1}", this.weekSalary, Environment.NewLine);
            output.AppendFormat("Work hours per day: {0}{1}", this.workHoursPerDay, Environment.NewLine);
            return output.ToString();
        }
    }
}