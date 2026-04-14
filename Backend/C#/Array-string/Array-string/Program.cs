namespace Array_string
{
    internal class Program
    {
        //sum fn
        static int sumArr(int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            return sum;
        }
        //even/odd
        static void evenOdd(int[] nums,out int Ec,out int Oc)
        {
            Ec = 0; Oc = 0;
            foreach(int num in nums)
            {
                if (num % 2 == 0) Ec++; else Oc++;
            }
        }
        //Avg
        static int AVG(int[] nums)
        {
            int avg = 0;
            int s = nums.Length;
            avg = sumArr(nums) / s;
            return avg;
        }
        //filter
        static int[] filter(int[] nums)
        {
            List<int> copy = new List<int>();   
            foreach(int num in nums)
            {
                if (num > AVG(nums))
                {
                    copy.Add(num);
                }
            }
            return copy.ToArray();
        }
        //largest
        static int largest(int[] nums)
        {
            int large = 0;
            foreach( int num in nums)
            {
                if (num > large) large = num;
            }
            return large;
        }
        //Task4-------------------
        static void task4()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Are you employed ? true/false: ");
            bool isEmployed = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("\n-----------------\n");
            Console.WriteLine($"Full Name : {name}");
            Console.WriteLine($"Age       : {age}");
            Console.WriteLine($"Height    : {height} meters");
            Console.WriteLine($"Employed  : {isEmployed}");
        }

        static void Main(string[] args)
        {
            //Task1-3 -------------------
            int[] nums = [10, 15, 22, 7, 8, 13, 30];
            int[] copy = filter(nums);
            int sum = sumArr(nums), avg = AVG(nums), large = largest(nums);
            evenOdd(nums, out int even, out int odd);
            Console.WriteLine($"sum {sum} - AVG {avg} - largest {large} - even {even} - odd {odd} - filter {string.Join(",",copy)}");

            //task4
            task4();
        }
    }
}
