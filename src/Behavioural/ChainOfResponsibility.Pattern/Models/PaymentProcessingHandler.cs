using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Pattern.Models
{
    public class PaymentProcessingHandler : OrderHandler
    {
        public PaymentProcessingHandler(OrderHandler nextHandler):base(nextHandler) { }
        public override void ProcessRequest(Guid id)
        {
            Console.WriteLine("Payment processing Handler for id : " + id);
            if(nextHandler is not null)
                nextHandler.ProcessRequest(id);
        }
    }
}
