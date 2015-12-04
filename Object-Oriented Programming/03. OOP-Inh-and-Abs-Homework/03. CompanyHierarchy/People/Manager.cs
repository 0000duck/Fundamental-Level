using System;
using System.Collections.Generic;
using System.Text;
using _03.CompanyHierarchy.Enums;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.People
{
    class Manager : Employee, IManager
    {
        public Manager(int id, string firstName, string lastName, Department department, decimal salary,
            List<IEmployee> employeesManaged) : base(id, firstName, lastName, department, salary)
        {
            this.EmployeesManaged = employeesManaged;
        }

        public Manager(int id, string firstName, string lastName, Department department, decimal salary, IEmployee employeeManaged)
            : this(id, firstName, lastName, department, salary, new List<IEmployee> { employeeManaged })
        {
        }

        public List<IEmployee> EmployeesManaged { get; private set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(base.ToString());
            output.AppendFormat("Role: Manager{0}", Environment.NewLine);
            output.AppendFormat("Employees managed: ");
            List<string> employeeNames = new List<string>();
            foreach (Employee employee in this.EmployeesManaged)
            {
                employeeNames.Add(string.Format("{0} {1}", employee.FirstName, employee.LastName));
            }
            output.Append(String.Join(", ", employeeNames) + Environment.NewLine);
            return output.ToString();
        }
    }
}