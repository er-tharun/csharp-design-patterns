using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Pattern.Modals
{
    public class BurgerFoodItem : IFoodItem
    {
        public string GetDescription() => "Burger food item";

        public double GetPrice() => 185.00;
    }
}
