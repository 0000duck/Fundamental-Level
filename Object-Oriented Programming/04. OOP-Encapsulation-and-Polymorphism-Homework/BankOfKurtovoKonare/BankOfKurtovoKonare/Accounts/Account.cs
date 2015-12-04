using System;
using BankOfKurtovoKonare.Enums;
using BankOfKurtovoKonare.Interfaces;

namespace BankOfKurtovoKonare.Accounts
{
    public abstract class Account : IAccount
    {
        private Customer customer;

        private decimal balance;

        private decimal interestRate;

        protected Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer { get; set; }

        public decimal Balance
        {
            get { return this.balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Balance cannot be negative.");
                }

                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Interest rate cannot be negative.");
                }

                this.interestRate = value;
            }
        }

        public void DepositMoney(decimal money)
        {
            this.Balance += money;
        }

        public abstract decimal CalculateInterest(int months);

        public override string ToString()
        {
            return string.Format("Account: {0}\nBalance: {1}\nInterest rate: {2}\n", this.Customer, this.Balance, this.InterestRate);
        }
    }
}