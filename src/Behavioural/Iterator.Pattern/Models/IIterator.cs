using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Pattern.Models
{
    public interface IIterator
    {
        public Product? First();
        public Product? Next();
        public bool HasNext();
    }
}
