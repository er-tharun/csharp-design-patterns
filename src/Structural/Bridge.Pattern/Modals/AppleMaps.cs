using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Pattern.Modals
{
    public class AppleMaps : INavigation
    {
        public void NavigateTo(string destination)
        {
            Console.WriteLine($"Apple Maps : {destination}");
        }
    }
}
