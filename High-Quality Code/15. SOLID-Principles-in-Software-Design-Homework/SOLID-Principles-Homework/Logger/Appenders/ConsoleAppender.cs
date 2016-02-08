using System;
using Logger.Contracts;

namespace Logger.Appenders
{
    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout) : base(layout)
        {
        }

        public override void Append(string message, ReportLevel reportLevel, DateTime dateTime)
        {
            if (this.Threshold <= reportLevel)
            {
                var formattedMessage = this.Layout.Format(message, reportLevel, dateTime);
                Console.WriteLine(formattedMessage);
            }
        }
    }
}