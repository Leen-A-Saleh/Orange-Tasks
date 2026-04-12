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

            Console.WriteLine(
                double.TryParse(Console.ReadLine(), out num1) &&
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

            Console.WriteLine(char.TryParse(Console.ReadLine(), out grade)?
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

            Console.WriteLine(int.TryParse(Console.ReadLine(), out number)?
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
            Console.WriteLine(
                int.TryParse(Console.ReadLine(), out choice)
                ? choice switch
                {
                    1 => "Add",
                    2 => "Sub",
                    3 => "Exiting...",
                    _ => "Invalid choice"
                }
                : "Invalid input"
            );
            //Task19---------------



















        }
    }
}

