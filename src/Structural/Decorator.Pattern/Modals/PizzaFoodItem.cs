using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Pattern.Modals
{
    public class PizzaFoodItem : IFoodItem
    {
        public string GetDescription() => "Pizza food item";

        public double GetPrice() => 200.00;
    }
}
