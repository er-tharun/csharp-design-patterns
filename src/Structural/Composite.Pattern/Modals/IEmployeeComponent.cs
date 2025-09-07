using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Pattern.Modals
{
    public interface IEmployeeComponent
    {
        public void DisplayInfo();
        public double CalculateSalary();
    }
}
