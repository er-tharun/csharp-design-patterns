using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Pattern.Modals
{
    public class XMLtoJSONAdaptor
    {
        private IAnalyticsTool _analyticsTool;
        public XMLtoJSONAdaptor(IAnalyticsTool analyticsTool, string data)
        {
            _analyticsTool = analyticsTool;
            _analyticsTool.AnalyzeData(ConvertData(data));
        }

        private string ConvertData(string data) => data.Contains("json", StringComparison.OrdinalIgnoreCase) ? data : $"{data} json";
    }
}
