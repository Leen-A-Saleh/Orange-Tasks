using System.Text.RegularExpressions;

namespace Function2
{
    internal class Program
    {
        //p1-------------------
        static int getDays(DateOnly date1, DateOnly date2)
        {
            return Math.Abs((date2.DayNumber - date1.DayNumber));
        }
        //p2-------------------
        static string[] numInStr(string[] arr)
        {
            //return arr.Where(item => Regex.IsMatch(item, @"\d")).ToArray();
            return arr.Where(item => item.Any(char.IsDigit)).ToArray();
        }
        //p3-------------------
        static string reverseOddWord(string str)
        {
            return string.Join(" ", str.Split(" ").Select(str => str.Length % 2 != 0 ? new string (str.Reverse().ToArray()) : str));
        }
        //p4-------------------
        static bool isPandigital (long number)
        {
            string s = number.ToString();
            for(char i='0'; i <= '9'; i++)
            {
                if (!s.Contains(i)) return false;
            }
            return true;
        }
        //-----------------------Main----------------------------//

        static void Main(string[] args)
        {

            //p4-------------------
            Console.WriteLine("\n---------------p4------------------\n");
            //long p = 98140723568910;
            //long p = 90864523148909;
            long p = 112233445566778899;
            Console.WriteLine(isPandigital(p));
        }
    }
}
