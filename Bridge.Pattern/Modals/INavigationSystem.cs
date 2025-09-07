using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Pattern.Modals
{
    public interface INavigationSystem
    {
        public void Navigate(string destination);
    }
}
