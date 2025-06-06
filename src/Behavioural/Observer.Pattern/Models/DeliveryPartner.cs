using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Pattern.Models
{
    public class DeliveryPartner : IObserver
    {
        private string _deliverPartnerName;
        public DeliveryPartner(string name)
        {
            this._deliverPartnerName = name;
        }
        public void Notify(Order order) => Console.WriteLine($"Notification triggered to DeliveryPartner {_deliverPartnerName} for Orderid {order.Id}");
    }
}
