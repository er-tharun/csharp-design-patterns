using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace Bridge.Pattern.Modals
{
    public class UberRides : INavigationSystem
    {
        public string DriverName { get; set; }
        public INavigation NavigationImpl { get; set; }
        public void Navigate(string destination)
        {
            Console.WriteLine($"Uber Ride with {DriverName} to destination {destination}");
            NavigationImpl.NavigateTo(destination);
        }
    }
}
