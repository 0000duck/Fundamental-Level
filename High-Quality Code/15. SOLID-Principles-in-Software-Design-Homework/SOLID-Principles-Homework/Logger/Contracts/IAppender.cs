using System;

namespace Logger.Contracts
{
    public interface IAppender
    {
        ReportLevel Threshold { get; set; }

        ILayout Layout { get; set; }

        void Append(string message, ReportLevel reportLevel, DateTime dateTime);
    }
}