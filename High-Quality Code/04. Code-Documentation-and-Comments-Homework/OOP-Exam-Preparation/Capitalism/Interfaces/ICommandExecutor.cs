namespace Capitalism.Interfaces
{
    public interface ICommandExecutor
    {
        /// <summary>
        /// Method for executing a command.
        /// </summary>
        /// <param name="command"></param>
        /// <returns>
        /// String
        /// </returns>
        string ExecuteCommand(ICommand command);
    }
}
