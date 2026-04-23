using advanceOOP.Models;

namespace advanceOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student(1, "Leen", 25, 99.9);

            Console.WriteLine(std);

            Car car = new Car(
           "Toyota",
           2022,
           "Sedan",
           25000,
           "Camry",
           "PL12345",
           "Black"
            );

            Console.WriteLine(car);
        }
    }
}
