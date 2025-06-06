using Factory.Method.Models;

namespace Factory.Method
{
    public class Program
    {
        static void Main(string[] args)
        {
            ILogger debugLog = new DebugLoggerFactory().CreateLogger();
            ILogger infoLog = new InfoLoggerFactory().CreateLogger();
            ILogger errorLog = new ErrorLoggerFactory().CreateLogger();
            debugLog.Log("test for debug log");
            infoLog.Log("test for info log");
            errorLog.Log("test for error logger");
        }
    }
}
