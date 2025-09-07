using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace Bridge.Pattern.Modals
{
    public class UberEats:INavigationSystem
    {
        public string PartnerName { get; set; }
        public INavigation NavigationImpl { get; set; }

        public void Navigate(string destination)
        {
            Console.WriteLine($"Food deliver with food partner : {PartnerName} to destination {destination}");
            NavigationImpl.NavigateTo(destination);
        }
    }
}
