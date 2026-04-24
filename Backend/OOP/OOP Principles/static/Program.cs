using OOP_Principles.Models;

namespace OOP_Principles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("-----------static1-----------------\n");
            Console.WriteLine(MathUtilities.square(5));
            Console.WriteLine(MathUtilities.root(66));
            Console.WriteLine(MathUtilities.max(-5,5));

            Console.Write("-----------static2-----------------\n");
            Console.WriteLine(Converter.celsiusToFahrenheit(35));
            Console.WriteLine(Converter.fahrenheitToCelsius(95));
            Console.WriteLine(Converter.kilometersToMiles(100));
            Console.WriteLine(Converter.milesToKilometers(62));

            Console.Write("-----------static3-----------------\n");
            VisitorCounter v1 = new VisitorCounter(1);
            VisitorCounter v2 = new VisitorCounter(2);
            Console.WriteLine(v1);

            Console.Write("-----------static3-----------------\n");
            Company company = new Company();
            company.addEmp(1, "Leen");
            company.addEmp(2, "Lujain");
            company.addEmp(2, "Lujain");
            Console.WriteLine(company);
        }
    }
}
