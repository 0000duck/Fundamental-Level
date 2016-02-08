using System;

namespace BangaloreUniversityLearningSystem.Models
{
    public class Lecture
    {
        private string name;

        public Lecture(string name)
        {
            // BUG: Property called itself
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == null || value.Length < 3)
                {
                    throw new ArgumentException("The lecture name must be at least 3 symbols long.");
                }

                this.name = value;
            }
        }
    }
}