namespace Capitalism.Models.Interfaces
{
    public interface IPaidPerson: IPerson
    {
        /// <summary>
        /// Salary of the person
        /// </summary>
        decimal Salary { get; set; }
    }
}
