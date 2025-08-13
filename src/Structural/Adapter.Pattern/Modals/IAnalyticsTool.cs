using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Pattern.Modals
{
    public interface IAnalyticsTool
    {
        void AnalyzeData(string data);
    }
}
