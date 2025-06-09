using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Pattern.Models
{
    public class Inventory
    {
        private IList<Product> _products;

        public Inventory()
        {
            _products = new List<Product>();
        }

        public void AddProduct(Product product) => _products.Add(product);

        public IIterator GetIterator() => new ProductIterator(_products.ToList());
    }
}
