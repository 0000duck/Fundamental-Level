using System;
using System.Text;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.People
{
    class Customer : Person, ICustomer
    {
        private decimal netSpendingAmount;

        public Customer(int id, string firstName, string lastName, decimal netSpendingAmount)
            : base(id, firstName, lastName)
        {
            this.NetSpendingAmount = netSpendingAmount;
        }

        public Customer(int id, string firstName, string lastName) : base(id, firstName, lastName)
        {
        }

        public decimal NetSpendingAmount
        {
            get { return this.netSpendingAmount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The net spending amount cannot be negative.");
                }

                this.netSpendingAmount = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(base.ToString());
            output.AppendFormat("Role: Customer{0}", Environment.NewLine);
            output.AppendFormat("Net Spending Amount: {0:c2}{1}", this.NetSpendingAmount, Environment.NewLine);

            return output.ToString();
        }
    }
}