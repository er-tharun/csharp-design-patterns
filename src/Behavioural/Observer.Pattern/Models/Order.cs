using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Pattern.Models
{
    public class Order
    {
        private IList<IObserver> _observers;
        private OrderStatus _status;
        public Guid Id { get; set; }
        public Order()
        {
            _observers = new List<IObserver>();
            Id = Guid.NewGuid();
            this.SetStatus(OrderStatus.New);
        }

        public void Attach(IObserver observer) => _observers.Add(observer);
        public void Detach(IObserver observer) => _observers.Remove(observer);

        public void SetStatus(OrderStatus status)
        {
            this._status = status;
            this.Notify();
        }

        private void Notify()
        {
            foreach (var item in _observers)
            {
                item.Notify(this);
            }
        }
    }
}
