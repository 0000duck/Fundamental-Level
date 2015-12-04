using _03.CompanyHierarchy.Enums;

namespace _03.CompanyHierarchy.Interfaces
{
    internal interface IEmployee
    {
        Department Department { get; set; }

        decimal Salary { get; set; }
    }
}