using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Factory.Models
{
    public class IndianFactory : IFactory
    {
        public IDesert Desert() => new IndianDesert();

        public IMainCourse MainCourse() => new IndianMainCourse();

        public IStarter Starter() => new IndianStarter();
    }
}
