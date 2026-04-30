using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Advanced_Logic_Tasks__List___Array_
{
    internal class Program
    {
        //task20------------
        static List<int> task20(List<int> list, int num)
        {
            for (int i = list.Count - 1; i >= 0; i--) 
            {
                if (list[i] == num) list.RemoveAt(i);
            }
            return list;
        }
        static void Main(string[] args)
        {
            //-------------------------------------------------------------------//

            Console.WriteLine("\n------------Advanced Logic Tasks (List & Array)------------\n");

            Console.WriteLine("\n------------Task1------------\n");
            int[] arr1 = { 1, 2, 1, 3, 5, 1, 5, 1, 3, 5, 1 };
            Dictionary<int,int> dic = new Dictionary<int, int>();
            foreach(var item in arr1)
            {
                if(dic.ContainsKey(item))
                {
                    dic[item]++;
                }
                else
                {
                    dic[item] = 1;
                }
            }
            int max = dic.First().Key;
            int value = dic.First().Value;
            foreach (var item in dic)
            {
                if(item.Value > value)
                {
                    max = item.Key;
                    value = item.Value;
                }
            }
            Console.WriteLine($"The number: {max} - appers: {value} ");

            Console.WriteLine("\n------------Task2------------\n");
            int[] arr2 = { 1, 2, 3, 4, 5 };
            int N = 2;

            for (int i = 0; i < arr2.Length - N; i++) { }

            Console.WriteLine("\n------------Task3------------\n");



            Console.WriteLine("\n------------Task20------------\n");
            List<int> list20 = new List<int>{ 1, 2, 3, 2, 4, 2, 5 };
            Console.WriteLine($"My Own Remove Method: {string.Join(",",task20(list20,2))}");

        }
    }
}
