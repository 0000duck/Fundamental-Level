using System;
using _03.CompanyHierarchy.Enums;

namespace _03.CompanyHierarchy.Interfaces
{
    internal interface IProject
    {
        string ProjectName { get; set; }

        DateTime ProjectStartDate { get; set; }

        string Details { get; set; }

        ProjectState ProjectState { get; }
    }
}