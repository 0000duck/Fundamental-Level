using Capitalism.Models;
using Capitalism.Models.Interfaces;
using System.Collections.Generic;

namespace Capitalism.Interfaces
{
    public interface IDatabase
    {
        /// <summary>
        /// Collection of companies.
        /// </summary>
        ICollection<Company> Companies { get; }

        /// <summary>
        /// Collection of total salaries of the employees.
        /// </summary>
        IDictionary<IPaidPerson, decimal> TotalSalaries { get; }
    }
}
