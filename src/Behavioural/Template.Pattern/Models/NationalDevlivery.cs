using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Pattern.Models
{
    public class NationalDevlivery : OrderProcessingTemplate
    {
        public override void AssignDelivery() => Console.WriteLine($"{nameof(NationalDevlivery)} : Assign Delivery");

        public override void PrepareOrder() => Console.WriteLine($"{nameof(NationalDevlivery)} : Prepare Order");

        public override void TrackDelivery() => Console.WriteLine($"{nameof(NationalDevlivery)} : Track Delivery");
    }
}
