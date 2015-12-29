namespace Capitalism.Interfaces
{
    public interface ICommandExecutor
    {
        //TODO: Should this return string(command result)?

        string ExecuteCommand(ICommand command);
    }
}