namespace Event.Factories
{
    using System.Text;
    using Models;

    public static class Messages
    {
        public static readonly StringBuilder Output = new StringBuilder();

        public static void EventAdded()
        {
            Output.Append("Events added\n");
        }

        public static void EventDeleted(int x)
        {
            if (x == 0)
            {
                NoEventsFound();
            }
            else
            {
                Output.AppendFormat("{0} events deleted\n", x);
            }
        }

        public static void NoEventsFound()
        {
            Output.Append("No events found\n");
        }

        public static void PrintEvent(Events eventToPrint)
        {
            if (eventToPrint != null)
            {
                Output.Append(eventToPrint + "\n");
            }
        }
    }
}