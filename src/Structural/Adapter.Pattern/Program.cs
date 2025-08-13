using Adapter.Pattern.Modals;

namespace Adapter.Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = "Hello world";
            new JSONAnalyticsTool().AnalyzeData(data);
            Console.WriteLine("---------------------------------------");
            new XMLtoJSONAdaptor(new JSONAnalyticsTool(), data);
        }
    }
}
