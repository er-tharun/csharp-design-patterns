using Prototype.Pattern.Models;

namespace Prototype.Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPrototype product = new Product("iPhone pro 16 max", 199999.00, "Apple iphone pro 16 max with 16GB RAM & 2TB Internal storage", 4.6, "MobilePhone");

            IPrototype clonedProduct =  product.Clone();

            Console.WriteLine(product.GetHashCode());
            Console.WriteLine(clonedProduct.GetHashCode());
        }
    }
}
