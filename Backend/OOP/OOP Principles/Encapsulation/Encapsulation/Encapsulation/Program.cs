using Encapsulation.Models;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount user1 = new BankAccount(1000000);
            user1.Deposit(500);
            user1.Withdraw(500000);
            Console.WriteLine(user1);

        }
    }
}
