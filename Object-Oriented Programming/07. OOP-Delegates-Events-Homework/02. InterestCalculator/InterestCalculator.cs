namespace _02.InterestCalculator
{
    public delegate double CalculateInterest(double money, double interest, int years);

    public class InterestCalculator
    {
        private readonly CalculateInterest calculationMethod;

        private double money;
        private double interest;
        private int years;

        public InterestCalculator(double money, double interest, int years, CalculateInterest calculationMethod)
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.calculationMethod = calculationMethod;
        }

        private double Money
        {
            get
            {
                return this.money;
            }

            set
            {
                Extensions.ValidateNum(value, "Money");
                this.money = value;
            }
        }

        private double Interest
        {
            get
            {
                return this.interest;
            }

            set
            {
                Extensions.ValidateNum(value, "Interest");
                this.interest = value;
            }
        }

        private int Years
        {
            get
            {
                return this.years;
            }

            set
            {
                Extensions.ValidateNum(value, "Years");
                this.years = value;
            }
        }

        public override string ToString()
        {
            return $"{this.calculationMethod(this.Money, this.Interest, this.Years):F4}";
        }
    }
}