using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Models
{
    abstract class Appliance
    {
        public string Brand { get; set; }
        protected Appliance(string brand)
        {
            this.Brand = brand;
        }
        abstract public void TurnOn();
        abstract public void TurnOff();
    }
}
