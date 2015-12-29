using System.Collections.Generic;

namespace Blobs.Interfaces
{
    public interface ICommand
    {
        string Name { get; }

        IList<string> Parameters { get; }
    }
}