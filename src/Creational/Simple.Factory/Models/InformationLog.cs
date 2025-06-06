using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Factory.Models
{
    public class InformationLog : ILogger
    {
        public void Log(string message) => Console.WriteLine(message);
    }
}
