using System.Collections.Generic;

namespace BangaloreUniversityLearningSystem.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();

        T Get(int id);

        void Add(T user);
    }
}