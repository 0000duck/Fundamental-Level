using System.Collections.Generic;

namespace Capitalism.Models.Interfaces
{
    public interface ICompanyStructure
    {
        /// <summary>
        /// Name of the company
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Collection of employees
        /// </summary>
        ICollection<IEmployee> Employees { get; }
    }
}
