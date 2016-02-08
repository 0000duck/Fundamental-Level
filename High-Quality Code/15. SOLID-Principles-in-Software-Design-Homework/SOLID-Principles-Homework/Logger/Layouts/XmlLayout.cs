using System;
using Logger.Contracts;

namespace Logger.Layouts
{
    public class XmlLayout : ILayout
    {
        private const string LayoutFormat = "<log>\n   <date>{0}</date>\n   <level>{1}</level>\n   <message>{2}</message>\n</log>";

        public string Format(string message, ReportLevel reportLevel, DateTime dateTime)
        {
            return string.Format(LayoutFormat, dateTime, reportLevel, message);
        }
    }
}