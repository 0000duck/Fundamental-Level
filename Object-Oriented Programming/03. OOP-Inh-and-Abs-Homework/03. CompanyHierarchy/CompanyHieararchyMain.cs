using System;
using _03.CompanyHierarchy.Enums;
using _03.CompanyHierarchy.People;
using _03.CompanyHierarchy.Projects;

namespace _03.CompanyHierarchy
{
    class CompanyHieararchyMain
    {
        static void Main(string[] args)
        {
            SalesEmployee retailer = new SalesEmployee(12, "Ivan", "Ivanov", Department.Marketing, 500, new Sale("notebook", 340));

            Employee[] employees =
            {
                retailer,
                new Manager(28882, "Mlad", "Marinjay", Department.Marketing, 5500, retailer),
                new Developer(534, "Angel", "Georgiev", Department.Production, 2300, new Project("Code")),
                new SalesEmployee(342, "Stoqn", "Ivanov", Department.Accounting, 1200, new Sale("Neshto", 0)),
            };

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
