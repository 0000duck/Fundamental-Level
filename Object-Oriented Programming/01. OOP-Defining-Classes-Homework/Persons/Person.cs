using System;

namespace Persons
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age) : this(name, age, null)
        {
        }

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name cannot be empty!");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new Exception("Age must be in range [1 ... 100]");
                }

                this.age = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (value == null && !value.Contains("@"))
                {
                    throw new Exception("Email cannot be empty and should contain '@' character");
                }

                this.email = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {this.Name}\nAge: {this.Age}\nEmail Address: {this.Email ?? "not set"}";
        }
    }
}
