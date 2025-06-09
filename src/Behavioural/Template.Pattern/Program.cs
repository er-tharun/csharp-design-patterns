using Template.Pattern.Models;

namespace Template.Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new NationalDevlivery().ProcessOrder();
            Console.WriteLine("-------------------------------------");
            new InternationalDelivery().ProcessOrder();
        }
    }
}
