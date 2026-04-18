namespace ConsoleApp1
{
    internal class Program
    {
        //p1--------------------
        static int minValue(int num1, int num2)
        {
            return num1 > num2 ? num2 : num1; 
        }
        //p2--------------------
        static char signOfNum(int num)
        {
            return num < 0 ? '-' : '+';
        }
        //p3--------------------
        static string orderAsc(int num1, int num2, int num3)
        {
            if (num1 < num2)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }
            if (num1 < num3)
            {
                int temp = num1;
                num1 = num3;
                num3 = temp;
            }
            if(num2 < num3)
            {
                int temp= num2;
                num2 = num3;
                num3 = temp;
            }
            return $"{num1} {num2} {num3}";
        }
        //p4--------------------
        static int maxNum(int[] nums)
        {
            int max = nums[0];
            for(int i=0;i<nums.Length;i++)
            {
                if(nums[i] > max)
                    max= nums[i];
            }
            return max;
        }
        //p5--------------------
        static float miles(float num)
        {
            return num * 0.621371f;
        }
        //p6--------------------
        static int total_H_Min(int h,int min)
        {
            return (h * 60) + min;
        }
        //p7--------------------
        static void totalH(int mintus,out int h,out int min)
        {
            h = mintus / 60;
            min = mintus % 60;
        }
        //p8--------------------
        static string[] fixedSize(string[] s)
        {
            string[] ss = new string[5];

            for(int i=0; i<s.Length; i++ )
            {
                ss[i] = s[i].Substring(0, 4);
            }
            return ss;
        }
        //p9--------------------
        static string reverseOdd(string str)
        {
            string[] s = str.Split(" ");
            for(int i=0;i<s.Length; i++)
            {
                if (s[i].Length % 2 != 0)
                {
                    s[i]=new string (s[i].Reverse().ToArray());
                }
            }
        return string.Join(" ", s);
        }

        //---------------------Main---------------------------//

        static void Main(string[] args)
        {
            //p1-----------------
            Console.WriteLine("\n---------------p1---------------\n");
            Console.WriteLine("Enter two number plz: ");
            Console.WriteLine(!int.TryParse(Console.ReadLine(), out int num1) ||
                !int.TryParse(Console.ReadLine(), out int num2) ?
                "Invalid input" : minValue(num1, num2));
            //p2-----------------
            Console.WriteLine("\n---------------p2---------------\n");
            Console.WriteLine("Enter number plz: ");
            Console.WriteLine(!int.TryParse(Console.ReadLine(), out int num3) && num3 != 0 ?
                "Invalid input" : signOfNum(num3));
            //p3-----------------
            Console.WriteLine("\n---------------p3---------------\n");
            Console.WriteLine("Enter three number plz: ");
            if (!int.TryParse(Console.ReadLine(), out int num4) ||
                !int.TryParse(Console.ReadLine(), out int num5) ||
                !int.TryParse(Console.ReadLine(), out int num6))
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                Console.WriteLine(orderAsc(num4, num5, num6));
            }
            //p4-----------------
            Console.WriteLine("\n---------------p4---------------\n");
            int[] arr1 = { -5, -2, -6, 0, -1 };
            Console.WriteLine($"the max number in array is {maxNum(arr1)}");
            //p5-----------------
            Console.WriteLine("\n---------------p5---------------\n");
            Console.WriteLine("Enter kilometers per hour for converts to miles per hour");
            if (!float.TryParse(Console.ReadLine(), out float K))
            {
                Console.WriteLine("Invalid input");
                return;
            }
            else
            {
                Console.WriteLine(miles(K));
            }
            //p6-----------------
            Console.WriteLine("\n---------------p6---------------\n");
            Console.WriteLine("Enter number of Hours: ");
            if (!int.TryParse(Console.ReadLine(), out int hh))
            {
                Console.WriteLine("Invalid input");
                return;
            }
            else
            {
                Console.WriteLine("Enter number of minutes: ");
                int.TryParse(Console.ReadLine(), out int minutes);
                Console.WriteLine(total_H_Min(hh, minutes));
            }
            //p7-----------------
            Console.WriteLine("\n---------------p7---------------\n");
            Console.WriteLine("Enter number of min: ");
            if(!int.TryParse(Console.ReadLine(), out int min))
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                totalH(min, out int h, out int m);
                Console.WriteLine($"Hours: {h} - Minutes: {m}");
            }
            //p8-----------------
            Console.WriteLine("\n---------------p8---------------\n");
            string[] s8 = { "Hello world", "C# is poweful", "I love programming", "Short", "This is a longer sentence" };
            Console.WriteLine(string.Join(",",fixedSize(s8)));
            //p9-----------------
            Console.WriteLine("\n---------------p9---------------\n");
            //string s9 = "Bananas";
            string s9 = "One two three four";
            Console.WriteLine(reverseOdd(s9)); 
        }
    }
}
