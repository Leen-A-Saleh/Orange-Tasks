using Abstract.Models;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("-------------Appliance---------");
            Appliance wm = new WashingMachine("Sharp");
            Appliance ac = new AirConditioner("Samsung");
            wm.TurnOn();
            ac.TurnOn();

            wm.TurnOff();
            ac.TurnOff();

            Console.Write("-------------EMployee---------\n");
            List<Employee> employees = new List<Employee>
            {
                new FullTimeEmployee(1, "Leen", 5000),
                new FullTimeEmployee(2, "Lujain", 5000),
                new PartTimeEmployee(3, "Ahmad", 5000)
            };

            foreach (var item in employees)
            {
                Console.WriteLine($"ID: {item.Id}, Name: {item.Name}, Salary: {item.CalculateSalary()}");
            }

        }
    }
}
