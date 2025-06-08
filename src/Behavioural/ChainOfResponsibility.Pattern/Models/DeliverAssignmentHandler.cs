using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Pattern.Models
{
    public class DeliverAssignmentHandler : OrderHandler
    {
        public DeliverAssignmentHandler(OrderHandler nextHandler) : base(nextHandler)
        {
            
        }
        public override void ProcessRequest(Guid id)
        {
            Console.WriteLine("Deliver assignment handler "+id);
            if(nextHandler is not null)
                nextHandler.ProcessRequest(id);
        }
    }
}
