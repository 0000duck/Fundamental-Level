using System.Collections.Generic;

namespace _03.CompanyHierarchy.Interfaces
{
    internal interface IManager
    {
         List<IEmployee> EmployeesManaged { get; } 
    }
}