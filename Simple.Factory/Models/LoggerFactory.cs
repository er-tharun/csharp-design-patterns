using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Factory.Models
{
    public class LoggerFactory
    {
        public static ILogger CreateLogger(LogType type)
        {
            if (type == LogType.Debug)
                return new DebugLog();
            else if (type == LogType.Error)
                return new ErrorLog();
            else if (type == LogType.Information)
                return new InformationLog();
            else
                throw new NotSupportedException("Log type not supported");
        }
    }
}
