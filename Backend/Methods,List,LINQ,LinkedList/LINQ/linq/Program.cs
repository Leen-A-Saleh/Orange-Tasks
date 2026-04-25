using System.ComponentModel;

namespace linq
{
    internal class Program
    {
        //method|task1
        static double CalculateAverage(int[] arr)
        {
            double avg = arr.Average();
            return avg;
        }
        //method|task2
        static void listName(List<string> list) {
            list.Add("leen");
            list.Add("Ahmad");
            list.Add("Oraib");
            list.Add("Rahma");
            list.Add("Abdulluh");

            DisplayName(list) ;

            list.Remove("Abdulluh");
            Console.WriteLine("\n----------after remove-------------");
            DisplayName(list);
        }
        static void DisplayName(List<string> list)
        {
            foreach(var name in list)
            {
                Console.WriteLine(name);
            } 
        }
        static void Main(string[] args)
        {
            int[] numbers = { 5, 10, 15, 20, 25, 30 };
            List<string> names = new List<string>();
            //linq|task1
            var res = numbers.Where(num => num > 15);
            foreach ( int num in res)
            {
                Console.Write(num+" ");
            }
            Console.WriteLine("\n--------------------------\n");
            //linq|task2
            var even = numbers.Where(num => num % 2 == 0);
            foreach ( int num in even)
            {
                Console.Write(num+" ");
            }
            Console.WriteLine("\n--------------------------\n");
            //linq|task3
            var asc = numbers.OrderBy(num => num);
            foreach ( int num in asc)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n--------------------------\n");
            var desc = numbers.OrderByDescending(num => num);
            foreach ( int num in desc)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n--------------------------\n");
            //linq|task4
            Console.WriteLine(numbers.FirstOrDefault(num => num > 10));
            Console.WriteLine("\n--------------------------\n");
            //linq|Bonus Challenge (Optional)
            var dbl = numbers.Select(num => num * 2);
            foreach( int num in dbl)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n-------------method-------------\n");
            //task1
            Console.WriteLine(CalculateAverage(numbers));
            //task2
            listName(names);
            Console.WriteLine("\n---------------- Dictionary-------------\n");
            Dictionary<int, string> users = new Dictionary<int, string>
            {
                {1,"leen"},
                {2,"Lujain"},
                {3,"Ahmad"}
            };
            foreach(var dic in users)
            {
                Console.WriteLine($"{dic.Key}:{dic.Value}");
            }

        }
    }
}
