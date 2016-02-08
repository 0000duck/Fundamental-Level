using System;
using Logger.Contracts;

namespace Logger.Layouts
{
    public class SimpleLayout : ILayout
    {
        private const string LayoutFormat = "{0} - {1} - {2}";

        public string Format(string message, ReportLevel reportLevel, DateTime dateTime)
        {
            return string.Format(LayoutFormat + Environment.NewLine, dateTime, reportLevel, message);
        }
    }
}