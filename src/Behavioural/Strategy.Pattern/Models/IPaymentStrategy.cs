using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Pattern.Models
{
    public interface IPaymentStrategy
    {
        void ProcessPayment(double amount);
    }
}
