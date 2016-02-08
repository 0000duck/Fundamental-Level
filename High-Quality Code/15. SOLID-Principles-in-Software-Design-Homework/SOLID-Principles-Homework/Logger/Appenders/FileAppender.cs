using System;
using Logger.Contracts;

namespace Logger.Appenders
{
    public class FileAppender : Appender
    {
        public FileAppender(ILayout layout) : base(layout)
        {
        }

        public string File { get; set; }

        public override void Append(string message, ReportLevel reportLevel, DateTime dateTime)
        {
            var formattedMessage = this.Layout.Format(message, reportLevel, dateTime);
            System.IO.File.AppendAllText(this.File, formattedMessage);
        }
    }
}