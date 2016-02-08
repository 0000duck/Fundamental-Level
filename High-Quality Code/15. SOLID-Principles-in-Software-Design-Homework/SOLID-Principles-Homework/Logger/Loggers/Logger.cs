using System;
using System.Collections.Generic;
using Logger.Contracts;

namespace Logger.Loggers
{
    public class Logger : ILogger
    {
        public Logger(params IAppender[] appenders)
        {
            this.Appenders = new List<IAppender>(appenders);
        }

        public IList<IAppender> Appenders { get; private set; }

        public void Info(string msg)
        {
            this.Log(msg, ReportLevel.Info);
        }

        public void Warn(string msg)
        {
            this.Log(msg, ReportLevel.Warn);
        }

        public void Error(string msg)
        {
            this.Log(msg, ReportLevel.Error);
        }

        public void Critical(string msg)
        {
            this.Log(msg, ReportLevel.Critical);
        }

        public void Fatal(string msg)
        {
            this.Log(msg, ReportLevel.Fatal);
        }

        private void Log(string msg, ReportLevel reportLevel)
        {
            foreach (var appender in this.Appenders)
            {
                var dateTime = DateTime.Now;
                appender.Append(msg, reportLevel, dateTime);
            }
        }
    }
}