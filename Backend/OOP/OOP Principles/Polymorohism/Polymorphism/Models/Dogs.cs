using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    internal class Dogs : Animals
    {
        public Dogs()
        {
            Console.WriteLine("I'm a Dogs class");
        }
        public override void speak()
        {
            Console.WriteLine("Ooooooo");
        }
    }
}
