using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Pattern.Modals
{
    public abstract class FoodDecorator:IFoodItem
    {
        protected IFoodItem _foodItem;
        public FoodDecorator(IFoodItem foodItem)
        {
            this._foodItem = foodItem;
        }

        public virtual string GetDescription()
        {
            return _foodItem.GetDescription();
        }

        public virtual double GetPrice()
        {
            return _foodItem.GetPrice();
        }
    }
}
