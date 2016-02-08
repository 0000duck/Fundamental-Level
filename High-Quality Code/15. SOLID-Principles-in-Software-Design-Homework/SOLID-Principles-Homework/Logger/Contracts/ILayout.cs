using System;

namespace Logger.Contracts
{
    public interface ILayout
    {
        string Format(string message, ReportLevel reportLevel, DateTime dateTime);
    }
}