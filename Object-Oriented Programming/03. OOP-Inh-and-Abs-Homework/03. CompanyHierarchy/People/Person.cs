using System;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.People
{
    abstract class Person : IPerson
    {
        private int id;
        private string firstName;
        private string lastName;

        protected Person(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Id
        {
            get { return this.id; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Id cannot be a negative number.");
                }

                this.id = value;
            }
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
            return string.Format("ID: {0}\nFirstName: {1}\nLast name: {2}\n", this.Id, this.FirstName, this.LastName);
        }
    }
}