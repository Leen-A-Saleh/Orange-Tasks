using Innterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Innterface.Models
{
    internal class Calculator : ICalculator
    {
        public T Add<T> (T a, T b)where T : INumber<T> => a + b;

        public T div<T>(T a, T b) where T : INumber<T>
        {
            try
            {
                if(b.Equals(T.Zero))
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }
                return a / b;
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public T mul<T>(T a, T b) where T : INumber<T> => a* b;

        public T sub<T>(T a, T b) where T : INumber<T> => a - b;
    }
}
