using Strategy.Pattern.Models;

namespace Strategy.Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentProcessor processor = new PaymentProcessor();

            processor.SetStrategy(new CreditCardPaymentStrategy());
            processor.ProcessPayment(100.00);

            Console.WriteLine("------------------------------");

            processor.SetStrategy(new DebitCardPaymentStrategy());
            processor.ProcessPayment(299.00);

            Console.WriteLine("------------------------------");

            processor.SetStrategy(new UPIPaymentStrategy());
            processor.ProcessPayment(499.00);
        }
    }
}
