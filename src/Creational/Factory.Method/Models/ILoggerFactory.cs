using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Method.Models
{
    public interface ILoggerFactory
    {
        ILogger CreateLogger();
    }
}
