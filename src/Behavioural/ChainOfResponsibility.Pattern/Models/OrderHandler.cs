using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Pattern.Models
{
    public abstract class OrderHandler
    {
        protected OrderHandler nextHandler;
        public OrderHandler(OrderHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }

        public abstract void ProcessRequest(Guid id);
    }
}
