using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Factory.Models
{
    public class IndianStarter : IStarter
    {
        public void Prepare() => Console.WriteLine("Prepare Indian Starter");
    }
}
