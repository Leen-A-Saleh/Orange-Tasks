using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Models
{
    internal class BankAccount
    {
        private double Balance;
        public BankAccount(double balance)
        {
             this.Balance = balance;
        }
        public void Deposit(double balance)
        {
            Balance += balance;
            Console.WriteLine($"The deposit was successful.\n Deposite: {balance}. New Balance: {Balance}");
        }
        public void Withdraw(double balance)
        {
            Balance -= balance;
            Console.WriteLine($"The withdraw was successful.\n Withdraw: {balance}. New Balance: {Balance}");
        }
        override public string ToString()
        {
            return $"Balance: {Balance}";
        }
    }
}