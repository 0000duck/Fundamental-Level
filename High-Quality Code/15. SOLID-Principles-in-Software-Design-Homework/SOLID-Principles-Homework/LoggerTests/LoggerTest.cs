using Logger;
using Logger.Appenders;
using Logger.Contracts;
using Logger.Layouts;

namespace LoggerTests
{
    class LoggerTest
    {
        static void Main(string[] args)
        {
            var simpleLayout = new SimpleLayout();

            var consoleAppender = new ConsoleAppender(simpleLayout);
            consoleAppender.Threshold = ReportLevel.Error;

            var fileAppender = new FileAppender(simpleLayout);
            fileAppender.File = "log.txt";

            var logger = new Logger.Loggers.Logger(consoleAppender, fileAppender);
            logger.Info("Everything seems fine");
            logger.Warn("Warning: ping is too high - disconnect imminent");
            logger.Error("Error parsing request");
            logger.Critical("No connection string found in App.config");
            logger.Fatal("mscorlib.dll does not respond");
        }
    }
}
