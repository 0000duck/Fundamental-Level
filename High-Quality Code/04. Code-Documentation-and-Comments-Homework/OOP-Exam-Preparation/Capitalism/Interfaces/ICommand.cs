using System.Collections.Generic;

namespace Capitalism.Interfaces
{
    public interface ICommand
    {
        /// <summary>
        /// Property for the name of the command
        /// </summary>
        string Name { get; }

        /// <summary>
        /// List for command parameters.
        /// </summary>
        IList<string> Parameters { get; }
    }
}
