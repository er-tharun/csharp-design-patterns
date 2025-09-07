using Bridge.Pattern.Modals;

namespace Bridge.Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INavigation googleMaps = new GoogleMaps();
            INavigation appleMaps = new AppleMaps();

            INavigationSystem uberEats = new UberEats() {
                PartnerName = "Sathish",
                NavigationImpl = googleMaps,
            };

            uberEats.Navigate("Cubbon park");

            INavigationSystem uberRides = new UberRides()
            {
                NavigationImpl = appleMaps,
                DriverName= "Dinesh",
            };

            uberRides.Navigate("Whitefield");
        }
    }
}
