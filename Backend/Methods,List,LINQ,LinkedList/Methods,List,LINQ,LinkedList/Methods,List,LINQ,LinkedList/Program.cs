using System.Linq;
using System.Threading.Tasks.Dataflow;
namespace Methods_List_LINQ_LinkedList
{
    internal class Program
    {
        //task1---------
        static IEnumerable<int> task1(List<int> nums) => nums.Where(num => num % 2 == 0);

        //task2---------
        static IEnumerable<int> task2(List<int> num) => num.Distinct();

        //task3---------
        static int task3(List<int> num) => num.Max();

        //task4---------
        static List<int> task4(List<int> num) => Enumerable.Reverse(num).ToList();

        //task5---------
        static int task5(List<int> num) => num.Count(n => n > 50);

        //task6---------
        static void task6(Dictionary<string, int> students)
        {
            Console.WriteLine("All students their grades greater 80:\n");
            foreach (var std in students)
            {
                if(std.Value > 80)
                Console.WriteLine($"Name: {std.Key} - Grade: {std.Value}");
            }

        }

        //task7---------
        static int task7(Dictionary<string,int> students)
        {
            Console.WriteLine("Enter student name to return his grade: ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name) || int.TryParse(name, out _)) 
            {
                Console.WriteLine("Invalid input");
                return -1;
            }
            else
            {
                name = name[0].ToString().ToUpper() + name.Substring(1);
            }

            if (students.TryGetValue(name, out int grade))
            {
                return grade;
            }
            else
            {
                Console.WriteLine("Not Found");
                return -1;
            }
                
            }

        //task8---------
        static int task8(Dictionary<string, int> students) => students.Values.Sum();

        //task9---------
        static void task9(Dictionary<string,int> students)
        {
            Console.WriteLine($"Student with grade greater 50: {string.Join("\n", students.Where(std => std.Value > 50))}");
        }

        //task10---------
        static int task10(Dictionary<string,int> students) => students.Values.Max();

        //task11---------
        static void task11(LinkedList<string> nav)
        {
            Console.WriteLine("Add nodes to LinkedList");
            nav.AddLast("Home");
            nav.AddLast("About");
            nav.AddLast("Services");
            nav.AddLast("Blog");
            nav.AddLast("Contact");
            foreach (var item in nav) Console.WriteLine(item);
        }

        //task12---------
        static void task12(LinkedList<string> nav)
        {
            Console.WriteLine("Remove middle node");
            var head = nav.First;
            int mid = nav.Count / 2;
            if (nav.Count <= 1) return;
            for (int i = 0; i < mid; i++) head = head.Next;
            nav.Remove(head);
            foreach (var item in nav) Console.WriteLine(item);
        }

        //task13---------
        static void task13(LinkedList<string> nav)
        {
            Console.WriteLine("Insert After & Before Blog");
            var node = nav.Find("Blog");
            if (node != null)
            {
                nav.AddBefore(node, "Services");
                nav.AddAfter(node, "Portfolio");
            }
            foreach (var item in nav) Console.WriteLine(item);
        }

        //task14---------
        static void task14(LinkedList<string> nav)
        {
            Console.WriteLine("Print node using loop");
            foreach (var node in nav) Console.WriteLine(node);
        }

        //task15---------
        static void task15(LinkedList<string> nav)
        {
            Console.WriteLine($"Print first and last node\n First node: {nav.First.Value} \n Last node: {nav.Last.Value}");

        }

        //task16---------
        static IEnumerable<int> task16(List<int> nums) => nums.Where(num => num % 2 != 0);

        //task17---------
        static IEnumerable<int> task17(List<int> nums) => nums.Select(num => num * 2);

        //task18---------
        static IEnumerable<int> task18(List<int> nums) => nums.Distinct().OrderDescending();

        //task19---------
        static int task19(List<int> nums) => nums.FirstOrDefault(num => num > 100);

        //task20---------
        static double task20(List<int> nums) => nums.Average();

        //task21---------
        static IEnumerable<int> task21(List<int> nums1, List<int> nums2) => nums1.Intersect(nums2);

        //task22---------
        static IEnumerable<int> task22(List<int> nums1, List<int> nums2) => nums1.Union(nums2);

        //task23---------
        static IEnumerable<int> task23(List<int> nums1, List<int> nums2) => (nums1.Except(nums2)).Union(nums2.Except(nums1));

        //task24---------
        static List<int> task24(Dictionary<string, int> students) => students.Values.ToList();

        //task25---------
        static List<int> task25(Dictionary<string, int> students) => students.Where(std => std.Value > 100).Select(std => std.Value).ToList();

        //task26---------
        static void task26(List<int> nums)
        {
            Console.WriteLine("Enter a number to search in the list without LINQ: ");
            if(!int.TryParse(Console.ReadLine(),out int n))
            {
                Console.WriteLine("Invalid input");
                return;
            }
            else
            {
                foreach(var item in nums)
                {
                    if (item == n)
                    {
                        Console.WriteLine("Found");
                        return;
                    }
                }
                Console.WriteLine("Not Found");
            }
        }

        //task27---------
        static int task27(List<int> nums)
        {
            int c = 0;
            foreach(var item in nums)
            {
                if (item % 2 == 0) c++;
            }
            return c;
        }

        //task28---------
        static List<int> task28(List<int> nums)
        {
            for (int i = nums.Count - 1; i >= 0; i--) 
            {
                nums.RemoveAt(i);
            }
            return nums;
        }

        //task29---------
        static int task29(List<int> nums)
        {
            int max = nums[0];
            int secMax = nums[0];
            foreach(var num in nums)
            {
                if(num > max)
                {
                    secMax = max;
                    max = num;
                }
            }
            return secMax;
        }

        //-------------------Main-------------------//

        static void Main(string[] args)
        {
            Console.WriteLine("------------List------------\n");
            List<int> numbers = new List<int>() { 1, 25, 44, 12, 5, -6, 7, 1, 8, -9, 44, 10, 12 };

            Console.WriteLine("\n------------Tsak1-----------\n");
            Console.WriteLine($"Even list: {string.Join(",",task1(numbers))}");

            Console.WriteLine("\n------------Task2------------\n");
            Console.WriteLine($"List without duplicate: {string.Join(",",task2(numbers))}");

            Console.WriteLine("\n------------Task3------------\n");
            Console.WriteLine($"Max number int List: {task3(numbers)}");

            Console.WriteLine("\n------------Task4------------\n");
            Console.WriteLine($"Reverse List: {string.Join(",",task4(numbers))}");

            Console.WriteLine("\n------------Task5------------\n");
            Console.WriteLine($"Count number greater 50: {task5(numbers)}");

            //-------------------------------------------------------------------//

            Console.WriteLine("\n------------Dictionary------------\n");
            Dictionary<string, int> students = new Dictionary<string, int>()
            {
                {"Leen",99 },
                {"Lujain",98 },
                {"Haneen",85 },
                {"Aya",75 },
                {"Hadeel",50 }
            };

            Console.WriteLine("\n------------Task6------------\n");
            task6(students);

            Console.WriteLine("\n------------Task7------------\n");
            Console.WriteLine($"Grade: {task7(students)}");

            Console.WriteLine("\n------------Task8------------\n");
            Console.WriteLine($"The sum of grade:  {task8(students)}");

            Console.WriteLine("\n------------Task9------------\n");
            task9(students);

            Console.WriteLine("\n------------Task10------------\n");
            Console.WriteLine($"The max grade: {task10(students)}");

            //-------------------------------------------------------------------//

            Console.WriteLine("\n------------LinkedList------------\n");
            LinkedList<string> nav = new LinkedList<string>();
            
            Console.WriteLine("\n------------Task11------------\n");
            task11(nav);

            Console.WriteLine("\n------------Task12------------\n");
            task12(nav);

            Console.WriteLine("\n------------Task13------------\n");
            task13(nav);

            Console.WriteLine("\n------------Task14------------\n");
            task14(nav);

            Console.WriteLine("\n------------Task15------------\n");
            task15(nav);

            //-------------------------------------------------------------------//

            Console.WriteLine("\n------------LINQ------------\n");
            List <int> numbers1 = new List<int>() { 100, 255, 440, 12, 5, 66, 7, 120, 8, 29, 44, 100, 120 };

            Console.WriteLine("\n------------Task16------------\n");
            Console.WriteLine($"Odd numbers: {string.Join(",",task16(numbers1))}");

            Console.WriteLine("\n------------Task17------------\n");
            Console.WriteLine($"Muktiple by 2: {string.Join(",", task17(numbers1))}");

            Console.WriteLine("\n------------Task18------------\n");
            Console.WriteLine($"Sort desc: {string.Join(",", task18(numbers1))}");

            Console.WriteLine("\n------------Task19------------\n");
            Console.WriteLine($"First number greater 100: {task19(numbers1)}");

            Console.WriteLine("\n------------Task20------------\n");
            Console.WriteLine($"Average: {task20(numbers1)}");

            //-------------------------------------------------------------------//

            Console.WriteLine("\n------------Mixed------------\n");

            Console.WriteLine("\n------------Task21------------\n");
            Console.WriteLine($"Common numbers in List: numbers and numbers1: {string.Join(",",task21(numbers,numbers1))}");

            Console.WriteLine("\n------------Task22------------\n");
            Console.WriteLine($"Merge numbers in List: numbers and numbers1: {string.Join(",", task22(numbers, numbers1))}");

            Console.WriteLine("\n------------Task23------------\n");
            Console.WriteLine($"Unique numbers in List: numbers and numbers1: {string.Join(",", task23(numbers, numbers1))}");

            Console.WriteLine("\n------------Task24------------\n");
            Console.WriteLine($"Extract values from Dictionary into List: {string.Join(",", task24(students))}");

            Console.WriteLine("\n------------Task25------------\n");
            Console.WriteLine($"Extract values from Dictionary into List where value > 100: {string.Join(",", task25(students))}");

            //-------------------------------------------------------------------//

            Console.WriteLine("\n------------Thinking Task------------\n");

            Console.WriteLine("\n------------Task26 - Manual Search------------\n");
            task26(numbers);

            Console.WriteLine("\n------------Task27 - Count Even Without LINQ------------\n");
            Console.WriteLine($"Count Even Without LINQ in List: {task27(numbers)}");

            Console.WriteLine("\n------------Task28 - Remove While Looping------------\n");
            Console.WriteLine($"Numbers list after remove: {string.Join(",",task28(numbers))}");

            Console.WriteLine("\n------------Task29 - Second Largest Number------------\n");
            Console.WriteLine($"Second Largest Number in numbers List: {task29(numbers1)}");


        }
    }
}
