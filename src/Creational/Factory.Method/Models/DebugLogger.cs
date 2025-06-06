using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Method.Models
{
    public class DebugLogger : ILogger
    {
        public void Log(string message) => Console.WriteLine($"{nameof(DebugLogger)}---{message}");
    }
}
