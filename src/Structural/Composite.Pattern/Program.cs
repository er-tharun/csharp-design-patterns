using Composite.Pattern.Modals;

namespace Composite.Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployeeComponent suresh = new Employee("Suresh", 100.00);
            IEmployeeComponent dinesh = new Employee("Dinesh", 150.00);

            Team sales = new Team();
            sales.AddComponent(suresh);
            sales.AddComponent(dinesh);

            sales.DisplayInfo();
            Console.WriteLine(sales.CalculateSalary());

            IEmployeeComponent bob = new Employee("Bob", 225.00);
            Team marketing = new Team();
            marketing.AddComponent(bob);

            marketing.DisplayInfo();
            Console.WriteLine(marketing.CalculateSalary());

            Department head = new Department();
            head.AddComponent(sales);
            head.AddComponent(marketing);

            head.DisplayInfo();
            Console.WriteLine(head.CalculateSalary());
        }
    }
}
