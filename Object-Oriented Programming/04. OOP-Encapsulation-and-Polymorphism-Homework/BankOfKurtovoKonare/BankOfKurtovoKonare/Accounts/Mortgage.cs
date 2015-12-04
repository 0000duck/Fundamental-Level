using BankOfKurtovoKonare.Enums;

namespace BankOfKurtovoKonare.Accounts
{
    public class Mortgage : Account
    {
        public Mortgage(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public new void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }

        public override decimal CalculateInterest(int months)
        {
            if (months < 12 && this.Customer == Customer.Company)
            {
                return this.InterestRate = (this.Balance * (1 + this.InterestRate * months)) / 2;
            }
            else if (months < 6 && this.Customer == Customer.Individual)
            {
                return 0;
            }

            return this.InterestRate = this.Balance*(1 + this.InterestRate*months);
        }
    }
}