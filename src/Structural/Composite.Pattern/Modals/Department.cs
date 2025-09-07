using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Pattern.Modals
{
    public class Department : IEmployeeComponent
    {
        private IList<IEmployeeComponent> _component = new List<IEmployeeComponent>();
        public void AddComponent(IEmployeeComponent component) => _component.Add(component);
        public double CalculateSalary()
        {
            double salary = 0;
            foreach(var item in  _component)
            {
                salary += item.CalculateSalary();
            }
            return salary;
        }

        public void DisplayInfo()
        {
            foreach(var item in _component)
            {
                item.DisplayInfo();
            }
        }
    }
}
