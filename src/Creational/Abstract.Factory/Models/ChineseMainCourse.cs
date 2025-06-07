using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Factory.Models
{
    public class ChineseMainCourse : IMainCourse
    {
        public void Prepare() => Console.WriteLine("Prepare chinese maincourse");
    }
}
