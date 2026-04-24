using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    internal class Cats : Animals
    {
        public Cats()
        {
            Console.WriteLine("I'm a cats class");
        }
        public override void speak()
        {
            Console.WriteLine("Meow");
        }
    }
}
