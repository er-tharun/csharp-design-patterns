using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Pattern.Models
{
    public class InternationalDelivery : OrderProcessingTemplate
    {
        public override void AssignDelivery() => Console.WriteLine($"{nameof(InternationalDelivery)} : Assign Delivery");

        public override void PrepareOrder() => Console.WriteLine($"{nameof(InternationalDelivery)} : Prepare Order");

        public override void TrackDelivery() => Console.WriteLine($"{nameof(InternationalDelivery)} : Track Delivery");
    }
}
