namespace Event.Factories
{
    using System;
    using System.Linq;
    using Models;
    using Wintellect.PowerCollections;

    public sealed class EventHolder
    {
        private static readonly MultiDictionary<string, Events> EventsByTitle = new MultiDictionary<string, Events>(true);
        private static readonly OrderedMultiDictionary<DateTime, Events> EventsByDate = new OrderedMultiDictionary<DateTime, Events>(true);

        public EventHolder()
        {
        }

        public static EventHolder GetInstance
        {
            get
            {
                return EventHolderImplementation.Instance;
            }
        }

        public void AddEventToDatabases(DateTime date, string title, string location)
        {
            Events newEvent = new Events(date, title, location);
            string eventTitleLowerCase = newEvent.Title.ToLowerInvariant();

            EventsByTitle.Add(eventTitleLowerCase, newEvent);
            EventsByDate.Add(newEvent.Date, newEvent);

            Messages.EventAdded();
        }

        public void DeleteEventFromDatabases(string eventTitle)
        {
            string eventTitleLowerCase = eventTitle.ToLowerInvariant();
            var eventsToDelete = EventsByTitle[eventTitleLowerCase];
            int deletedCount = eventsToDelete.Count;

            foreach (Events e in eventsToDelete)
            {
                EventsByDate.Remove(e.Date, e);
            }

            EventsByTitle.Remove(eventTitleLowerCase);

            Messages.EventDeleted(deletedCount);
        }

        public void ListEvents(DateTime date, int count)
        {
            var matchedEvents = from e in EventsByDate.RangeFrom(date, true).Values select e;

            int showed = 0;

            foreach (var eventToShow in matchedEvents.TakeWhile(eventToShow => showed != count))
            {
                Messages.PrintEvent(eventToShow);
                showed++;
            }

            if (showed == 0)
            {
                Messages.NoEventsFound();
            }
        }

        private static class EventHolderImplementation
        {
            internal static readonly EventHolder Instance = new EventHolder();
        }
    }
}