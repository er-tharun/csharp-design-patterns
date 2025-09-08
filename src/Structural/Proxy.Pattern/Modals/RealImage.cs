using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Pattern.Modals
{
    public class RealImage : IImage
    {
        private readonly string _name;
        public RealImage(string name)
        {
            _name = name;
            LoadFromDisk();
        }
        public void Display()
        {
            Console.WriteLine($"Displaying {_name} from memory");
        }

        private void LoadFromDisk()
        {
            Console.WriteLine($"Loading {_name} from disk to in-memory");
        }
    }
}
