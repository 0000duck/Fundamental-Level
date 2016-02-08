using System.Collections.Generic;

namespace Capitalism.Models.Interfaces
{
    public interface IBoss
    {
        /// <summary>
        /// Collection of subordinate employees.
        /// </summary>
        ICollection<IEmployee> SubordinateEmployees { get; }
    }
}
