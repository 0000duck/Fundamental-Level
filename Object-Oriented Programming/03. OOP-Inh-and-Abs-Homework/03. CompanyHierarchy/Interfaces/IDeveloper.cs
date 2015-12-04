using System.Collections.Generic;

namespace _03.CompanyHierarchy.Interfaces
{
    internal interface IDeveloper
    {
         List<IProject> Projects { get; } 
    }
}