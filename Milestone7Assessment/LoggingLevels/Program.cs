using System;
using System.Runtime.ConstrainedExecution;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config")]

namespace LoggingLevels
{
    internal class Program
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            logger.Info("Application started");
            logger.Warn("Low disk space");
            logger.Error("An error occured during processing");
        }
    }
}