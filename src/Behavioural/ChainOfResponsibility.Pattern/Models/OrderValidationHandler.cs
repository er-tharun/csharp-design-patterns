using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Pattern.Models
{
    public class OrderValidationHandler : OrderHandler
    {
        public OrderValidationHandler(OrderHandler nextHandler):base(nextHandler)
        {
        }
        public override void ProcessRequest(Guid id)
        {
            Console.WriteLine("Order validation Successful : "+id);
            if (nextHandler is not null)
            {
                nextHandler.ProcessRequest(id);
            }
        }
    }
}
