using System;
using System.Collections.Generic;
using System.Text;
using _03.CompanyHierarchy.Enums;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.People
{
    class Developer : RegularEmployee, IDeveloper
    {
        public Developer(int id, string firstName, string lastName, Department department, decimal salary,
            List<IProject> projects) : base(id, firstName, lastName, department, salary)
        {
            this.Projects = projects;
        }

        public Developer(int id, string firstName, string lastName, Department department, decimal salary, IProject project)
            : this(id, firstName, lastName, department, salary, new List<IProject>() { project })
        {
        }

        public List<IProject> Projects { get; private set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(base.ToString());
            output.AppendFormat("Role: Sales Employee{0}", Environment.NewLine);
            output.Append("Projects: ");
            List<string> projectNames = new List<string>();
            foreach (var proj in this.Projects)
            {
                projectNames.Add(proj.ProjectName);
            }
            output.Append(String.Join(", ", projectNames) + Environment.NewLine);

            return output.ToString();
        }
    }
}