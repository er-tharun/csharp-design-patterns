using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Pattern.Modals
{
    public class ComputerSystemFacade
    {
        public void StartComputer()
        {
            Console.WriteLine("Starting Computer .....");
            CPU.Initialize();
            GPU.Initialize();
            Memory.Initialize();
            Console.WriteLine("Shutting down computer");
        }
    }
}
