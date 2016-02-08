namespace Capitalism.Models.Interfaces
{
    public interface IEmployee : IPaidPerson
    {
        /// <summary>
        /// Department of the employee
        /// </summary>
        Department Department { get; set; }

        /// <summary>
        /// Salary calculation for the employee
        /// </summary>
        double SalaryFactor { get; }
    }
}