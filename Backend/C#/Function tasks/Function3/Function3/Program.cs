using System.ComponentModel;

namespace Function3
{
    internal class Program
    {
        //p1-------------------
        static Func<int,int> add(int num1)
        {
            return num2 => num1 + num2;
        }
        //p3--------------------
        static int secondLargest(int[] nums)
        {
            return (nums.Distinct().OrderByDescending(x => x)).ToArray()[1];
        }
        //p4--------------------
        static bool isRepdigit(int num)
        {
            string s = num.ToString();
            return s.All(x => x == s[0]);
        }
        //p5--------------------
        static string reverseWords(string str)
        { 
            return string.Join(" ",str.Split(" ").Reverse());
        }
        //p6--------------------
        static string sevenBoom(int[] arr)
        {
            if (arr.Any(x => x.ToString().Contains("7")))
            {
                return "Boom";
            }
            else
            {
                return "there is no 7 in the array";
            }
        }
        //p7--------------------
        static string insertWhitespace(string str)
        {
            string res = "";
            for(int i=0;i<str.Length - 1; i++)
            {
                res += str[i];
                if (char.IsLower(str[i]) && char.IsUpper(str[i+1]))
                {
                    res += " ";
                }
            }
            return res;
        }
        //p8--------------------
        static int countTrue(bool[] arr)
        {
            return arr.Count(x => x == true);
        }
        //p9--------------------
        static string capToFront(string str)
        {
            var upper = str.Where(char.IsUpper);
            var lower = str.Where(char.IsLower);

            return string.Concat(upper) + string.Concat(lower); 
        }
        //p10-------------------
        static bool matchLastItem(string[] arr)
        {
            if (arr.Length < 2) return false;
            return string.Join("", arr.Take(arr.Length - 1)) == arr[^1];
        }
        //p11-------------------
        static int findNaN(double[] arr)
        {
            return arr.IndexOf(double.NaN);
        }
        //p12-------------------
        static T[] removeDups<T>(T[] arr)
        {
            return arr.Distinct().ToArray();
        }
        //p13-------------------
        static string convertTime(string time)
        {
            string[] times = time.Split(':');
            if (time.Contains("AM"))
            {
                if (times[0] == "12") times[0] = "00";
            }
            else if(time.Contains("PM"))
            {
                if (times[0] != "12") {
                    int.TryParse(times[0], out int tt);
                    times[0] = (tt + 12).ToString("D2");
                }
            }
            return string.Join(":", times);
        }
        //p14-------------------
        static string removeLastVowel(string str)
        {
            string[] str1 = str.Split(" ");
            for (int i = 0; i < str1.Length; i++) 
            {
                int index = str1[i].ToLower().LastIndexOfAny("aeiou".ToCharArray());
                if(index != -1)
                {
                    str1[i] = str1[i].Remove(index);
                }
            }
            return string.Join(" ", str1);
        }
        //p15-------------------
        static int sumOfCubes(int[] nums)
        {
            //return nums.Sum(x => Math.Pow(x,3));
            return nums.Sum(x => x * x * x);
        }

        //--------------------------Main--------------------//
        static void Main(string[] args)
        {
            //p1---------------------
            Console.WriteLine("\n---------------p1------------\n");
            Console.WriteLine(add(5)(10));
            //p3---------------------
            Console.WriteLine("\n---------------p3------------\n");
            Console.WriteLine(secondLargest([10, 40, 30, 20, 50]));
            //p4---------------------
            Console.WriteLine("\n---------------p4------------\n");
            Console.WriteLine(isRepdigit(66));
            //p5---------------------
            Console.WriteLine("\n---------------p5------------\n");
            Console.WriteLine(reverseWords(" the sky is blue"));
            //p6---------------------
            Console.WriteLine("\n---------------p6------------\n");
            Console.WriteLine(sevenBoom([1, 2, 3, 4, 5, 67]));
            //p7---------------------
            Console.WriteLine("\n---------------p7------------\n");
            Console.WriteLine(insertWhitespace("SheWalksToTheBeach"));
            //p8---------------------
            Console.WriteLine("\n---------------p8------------\n");
            Console.WriteLine(countTrue([true, false, false, true, false]));
            //Console.WriteLine(countTrue([]));
            //p9---------------------
            Console.WriteLine("\n---------------p9-----------\n");
            Console.WriteLine(capToFront("moveMENT"));
            //p10---------------------
            Console.WriteLine("\n---------------p10------------\n");
            //Console.WriteLine(matchLastItem(["rsq", "6hi", "g", "rsq6hig"]));
            Console.WriteLine(matchLastItem(["1", "1", "1", "11"]));

            //p11---------------------
            Console.WriteLine("\n---------------p11------------\n");
            //Console.WriteLine(findNaN([1.0, 2.0, double.NaN]));
            Console.WriteLine(findNaN([0.0, 1.0,2.0,3.0,4.0]));
            //p12---------------------
            Console.WriteLine("\n---------------p12------------\n");
            //Console.WriteLine(string.Join(",",removeDups([1, 0, 1, 0])));
            //Console.WriteLine(string.Join(",", removeDups(["The", "big", "cat"])));
            Console.WriteLine(string.Join(",", removeDups(["John", "Taylor", "John"])));
            //p13---------------------
            Console.WriteLine("\n---------------p13------------\n");
            //Console.WriteLine(convertTime("12:40:22AM"));
            //Console.WriteLine(convertTime("12:45:54PM"));
            Console.WriteLine(convertTime("07:05:45PM"));
            //p14---------------------
            Console.WriteLine("\n---------------p14------------\n");
            Console.WriteLine(removeLastVowel("Those who dare to fail miserably can achieve greatly."));
            //p15---------------------
            Console.WriteLine("\n---------------p15------------\n");
            Console.WriteLine(sumOfCubes([1,5,9]));
        }
    }
}
