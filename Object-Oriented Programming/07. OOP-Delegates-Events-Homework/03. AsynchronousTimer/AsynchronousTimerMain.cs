using System;

namespace _03.AsynchronousTimer
{
    class AsynchronousTimerMain
    {
        static void Main(string[] args)
        {
            var async = new AsyncTimer(Console.WriteLine, 10, 1000);
            async.Run();
        }
    }
}
