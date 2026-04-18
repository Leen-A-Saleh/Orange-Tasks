using System.Security.Cryptography;

namespace Function1
{
    internal class Program
    {
        //P1------------------
        static int convertMinutes(int min)
        {
            return min * 60;
        }
        //P2------------------
        static int increment(int num)
        {
            return ++num;
        }
        //P3------------------
        static int firstElement(int[] nums)
        {
            return nums[0];
        }
        //P4------------------
        static float area(float basse, float height)
        {
            return .5f * basse * height;
        }
        //P5------------------
        static int[] evenNumberEvenIndex(int[] nums)
        {
            return nums.Where((num, i) => num % 2 == 0 && i % 2 == 0).ToArray();
        }
        //P6------------------
        static string[] evenIndexOddLength(string[] names)
        {
            return names.Where((name, i) => name.Length % 2 != 0 && i % 2 == 0).ToArray();
        }
        //P7------------------
        static double[] powerElementIndex(int[] nums)
        {
            return nums.Select((num, i) => Math.Pow(num, i)).ToArray();
        }
        //P8------------------
        static int multiplication2(int n1,int n2)
        {
            int res = 0, time = Math.Min(n1, n2), value = Math.Max(n1, n2);
            for (int i = 0; i < Math.Abs(time); i++)
                res += value;
            if (n1 < 0)
                res = -res;
            return res;
        }
        //P9------------------
        static int muti2(int n1, int n2)
        {
            int res = 1;
            for (int i= n1; i <= n2; i++)
            {
                res *= i;
            }
            return res;
        }
        //P10------------------
        static double aveArray(int[] numbers)
        {
            return numbers.Average();
        }

        //-----------------------------Main--------------------------------//

        static void Main(string[] args)
        {
            //P1---------------
            Console.WriteLine("\n-------------P1------------\n");
            Console.WriteLine("Enter Number of min :");
            if(int.TryParse(Console.ReadLine(), out int min))
            {
                Console.WriteLine($"second : {convertMinutes(min)}");
            }
            else
            {
                Console.WriteLine("Invalid input");

            }
            //P2---------------
            Console.WriteLine("\n-------------P2------------\n");
            Console.WriteLine("Enter Number :");
            if(int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.WriteLine(increment(num1));
            }
            else
            {
                Console.WriteLine("Invalid input");
                return;
            }
            //P3---------------
            Console.WriteLine("\n-------------P3------------\n");
            Console.WriteLine("Enter the number of elements :");
            if(!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            int[] numbers = new int[size];
            Console.WriteLine("Enter the numbers :");
            for(int i = 0; i < size; i++)
            {
                if(int.TryParse(Console.ReadLine(),out int number))
                {
                    numbers[i] = number;
                }
                else
                {
                    Console.WriteLine("Invalid input: reset value to 0");
                    numbers[i] = 0;
                }
            }

            Console.WriteLine($"First Element: {firstElement(numbers)}");
            //P4---------------
            Console.WriteLine("\n-------------P4------------\n");
            Console.WriteLine("Enter the base and height of triangle to calculate area : ");
            if (!float.TryParse(Console.ReadLine(), out float basse) ||
                !float.TryParse(Console.ReadLine(),out float height))
            {
                Console.WriteLine("Invalid input");
                return;
            }
            else
            {
                Console.WriteLine($"Area is : {area(basse,height)}");
            }
            //P5---------------
            Console.WriteLine("\n-------------P5------------\n");
            int[] nums = { 5, 2, 2, 1, 8, 66, 55, 77, 34, 9, 55, 1 };
            Console.WriteLine(string.Join(",", evenNumberEvenIndex(nums)));
            //P6---------------
            Console.WriteLine("\n-------------P6------------\n");
            string[] names = { "alex", "mercer", "madrasa", "rashed2", "emad", "hala" };
            Console.WriteLine(string.Join(",", evenIndexOddLength(names)));
            //P7---------------
            Console.WriteLine("\n-------------P7------------\n");
            int[] nums7 = { 44, 5, 4, 3, 2, 10 };
            Console.WriteLine(string.Join(",", powerElementIndex(nums7)));
            //P8---------------
            Console.WriteLine("\n-------------P8------------\n");
            Console.WriteLine("Enter two number to multiplication :");
            if(!int.TryParse(Console.ReadLine(), out int n1) ||
            !int.TryParse(Console.ReadLine(), out int n2))
            {
                Console.WriteLine("Invalid input");
                return;
            }
            else
            {
                Console.WriteLine(multiplication2(n1, n2));
            }
            //P9---------------
            Console.WriteLine("\n-------------P9------------\n");
            Console.WriteLine("Enter two number to multiplication :");
            if (!int.TryParse(Console.ReadLine(), out int nn1) ||
            !int.TryParse(Console.ReadLine(), out int nn2))
            {
                Console.WriteLine("Invalid input");
                return;
            }
            else
            {
                Console.WriteLine(muti2(nn1, nn2));
            }
            //P10---------------
            Console.WriteLine("\n-------------P10------------\n");
            Console.WriteLine("Enter the number of elements :");
            if(!int.TryParse(Console.ReadLine(),out int s) || s <= 0)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            int[] numbers2 = new int[s];
            Console.WriteLine("Enter the numbers :");
            for(int i = 0; i < s; i++)
            {
                if(int.TryParse(Console.ReadLine(),out int number2)){
                    numbers2[i] = number2;
                }
                else
                {
                    Console.WriteLine("Invalid input: reset value to 0");
                    numbers2[i] = 0;
                }
            }
            Console.WriteLine($"Avarege of numbers is : {aveArray(numbers2)}");
        }
    }
}
