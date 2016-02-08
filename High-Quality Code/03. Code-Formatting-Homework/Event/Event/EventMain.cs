namespace Event
{
    using IO;

    internal class EventMain
    {
        private static readonly EventEngine Engine = EventEngine.GetInstance;

        private static readonly ConsoleRenderer Renderer = ConsoleRenderer.GetInstance;

        public static void Main(string[] args)
        {
            while (EventEngine.ExecuteNextCommand())
            {
            }

            Renderer.PrintMessages();
        }
    }
}