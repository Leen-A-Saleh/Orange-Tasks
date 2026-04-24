using Innterface.Models;

namespace Innterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two positive number (only positive. Negative number stop the program)");
            if (!int.TryParse(Console.ReadLine(),out int num1) ||
                !int.TryParse(Console.ReadLine(),out int num2) || num1 < 0 || num2 < 0)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            else
            {
                Calculator cal1 = new Calculator();
                Console.WriteLine(cal1.Add(num1, num2));
                Console.WriteLine(cal1.sub(num1, num2));
                Console.WriteLine(cal1.mul(num1, num2));
                Console.WriteLine(cal1.div(num1, num2));
            }
        }
    }
}
