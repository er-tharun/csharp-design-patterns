using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Pattern.Models
{
    public class Resturant : IObserver
    {
        private string _resturantName;
        public Resturant(string name)
        {
            this._resturantName = name;
        }
        public void Notify(Order order) => Console.WriteLine($"Notification triggered to resturantname : {this._resturantName} for orderid {order.Id}");
    }
}
