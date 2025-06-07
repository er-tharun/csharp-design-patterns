using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Factory.Models
{
    public class ChineseDesert : IDesert
    {
        public void Prepare() => Console.WriteLine("Prepare chinese desert");
    }
}
