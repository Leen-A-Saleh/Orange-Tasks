namespace c_3
{
    internal class Program
    {
        //p5-----------------
        static List<int> oddNum()
        {
            List<int> list = new List<int>();
            for(int i = 1; i <= 100; i+=2)
            {
                list.Add(i);
            }
            return list;
        }

        static void Main(string[] args)
        {
            //p1------------------------
            Console.WriteLine("\n-----------------p1----------------");
            int[] ARR = [1, 7,  9, 45];
            string[] arr2 = ["Str", "alex", "moh"];
            string[] arr3 = ["the", "fox", "over", "lazy", "dog"];

            //p2------------------------
            Console.WriteLine("\n-----------------p2----------------");
            string[] fruits = ["Tomato", "Banana", "Watermelon"];
            Console.WriteLine($"The index of Banana is {fruits.IndexOf("Banana")}, " +
                $"The index of Tomato is {fruits.IndexOf("Tomato")}");
            //p3------------------------
            Console.WriteLine("\n-----------------p3----------------");
            string[] favoriteFood = { "Pizza", "Burger", "Pasta", "Sushi", "Fries" };
            foreach(string f in favoriteFood) { Console.WriteLine(f); }
            //p4------------------------
            Console.WriteLine("\n-----------------p4----------------");
            Console.WriteLine("input in one line three number separated by a comma");
            string number = Console.ReadLine();
            string[] num = number.Split(",");
            int sum = 0;
            foreach(var item in num)
            {
                int.TryParse(item, out int item1);
                sum += item1;
            }
            Console.WriteLine(sum);

            //p5------------------------
            Console.WriteLine("\n-----------------p5----------------");
            Console.WriteLine(string.Join(",", oddNum()));
            Console.Write($"The sum of Odd number is {Math.Pow(50,2)}");
            //p6------------------------
            Console.WriteLine("\n-----------------p6----------------");
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            //p7------------------------
            Console.WriteLine("\n-----------------p7----------------");
            int k = 1;
            for(int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= i + 1; j++)
                {
                    Console.Write($"{k} ");
                    k++;
                }
                Console.WriteLine();
            }
        }
    }
}
