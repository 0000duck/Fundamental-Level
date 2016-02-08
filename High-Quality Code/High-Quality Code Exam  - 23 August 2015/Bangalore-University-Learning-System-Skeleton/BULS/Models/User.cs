using System;
using System.Collections.Generic;
using BangaloreUniversityLearningSystem.Utilities;

namespace BangaloreUniversityLearningSystem.Models
{
    public class User
    {
        private string username;
        private string password;

        public User(string username, string password, Role role)
        {
            this.Username = username;
            this.Password = password;
            this.Role = role;
            this.Courses = new HashSet<Course>();
        }

        public string Username
        {
            get
            {
                return this.username;
            }

            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentException("The username must be at least 5 symbols long.");
                }

                this.username = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }

            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 6)
                {
                    throw new ArgumentException("The password must be at least 6 symbols long.");
                }

                var hashedPassword = HashUtilities.HashPassword(value);

                this.password = hashedPassword;
            }
        }

        public Role Role { get; private set; }

        public ISet<Course> Courses { get; private set; }

        public void EnrollCourse(Course course)
        {
            this.Courses.Add(course);
        }
    }
}