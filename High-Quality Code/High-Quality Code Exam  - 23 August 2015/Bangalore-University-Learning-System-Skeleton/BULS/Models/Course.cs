using System;
using System.Collections.Generic;

namespace BangaloreUniversityLearningSystem.Models
{
    public class Course
    {
        private string name;

        public Course(string name)
        {
            this.Name = name;
            this.Lectures = new HashSet<Lecture>();
            //// POSSIBLE BUGFIX: initialized list
            this.Students = new HashSet<User>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentException("The course name must be at least 5 symbols long.");
                }

                this.name = value;
            }
        }

        public ISet<Lecture> Lectures { get; set; }

        public ISet<User> Students { get; set; }

        public void AddLecture(Lecture lecture)
        {
            this.Lectures.Add(lecture);
        }

        public void AddStudent(User student)
        {
            this.Students.Add(student);
            student.Courses.Add(this);
        }
    }
}