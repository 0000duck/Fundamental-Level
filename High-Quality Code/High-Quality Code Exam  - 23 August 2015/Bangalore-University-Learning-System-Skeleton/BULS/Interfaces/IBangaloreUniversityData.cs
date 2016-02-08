using BangaloreUniversityLearningSystem.Data;
using BangaloreUniversityLearningSystem.Models;

namespace BangaloreUniversityLearningSystem.Interfaces
{
    public interface IBangaloreUniversityData
    {
        UsersRepository Users { get; }

        IRepository<Course> Courses { get; }
    }
}