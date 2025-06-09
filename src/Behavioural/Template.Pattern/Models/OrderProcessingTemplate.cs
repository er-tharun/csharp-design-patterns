using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Pattern.Models
{
    public abstract class OrderProcessingTemplate
    {
        public void ProcessOrder()
        {
            PrepareOrder();
            AssignDelivery();
            TrackDelivery();
        }

        public abstract void PrepareOrder();
        public abstract void AssignDelivery();
        public abstract void TrackDelivery();
    }
}
