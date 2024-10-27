using log4net;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config")]

namespace Milestone7Assessment
{
    internal class _7BasicLogLog4Net
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            Console.WriteLine("Started logging");
            logger.Info("Application started");
            logger.Info("Performing operation");
            logger.Info("Application ended");
            Console.WriteLine("Ended logging");
        }
    }
}
