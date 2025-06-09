using Iterator.Pattern.Models;

namespace Iterator.Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            inventory.AddProduct(new Product { Name= "iphone 16", Price = 699.00 });
            inventory.AddProduct(new Product { Name = "iphone 16 pro", Price = 999.00 });
            inventory.AddProduct(new Product { Name = "iphone 16 pro max", Price = 1299.00 });

            IIterator iterator = inventory.GetIterator();

            Product currentProduct = iterator.First();

            while(currentProduct != null)
            {
                Console.WriteLine(currentProduct.Name + "-----------" + currentProduct.Price);
                currentProduct = iterator.Next();
            }
        }
    }
}
