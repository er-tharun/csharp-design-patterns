using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Pattern.Modals
{
    public class Employee : IEmployeeComponent
    {
        private string _name;
        private double _salary;
        public Employee(string name, double salary)
        {
            _name = name;
            _salary = salary;
        }
        public double CalculateSalary() => _salary;

        public void DisplayInfo() => Console.WriteLine($"Employee Name : {_name} and Employee Salary : {_salary}");
    }
}
