using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Pattern.Models
{
    public interface IObserver
    {
        public void Notify(Order order);
    }
}
