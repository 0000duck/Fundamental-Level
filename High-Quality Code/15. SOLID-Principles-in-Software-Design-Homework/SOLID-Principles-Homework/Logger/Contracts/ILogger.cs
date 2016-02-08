using System.Collections.Generic;

namespace Logger.Contracts
{
    public interface ILogger
    {
        IList<IAppender> Appenders { get; }

        void Info(string msg);

        void Warn(string msg);

        void Error(string msg);

        void Critical(string msg);

        void Fatal(string msg);
    }
}