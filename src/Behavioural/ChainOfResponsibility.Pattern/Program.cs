using ChainOfResponsibility.Pattern.Models;

namespace ChainOfResponsibility.Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderHandler orderChainOfResponsibility = new OrderValidationHandler(
                new PaymentProcessingHandler(
                    new OrderPreparationHandler(
                        new DeliverAssignmentHandler(
                            new OrderDeliveryHandler(null))))
                );

            orderChainOfResponsibility.ProcessRequest(Guid.NewGuid());
        }
    }
}
