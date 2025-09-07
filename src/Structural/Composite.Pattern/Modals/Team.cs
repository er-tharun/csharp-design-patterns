using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Pattern.Modals
{
    public class Team : IEmployeeComponent
    {
        private IList<IEmployeeComponent> _componenet=new List<IEmployeeComponent>();
        public void AddComponent(IEmployeeComponent componenet) => _componenet.Add(componenet);
        public double CalculateSalary()
        {
            double salary = 0.00;
            foreach(var item in _componenet)
            {
                salary += item.CalculateSalary();
            }
            return salary;
        }

        public void DisplayInfo()
        {
            foreach(var item in _componenet)
            {
                item.DisplayInfo();
            }
        }
    }
}
