using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Models
{
    internal class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(int id, string name, double salary) : base(id, name, salary)
        {
        }
        public override double CalculateSalary()
        {
            return Salary; 
        }
    }
}
