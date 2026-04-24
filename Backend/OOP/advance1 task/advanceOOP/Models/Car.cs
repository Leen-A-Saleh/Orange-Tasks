using System;
using System.Collections.Generic;
using System.Text;

namespace advanceOOP.Models
{
    internal class Car
    {
        public string make { get; set; }
        public int year { get; set; }
        public string type { get; set; }
        public double price { get; set; }
        public string model { get; set; }
        public string palletNo { get; set; }
        public string color { get; set; }

        public Car(string make, int year, string type, double price, string model, string palletNo, string color)
        {
            this.make = make;
            this.year = year;
            this.type = type;
            this.price = price;
            this.model = model;
            this.palletNo = palletNo;
            this.color = color;
        }

        public override string ToString()
        {
            return $"Make: {make}, Model: {model}, Year: {year}, Type: {type}, Price: {price}, Pallet No: {palletNo}, Color: {color}";
        }
    }
}
