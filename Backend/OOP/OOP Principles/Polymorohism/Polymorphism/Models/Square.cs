using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    internal class Square : Shape
    {
        public double Side { get; set; }
        public Square(double side)
        {
            this.Side = side;
        }
        public override double GetArea()
        {
            return Side * Side;
        }
    }
}
