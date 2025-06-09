using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Pattern.Models
{
    public class ProductIterator : IIterator
    {
        private IList<Product> _products;
        private int _current;
        public ProductIterator(List<Product> products)
        {
            _products = products;
            _current = 0;
        }
        public Product? First()
        {
            if (_products.Count == 0)
                return null;
            return _products[0];
        }

        public bool HasNext() => _current < _products.Count;

        public Product? Next()
        {
            if(this.HasNext())
                return _products[_current++];
            return null;
        }
    }
}
