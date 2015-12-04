using System.Collections.Generic;

namespace _03.CompanyHierarchy.Interfaces
{
    internal interface ISalesEmployee
    {
        List<ISale> Sales { get; }  
    }
}