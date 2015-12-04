using System;
using _03.CompanyHierarchy.Enums;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.People
{
    abstract class Employee : Person, IEmployee
    {
        private decimal salary;

        protected Employee(int id, string firstName, string lastName, Department department, decimal salary) : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public Department Department { get; set; }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negative.");
                }

                this.salary = value;
            }
        }
    }
}