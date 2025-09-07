using Facade.Pattern.Modals;

namespace Facade.Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new ComputerSystemFacade().StartComputer();
        }
    }
}
