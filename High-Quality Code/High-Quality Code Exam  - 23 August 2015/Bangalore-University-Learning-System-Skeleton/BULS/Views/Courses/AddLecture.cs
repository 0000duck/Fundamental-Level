using System;
using System.Text;
using BangaloreUniversityLearningSystem.Models;

namespace BangaloreUniversityLearningSystem.Views.Courses
{
    public class AddLecture : View
    {
        public AddLecture(Course course)
            : base(course)
        {
        }

        protected override void BuildViewResult(StringBuilder viewResult)
        {
            var course = this.Model as Course;

            viewResult.AppendFormat("Lecture successfully added to course {0}.{1}", course.Name, Environment.NewLine);
        }
    }
}