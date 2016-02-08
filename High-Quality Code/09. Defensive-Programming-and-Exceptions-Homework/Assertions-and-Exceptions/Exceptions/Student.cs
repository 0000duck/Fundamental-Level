using System;
using System.Collections.Generic;
using System.Linq;
using Exceptions_Homework.Exams;

namespace Exceptions_Homework
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private IList<Exam> exams;

        public Student(string firstName, string lastName, IList<Exam> exams)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Exams = exams;
        }

        public Student(string firstName, string lastName)
        : this(firstName, lastName, new List<Exam>())
        {
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
        public IList<Exam> Exams
        {
            get
            {
                return this.exams;
            }
            private set
            {
                if (this.exams == null)
                {
                    throw new ArgumentNullException("exams", "Exams cannot be null.");
                }

                this.exams = value;
            }
        }

        public IList<ExamResult> CheckExams()
        {
            return this.Exams.Select(t => t.Check()).ToList();
        }

        public double CalculateAverageExamResultInPercents()
        {
            if (this.Exams.Count == 0)
            {
                throw new InvalidOperationException("Cannot calculate average on missing exams.");
            }

            double[] examScore = new double[this.Exams.Count];

            IList<ExamResult> examResults = this.CheckExams();
            for (int i = 0; i < examResults.Count; i++)
            {
                int gradeRange = examResults[i].Grade - examResults[i].MinGrade;
                double normalizedGrade = examResults[i].MaxGrade - examResults[i].MinGrade;

                examScore[i] = gradeRange / normalizedGrade;
            }

            return examScore.Average();
        }
    }
}