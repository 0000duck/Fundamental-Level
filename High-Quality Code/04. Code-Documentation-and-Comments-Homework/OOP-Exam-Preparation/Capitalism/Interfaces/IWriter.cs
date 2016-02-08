namespace Capitalism.Interfaces
{
    public interface IWriter
    {
        /// <summary>
        /// Method for writing the info to the output.
        /// </summary>
        /// <param name="output">
        /// String to be output.
        /// </param>
        void WriteLine(string output);

        /// <summary>
        /// Method for writing the info to the output.
        /// </summary>
        /// <param name="format">
        /// Format of the text.
        /// </param>
        /// <param name="args">
        /// Arguments
        /// </param>
        void WriteLine(string format, params object[] args);
    }
}
