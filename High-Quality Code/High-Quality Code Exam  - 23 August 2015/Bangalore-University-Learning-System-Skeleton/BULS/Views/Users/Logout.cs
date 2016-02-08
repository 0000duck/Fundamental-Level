using System;
using System.Text;
using BangaloreUniversityLearningSystem.Models;

namespace BangaloreUniversityLearningSystem.Views.Users
{
    public class Logout : View
    {
        public Logout(User user)
            : base(user)
        {
        }

        protected override void BuildViewResult(StringBuilder viewResult)
        {
            var usermodel = this.Model as User;
            viewResult.AppendFormat("User {0} logged out successfully.{1}", usermodel.Username, Environment.NewLine);
        }
    }
}