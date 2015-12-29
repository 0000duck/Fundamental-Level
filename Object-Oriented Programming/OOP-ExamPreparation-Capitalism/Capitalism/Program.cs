using Capitalism.Execution;
using Capitalism.Interfaces;

namespace Capitalism
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IEngine engine = new CapitalismEngine();
            engine.Run();
        }
    }
}
