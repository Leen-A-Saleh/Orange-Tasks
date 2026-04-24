using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Models
{
    internal class AirConditioner : Appliance
    {
        public AirConditioner(string brand) : base(brand)
        {
        }
        public override void TurnOff() => Console.WriteLine($"{Brand} Air Conditioner: Turning off");
        public override void TurnOn() => Console.WriteLine($"{Brand} Air Conditioner: Turning on");
    }
}
