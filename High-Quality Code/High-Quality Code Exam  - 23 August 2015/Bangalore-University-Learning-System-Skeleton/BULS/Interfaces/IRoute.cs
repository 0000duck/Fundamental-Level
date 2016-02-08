using System.Collections.Generic;

namespace BangaloreUniversityLearningSystem.Interfaces
{
    public interface IRoute
    {
        string ControllerName { get; }

        string ActionName { get; }

        IDictionary<string, string> Parameters { get; }
    }
}