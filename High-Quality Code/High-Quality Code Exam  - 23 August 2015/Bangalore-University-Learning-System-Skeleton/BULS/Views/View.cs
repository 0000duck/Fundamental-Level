﻿using System.Text;
using BangaloreUniversityLearningSystem.Interfaces;

namespace BangaloreUniversityLearningSystem.Views
{
    public abstract class View : IView
    {
        protected View(object model)
        {
            this.Model = model;
        }

        public object Model { get; private set; }

        public string Display()
        {
            var viewResult = new StringBuilder();
            this.BuildViewResult(viewResult);

            return viewResult.ToString().Trim();
        }

        protected abstract void BuildViewResult(StringBuilder viewResult);
    }
}