using System;
using System.Globalization;
using System.Threading;

namespace Theatre
{
    public class TheatreMain
    {
        private static readonly CommandManager CommandManager = new CommandManager();

        protected static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string data;
            while ((data = Console.ReadLine()) != null)
            {
                if (data == string.Empty)
                {
                    continue;
                }

                string output;
                try
                {
                    output = CommandManager.CommandExecute(data);
                }
                catch (Exception ex)
                {
                    output = "Error: " + ex.Message;
                }

                Console.WriteLine(output);
            }
        }
    }
}