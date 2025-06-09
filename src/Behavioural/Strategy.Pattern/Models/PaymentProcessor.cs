using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Pattern.Models
{
    public class PaymentProcessor
    {
        private IPaymentStrategy _paymentStrategy;
        public PaymentProcessor()
        {
        }

        public void SetStrategy(IPaymentStrategy strategy)
        {
            if (_paymentStrategy is not null)
                _paymentStrategy = null;
            _paymentStrategy = strategy;
        }

        public void ProcessPayment(double amount)
        {
            if (_paymentStrategy is not null)
                _paymentStrategy.ProcessPayment(amount);
            else
                throw new NotSupportedException("Invalid Payment strategy");
        }
    }
}
