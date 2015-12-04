using System.Collections.Generic;
using System.Text;
using _03.CompanyHierarchy.Enums;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.People
{
    class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        public SalesEmployee(int id, string firstName, string lastName, Department department, decimal salary,
            List<ISale> sales) : base(id, firstName, lastName, department, salary)
        {
            this.Sales = sales;
        }

        public SalesEmployee(int id, string firstName, string lastName, Department department, decimal salary, ISale sale)
            : this(id, firstName, lastName, department, salary, new List<ISale>() { sale })
        {
        }

        public List<ISale> Sales { get; private set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(base.ToString());
            output.AppendFormat("Role: Sales Employee\n");
            output.AppendFormat("Sales made: {0}\n", this.Sales.Count);

            return output.ToString();
        }
    }
}