using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Pattern.Models
{
    public class Customer : IObserver
    {
        private string _customerName;
        public Customer(string name)
        {
            _customerName = name;
        }
        public void Notify(Order order) => Console.WriteLine($"Hi Notification triggered to CustomerName : {_customerName} for OrderId : {order.Id} ");
    }
}
