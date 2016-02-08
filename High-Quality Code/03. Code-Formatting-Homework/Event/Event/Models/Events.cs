namespace Event.Models
{
    using System;
    using System.Text;

    public class Events : IComparable
    {
        private readonly string title;
        private readonly string location;
        private DateTime date;

        public Events(DateTime date, string title, string location)
        {
            this.Date = date;
            this.Title = title;
            this.Location = location;
        }

        public DateTime Date { get; set; }

        public string Title { get; set; }

        public string Location { get; set; }

        public int CompareTo(object obj)
        {
            Events otherEvent = obj as Events;

            if (otherEvent.Equals(null))
            {
                throw new ArgumentNullException("otherEvent", "OtherEvent cannot be null.");
            }

            int comparedByDate = this.Date.CompareTo(otherEvent.Date);
            int comparedByTitleTitle = string.Compare(this.Title, otherEvent.Title, StringComparison.Ordinal);
            var comparedByLocation = string.Compare(this.Location, otherEvent.Location, StringComparison.Ordinal);

            if (comparedByDate == 0)
            {
                return comparedByTitleTitle == 0 ? comparedByLocation : comparedByTitleTitle;
            }

            return comparedByDate;
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.Append(this.date.ToString("yyyy-MM-ddTHH:mm:ss"));
            toString.Append(" | " + this.title);

            if (!string.IsNullOrEmpty(this.location))
            {
                toString.Append(" | " + this.location);
            }

            return toString.ToString();
        }
    }
}