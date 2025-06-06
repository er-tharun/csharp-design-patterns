using Observer.Pattern.Models;

namespace Observer.Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();

            var customer = new Customer("Tharun");
            var resturant = new Resturant("Megana Foods");
            var deliverPartner = new DeliveryPartner("Swiggy delivery partner");
            var customerCare = new CustomerCare();
            order.Attach(customer);
            order.Attach(resturant);
            order.Attach(deliverPartner);
            order.Attach(customerCare);

            order.SetStatus(OrderStatus.ReadyToPickup);
            Console.WriteLine("-----------------");
            order.Detach(customerCare);
            order.SetStatus(OrderStatus.Delivered);
        }
    }
}
