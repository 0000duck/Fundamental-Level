namespace Capitalism.Interfaces
{
    public interface IWriter
    {
        void Write(string output);

        void WriteLine(string format, params object[] args);
    }
}