using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Pattern.Modals
{
    public class ExtraSauceDecortor : FoodDecorator
    {
        private readonly double _price;
        public ExtraSauceDecortor(IFoodItem foodItem, double price):base(foodItem)
        {
            _price = price;
        }
        public override string GetDescription() => $"{base.GetDescription()} with extra sauce";
        public override double GetPrice() => base.GetPrice() + _price;
    }
}
