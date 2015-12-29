using System;
using System.Threading;

namespace _03.AsynchronousTimer
{
    public class AsyncTimer
    {
        private int ticks;
        private int interval;


        public AsyncTimer(Action<string> action, int ticks, int interval)
        {
            this.Action = action;
            this.Ticks = ticks;
            this.Interval = interval;
        }

        public Action<string> Action { get; private set; }

        public int Ticks
        {
            get { return this.ticks; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value can't be negative");
                }

                this.ticks = value;
            }
        }

        public int Interval
        {
            get
            {
                return this.interval;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value can't be negative");
                }

                this.interval = value;
            }
        }

        public void Run()
        {
            var parallel = new Thread(this.Execute);
            parallel.Start();
        }

        public void Execute()
        {
            for (int i = 0; i < this.ticks; i++)
            {
                Thread.Sleep(this.interval);
                Console.WriteLine("Tick");
            }
        }
    }
}