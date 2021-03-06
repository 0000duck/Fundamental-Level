﻿using _03.CompanyHierarchy.Enums;

namespace _03.CompanyHierarchy.People
{
    abstract class RegularEmployee : Employee
    {
        protected RegularEmployee(int id, string firstName, string lastName, Department department, decimal salary)
           : base(id, firstName, lastName, department, salary)
        {
        }
    }
}