namespace array_loop_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------------------------Array--------------------//
            Console.WriteLine("\n---------------------Array-----------\n");
            //p1--------------------
            Console.WriteLine("\n-------------p1---------------");
            int[] arr1 = { 1, 2, 1, 3, 4 };
            List<int> list = new List<int>();
            for(int i = 0; i < arr1.Length; i++)
            {
                if (list.Contains(arr1[i]))
                {
                    break;
                }
                list.Add(arr1[i]);
            }
            Console.WriteLine(string.Join(",", list));
            //p2--------------------
            Console.WriteLine("\n-------------p2---------------");


        }
    }
}
