using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Pattern.Models
{
    public class CustomerCare : IObserver
    {
        public void Notify(Order order) => Console.WriteLine($"Notification triggered to CustomerCare for Orderid : {order.Id}");
    }
}
