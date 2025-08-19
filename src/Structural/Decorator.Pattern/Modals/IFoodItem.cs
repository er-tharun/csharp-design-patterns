using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Pattern.Modals
{
    public interface IFoodItem
    {
        string GetDescription();
        double GetPrice();
    }
}
