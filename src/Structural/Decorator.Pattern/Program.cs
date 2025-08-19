using Decorator.Pattern.Modals;

namespace Decorator.Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFoodItem pizzaOrder = new PizzaFoodItem();
            IFoodItem burgerOrder = new BurgerFoodItem();

            pizzaOrder = new ExtraCheeseDecorator(pizzaOrder, 20.00);
            pizzaOrder = new ExtraSauceDecortor(pizzaOrder, 11.00);

            burgerOrder = new ExtraCheeseDecorator(burgerOrder, 21.0);
            burgerOrder = new ExtraSauceDecortor(burgerOrder, 7.00);

            Console.WriteLine(pizzaOrder.GetDescription());
            Console.WriteLine(pizzaOrder.GetPrice());
            Console.WriteLine(burgerOrder.GetDescription());
            Console.WriteLine(burgerOrder.GetPrice());


        }
    }
}
