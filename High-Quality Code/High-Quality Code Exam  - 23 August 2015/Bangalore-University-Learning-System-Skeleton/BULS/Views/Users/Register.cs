using System;
using System.Text;
using BangaloreUniversityLearningSystem.Models;

namespace BangaloreUniversityLearningSystem.Views.Users
{
    public class Register : View
    {
        public Register(User user)
            : base(user)
        {
        }

        protected override void BuildViewResult(StringBuilder viewResult)
        {
            var userModel = this.Model as User;

            viewResult.AppendFormat("User {0} registered successfully.{1}", userModel.Username, Environment.NewLine);
        }
    }
}