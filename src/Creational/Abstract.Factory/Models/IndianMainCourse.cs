using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Factory.Models
{
    public class IndianMainCourse : IMainCourse
    {
        public void Prepare() => Console.WriteLine("Prepare indian main course");
    }
}
