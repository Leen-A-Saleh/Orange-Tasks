using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    static class Calculator
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double Add(double num1, double num2, double num3)
        {
            return num1 + num2 + num3;
        }
    }
}
