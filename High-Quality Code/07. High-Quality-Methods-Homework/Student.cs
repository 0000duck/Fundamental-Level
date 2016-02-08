using System;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace Methods
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private string additionalInfo;

        public Student()
        {
        }

        public Student(string firstName, string lastName, string additionalInfo)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AdditionalInfo = additionalInfo;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("firstName", "First name cannot be empty.");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("lastName", "Last name cannot be empty.");
                }

                this.lastName = value;
            }
        }

        public string AdditionalInfo
        {
            get
            {
                return this.additionalInfo;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("additionalInfo", "Additonal info cannot be empty.");
                }

                this.additionalInfo = value;
            }
        }

        public bool IsOlderThan(Student other)
        {
            try
            {
                DateTime thisStudentDateOfBirth = this.GetDateOfBirth(this.AdditionalInfo);
                DateTime otherStudentDateOfBirth = this.GetDateOfBirth(other.AdditionalInfo);

                return thisStudentDateOfBirth < otherStudentDateOfBirth;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new ArgumentException("One or both of the students has invalid date of birth information provided.");
            } 
        }

        public DateTime GetDateOfBirth(string info)
        {
            string[] paramArgs = info.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            string dateInfo = paramArgs.Last().Substring(8).Trim();

            if (!IsValidBulgarianFormatDate(dateInfo))
            {
                throw new FormatException("Invalid date format.");
            }

            DateTime date = DateTime.Parse(dateInfo);

            return date;
        }

        private static bool IsValidBulgarianFormatDate(string dateInfo)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            DateTime date;
            bool isValiDate = DateTime.TryParse(dateInfo, out date);

            return isValiDate;
        }
    }
}
