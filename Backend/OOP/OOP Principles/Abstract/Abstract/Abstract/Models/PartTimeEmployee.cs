using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Models
{
    internal class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(int id, string name, double salary) : base(id, name, salary)
        {
        }
        public override double CalculateSalary()
        {
            return Salary * 0.5;
        }

    }
}
