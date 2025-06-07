using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Factory.Models
{
    public class FoodFactory
    {
        public static IFactory CreateFactory(FoodType foodType)
        {
            if (foodType == FoodType.Chinese)
                return new ChineseFactory();
            else if (foodType == FoodType.Indian)
                return new IndianFactory();
            else
                return null;
        }
    }
}
