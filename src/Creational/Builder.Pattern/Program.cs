using Builder.Pattern.Models;

namespace Builder.Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Director(new DellDesktopBuilder()).Construct();
            Console.WriteLine("------------------------------------");
            new Director(new HPDesktopBuilder()).Construct();
            Console.WriteLine("------------------------------------");
            new Director(new LenovoDesktopBuilder()).Construct();
        }
    }
}
