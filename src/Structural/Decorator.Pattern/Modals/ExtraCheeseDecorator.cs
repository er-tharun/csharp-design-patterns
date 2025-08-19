using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Pattern.Modals
{
    public class ExtraCheeseDecorator : FoodDecorator
    {
        private readonly double _price;
        public ExtraCheeseDecorator(IFoodItem foodItem, double price) : base(foodItem)
        {
            _price = price;
        }

        public override string GetDescription() => $"{base.GetDescription()} with extra cheese";

        public override double GetPrice() => base.GetPrice() + _price;
    }
}
