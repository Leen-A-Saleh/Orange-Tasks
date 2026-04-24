using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Innterface.Interfaces
{
    internal interface ICalculator
    {
        T Add<T>(T a, T b) where T : INumber<T>;
        T sub<T>(T a, T b ) where T : INumber<T>;
        T mul<T>(T a, T b) where T : INumber<T>;
        T div<T>(T a, T b) where T : INumber<T>;
    }
}
