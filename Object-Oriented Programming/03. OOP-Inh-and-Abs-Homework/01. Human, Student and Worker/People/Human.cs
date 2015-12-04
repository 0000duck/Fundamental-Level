using System;

namespace _01.Human__Student_and_Worker.People
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("First name cannot be empty.");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Last name cannot be empty.");
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("First name: {0}{2}Last name: {1}{2}", this.firstName, this.lastName, Environment.NewLine);
        }
    }
}