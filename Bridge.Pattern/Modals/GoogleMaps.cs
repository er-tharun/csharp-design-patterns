using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Pattern.Modals
{
    public class GoogleMaps : INavigation
    {
        public void NavigateTo(string destination)
        {
            Console.WriteLine($"Google Maps : {destination}");
        }
    }
}
