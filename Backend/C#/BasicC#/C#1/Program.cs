using System.Threading.Channels;

namespace C_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1--------------
            string name = "Leen";
            int age = 25;
            Console.WriteLine($"My name is {name} and I am {age} years old");
            //Task2--------------
            int num;
            int.TryParse(Console.ReadLine(), out num);
            Console.WriteLine(num % 2 == 0 ? "Even" : "Odd");
            //Task3--------------
            string name2 = Console.ReadLine();
            Console.WriteLine(name2);
            //Task4--------------
            int num2;
            Console.WriteLine(int.TryParse(Console.ReadLine(), out num2) ?
                num2 == 0 ? "Zero" : num2 < 0 ? "Negative" : "Positive" : "Invalid");
            //Task5--------------
            int year;
            Console.WriteLine(int.TryParse(Console.ReadLine(), out year) ?
                (year % 4 == 0 && year % 100 != 0) || year % 400 == 0 ? "Leap" : "Not leap" : "Invalid");
            //Task6--------------
            int mark;
            Console.WriteLine(int.TryParse(Console.ReadLine(), out mark) ?
                mark >= 50 ? "Pass" : "Fail" : "Invalid");
            //Task7--------------
            int n1, n2;
            Console.WriteLine(int.TryParse(Console.ReadLine(), out n1) &&
            int.TryParse(Console.ReadLine(), out n2) ?
            n1 > n2 ? n1 : n2 : "invalid");
            //Task8--------------
            Console.WriteLine(int.TryParse(Console.ReadLine(), out n1) ?
                n1 % 5 == 0 && n1 % 3 == 0 ? "divisible" : "Not divisible" : "Invalid");
            //Task9--------------
            char ch;
            Console.WriteLine(char.TryParse(Console.ReadLine(), out ch) ?
                ("aeiou".Contains(char.ToLower(ch))) ? "Vowel" : "Consonant" : "Ivalid");
            //Task10--------------
            int age2;
            Console.WriteLine(int.TryParse(Console.ReadLine(), out age2) ?
                age2 < 12 ? "Child" : age2 >= 12 && age2 <= 18 ? "adult" : "teenager" : "Invalid");
            //Task11--------------
            int day;
            Console.WriteLine(int.TryParse(Console.ReadLine(), out day) ?
                day switch
                {
                    1 => "Sunday",
                    2 => "Monday",
                    3 => "Tuesday",
                    4 => "Wednesday",
                    5 => "Thursday",
                    6 => "Friday",
                    7 => "Saturday",
                    _ => "Invalid day"
                }
                : "Invalid input"
            );
            //Task12--------------
            int month;
            Console.WriteLine(int.TryParse(Console.ReadLine(), out month) ?
            month switch
            {
                1 => "January",
                2 => "February",
                3 => "March",
                4 => "April",
                5 => "May",
                6 => "June",
                7 => "July",
                8 => "August",
                9 => "September",
                10 => "October",
                11 => "November",
                12 => "December",
                _ => "Invalid month"
            }
            : "Invalid input");
            //Task13--------------
            double num1, num11;
            char op;

            Console.WriteLine(double.TryParse(Console.ReadLine(), out num1) &&
        double.TryParse(Console.ReadLine(), out num11) &&
        char.TryParse(Console.ReadLine(), out op)
        ? op switch
        {
            '+' => (num1 + num11).ToString(),
            '-' => (num1 - num11).ToString(),
            '*' => (num1 * num11).ToString(),
            '/' => num11 != 0 ? (num1 / num11).ToString() : "Cannot divide by zero",
            _ => "Invalid operator"
        }
        : "Invalid");
            //Task14--------------
            char grade;

            Console.WriteLine(char.TryParse(Console.ReadLine(), out grade) ?
                char.ToUpper(grade) switch
                {
                    'A' => "Excellent",
                    'B' => "Very Good",
                    'C' => "Good",
                    'D' => "Pass",
                    'F' => "Fail",
                    _ => "Invalid grade"
                }
                : "Invalid input"
            );
            //Task15----------------
            int number;

            Console.WriteLine(int.TryParse(Console.ReadLine(), out number) ?
                 number switch
                 {
                     1 => "You chose One",
                     2 => "You chose Two",
                     3 => "You chose Three",
                     _ => "Invalid number"
                 }
                : "Invalid input"
            );
            //Task16-----------------
            int num3;
            Console.WriteLine(
                int.TryParse(Console.ReadLine(), out num3) ?
                (num3 % 2) switch
                {
                    0 => "Even",
                    1 => "Odd",
                    _ => "Invalid"
                }
                : "Invalid input"
            );
            //Task17----------------
            string s = Console.ReadLine();

            Console.WriteLine(s switch
            {
                "Admin" => "Full access",
                "User" => "Limited access",
                "Guest" => "Read-only access",
                _ => "Invalid role"
            }
            );
            //Task18-------------------
            int choice;
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Exit");
            Console.WriteLine(int.TryParse(Console.ReadLine(), out choice)
                ? choice switch
                {
                    1 => "Add",
                    2 => "Sub",
                    3 => "Exiting...",
                    _ => "Invalid choice"
                }
                : "Invalid input"
            );
            //Task1|2---------------
            double rate;
            Console.WriteLine(double.TryParse(Console.ReadLine(), out rate) ?
                rate <= 100 && rate >= 90 ? $"Excellent{rate * 0.2}" : rate >= 75 && rate <= 89 ?
                $"Very Good{rate * 0.15}" : rate >= 60 && rate <= 74 ? $"Good{rate * 0.1}"
                : "No Bouns" : "Invalid");
            //Task2|2-------------------
            float GPA;
            bool Etest, reco;
            Console.WriteLine("enter GPA then English test true(pass)/false(fail) finally if you have any recommendation true/false");
            Console.WriteLine(float.TryParse(Console.ReadLine(), out GPA) &&
                bool.TryParse(Console.ReadLine(), out Etest) &&
                bool.TryParse(Console.ReadLine(), out reco) ?

                (GPA >= 85 && Etest) || reco ? "Eligible"
                 : "Not Eligible" : "invalid");
            //Task3|2------------------
            decimal weight;
            Console.WriteLine(decimal.TryParse(Console.ReadLine(), out weight) ?
                weight > 0 && weight <= 1 ? "cost is $5" : weight <= 5 ? "cost is $10" :
                weight > 5 && weight <= 10 ? "cost is $20" : "$50,warning:Heavy package" : "Invalid");
            //Task4|2-------------------
            int c = 0;
            string userName = "Leen", pass = "123", userName_in, pass_in;
            while (c < 3)
            {
                userName_in = Console.ReadLine();
                pass_in = Console.ReadLine();
                if (userName == userName_in && pass == pass_in)
                {
                    Console.WriteLine("Welcom");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid,Try again");
                    c++;
                }
            }
            //Task1|3-----------------
            int m;
            Console.WriteLine(int.TryParse(Console.ReadLine(), out m) ?
                m switch
                {
                    1 => "Burger ($5)",
                    2 => "Pizza ($8)",
                    3 => "Pasta ($7)",
                    4 => "Salad ($4)",
                    _ => "Invalid"
                } : "Invalid");

        }
    }
}

