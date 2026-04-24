using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Abstract.Models
{
    internal class WashingMachine : Appliance
    {
        public WashingMachine(string brand) : base(brand)
        {
        }
        public override void TurnOn() => Console.WriteLine($"{Brand} Washing Machine: Starting cycle");

        public override void TurnOff() => Console.WriteLine($"{Brand} Washing Machine: Stopping cycle");

    }
}
