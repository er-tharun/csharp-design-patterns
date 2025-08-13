using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace Adapter.Pattern.Modals
{
    public class JSONAnalyticsTool : IAnalyticsTool
    {

        public void AnalyzeData(string data)
        {
            if(data.Contains("json", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Analyzed the input data " + data);
            }
            else
            {
                Console.WriteLine("Data format not supported");
            }
        }
    }
}
