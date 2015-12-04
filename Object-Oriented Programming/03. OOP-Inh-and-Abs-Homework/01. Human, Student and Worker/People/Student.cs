using System;
using _01.Human__Student_and_Worker.Interfaces;

namespace _01.Human__Student_and_Worker.People
{
    public class Student : Human, IHuman
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Faculty number cannot be empty");
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "Faculty Number : " + this.facultyNumber + Environment.NewLine;
        }
    }
}