using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Pattern.Models
{
    public class OrderDeliveryHandler : OrderHandler
    {
        public OrderDeliveryHandler(OrderHandler nextHandler) : base(nextHandler)
        {
            
        }
        public override void ProcessRequest(Guid id)
        {
            Console.WriteLine("Order Deliver Handler : "+ id);
            if(nextHandler is not null)
                nextHandler.ProcessRequest(id);
        }
    }
}
