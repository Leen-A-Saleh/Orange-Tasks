using Polymorphism.Models;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("-----------poly1(animals)---------\n");
            List<Animals> animals = new List<Animals>()
            {
                new Dogs(),
                new Cats(),
            };
            animals.ForEach(item=>item.speak());
            
            Console.Write("-----------poly2(Shape)---------\n");
            List<Shape> shapes = new List<Shape>()
            {
                new Rectangle(3.5,7),
                new Square(5),
            };
            shapes.ForEach(item => Console.WriteLine($"The Area of shape is {item.GetArea()}"));

            Console.Write("-----------poly3(Overlodding)---------\n");
            Console.WriteLine(Calculator.Add(2,5));
            Console.WriteLine(Calculator.Add(2.5, 5.5));
            Console.WriteLine(Calculator.Add(0,6,-3));
            Console.WriteLine(Calculator.Add(0.0,20.5,-0.5));
        }
    }
}
