using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    internal class Animals
    {
        public Animals()
        {
            Console.WriteLine("I'm a Animal class");
        }
        public virtual void speak() { }
    }
}
