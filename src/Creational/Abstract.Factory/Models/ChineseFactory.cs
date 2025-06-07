using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Factory.Models
{
    public class ChineseFactory : IFactory
    {
        public IDesert Desert() => new ChineseDesert();

        public IMainCourse MainCourse() => new ChineseMainCourse();

        public IStarter Starter() => new ChineseStarter();
    }
}
