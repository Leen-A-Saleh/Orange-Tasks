using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Models
{
    static class MathUtilities
    {
        public static T square<T>(T num) where T : INumber<T> => num * num;
        public static double root (double num) => Math.Sqrt(num);
        public static T max<T>(T num1, T num2) where T : INumber<T> => num1 > num2 ? num1 : num2;
    }
}
