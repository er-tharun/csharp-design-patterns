using Simple.Factory.Models;

namespace Simple.Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger debug = LoggerFactory.CreateLogger(LogType.Debug);
            ILogger error = LoggerFactory.CreateLogger(LogType.Error);
            ILogger info = LoggerFactory.CreateLogger(LogType.Information);

            debug.Log("debug log");
            error.Log("error log");
            info.Log("info log");
        }
    }
}
