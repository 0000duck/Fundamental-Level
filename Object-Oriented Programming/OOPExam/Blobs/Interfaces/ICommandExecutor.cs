namespace Blobs.Interfaces
{
    public interface ICommandExecutor
    {
        void ExecuteCommand(ICommand command);
    }
}