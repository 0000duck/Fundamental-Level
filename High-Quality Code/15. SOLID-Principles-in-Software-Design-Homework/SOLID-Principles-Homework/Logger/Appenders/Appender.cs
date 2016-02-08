using System;
using Logger.Contracts;

namespace Logger.Appenders
{
    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ReportLevel Threshold { get; set; }

        public ILayout Layout { get; set; }

        public abstract void Append(string message, ReportLevel reportLevel, DateTime dateTime);
    }
}