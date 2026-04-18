using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        //p1------------------------
        static void task1()
        {
            int sum = 0;
            Console.WriteLine("Enter 10 Number");
            for(int i = 0; i < 10; i++)
            {
                if (!int.TryParse(Console.ReadLine(),out int n))
                {
                    Console.WriteLine("Invalid input");
                    i--;
                    return;
                }
                else
                {
                    sum += n;
                }

            }
            Console.WriteLine($"The sum is {sum} - the AVG is {(float)sum/10}");
        }
        //p2-------------------
        static void task2()
        {
            Console.WriteLine("Enter number to find th cube: ");
            Console.WriteLine(!int.TryParse(Console.ReadLine(), out int n) ?
                "Invalid input" : $"Number is: {n} and cube of the {n} is :{n*n*n}");
        }
        //p3-------------------
        static int[] task3(int[] arr)
        {
            return arr.Where(x => x > 1950).ToArray();
        }
        //p4-------------------
        static int task4(int age)
        {
            return age * 365;
        }
        //p5--------------------
        static void task5()
        {
            Console.WriteLine("Enter number of chickens in your farms: ");
            if(!int.TryParse(Console.ReadLine(),out int chickens) || chickens < 0)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            Console.WriteLine("Enter number of cows in your farms: ");
            if (!int.TryParse(Console.ReadLine(), out int cows) || cows < 0)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            Console.WriteLine("Enter number of pigs in your farms: ");
            if (!int.TryParse(Console.ReadLine(), out int pigs) || pigs < 0)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            Console.WriteLine($"count of legs in your farms are {(chickens * 2) + (cows + pigs) * 4}");
        }
        //p6-----------------
        static string task6(string name,string email,string pass)
        {
            string DBemail = $"{name}@gmail.com", DBpass = "123";
            if (email == DBemail && pass == DBpass) 
            {
                return "Pass";
            }
            else
            {
                return "Fail";
            }

        }
        //p7--------------------
        static void task7()
        {
            Console.WriteLine("Enter two number: ");
            if (!int.TryParse(Console.ReadLine(), out int n1) ||
                !int.TryParse(Console.ReadLine(), out int n2))
            {
                Console.WriteLine("Invalid input");
                return;
            }
            else
            {
                Console.WriteLine(Math.Pow(n1, n2));
            }
        }
        //p8----------------
        static void task8()
        {
            Console.WriteLine("Enter year: ");
            if(!int.TryParse(Console.ReadLine(), out int year) || 
                (year > 1900 && year < 2024))
            {
                Console.WriteLine("Invalid  input");
                return;
            }
            else
            {
                Console.WriteLine((year % 4 == 0 && year % 100 != 0) || year % 400 == 0 ?
                    "Leap" : "not leap");
            }
        }
        //p9----------------
        static void task9()
        {
            Console.WriteLine("Enter number to check it if prime or not: ");
            if(!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Invalid input");
                return;
            }
            else
            {
                if (n <= 1)
                {
                    Console.WriteLine("Not prime");
                    return;
                }
                else if (n == 2)
                {
                    Console.WriteLine("Prime");
                    return;
                }
                for (int i=3;i<Math.Sqrt(n);i+=2)
               {
                    if (n % i == 0)
                    {
                        Console.WriteLine("Not prime");
                        return;
                    }
               }
            }
            Console.WriteLine("Prime");
        }
        //p10----------------
        static int tsak10(string str)
        {
            return str.Split(" ").Where(s => !string.IsNullOrWhiteSpace(s)).Count();
        }

        //-----------------------Main----------------------//

        static void Main(string[] args)
        {
            //p1-----------------------
            Console.WriteLine("\n--------------p1---------\n");
            task1();
            //p2-----------------------
            Console.WriteLine("\n--------------p2---------\n");
            task2();
            //p3-----------------------
            Console.WriteLine("\n--------------p3---------\n");
            int[] years = [1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020];
            Console.WriteLine(string.Join(",",task3(years)));
            //p4-----------------------
            Console.WriteLine("\n--------------p4---------\n");
            Console.WriteLine("Enter your age to calculate it in days: ");
            if (!int.TryParse(Console.ReadLine(), out int age) || age <= 0)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            else
            {
                Console.WriteLine($"Your age in days is {task4(age)}");
            }

            //p5-----------------------
            Console.WriteLine("\n--------------p5---------\n");
            task5();
            //p6-----------------------
            Console.WriteLine("\n--------------p6---------\n");
            Console.WriteLine("Enter your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Email: ");
            string email = Console.ReadLine()?.Trim();
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                Console.WriteLine("Invalid email");
                return;
            }
            Console.WriteLine("Enter your Password: ");
            string pass = Console.ReadLine();
            Console.WriteLine(task6(name,email, pass));
            //p7-----------------------
            Console.WriteLine("\n--------------p7---------\n");
            task7();
            //p8-----------------------
            Console.WriteLine("\n--------------p8---------\n");
            task8();
            //p9-----------------------
            Console.WriteLine("\n--------------p9---------\n");
            task9();
            //p10-----------------------
            Console.WriteLine("\n--------------p10---------\n");
            Console.WriteLine("Enter sentence: ");
            string str = Console.ReadLine();
            Console.WriteLine(tsak10(str));
        }
    }
}
