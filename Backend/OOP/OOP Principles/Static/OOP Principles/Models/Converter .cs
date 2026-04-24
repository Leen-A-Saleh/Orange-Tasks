using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles.Models
{
    internal class Converter
    {
        public static double celsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        public static double fahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
        public static double kilometersToMiles(double kilometers)
        {
            return kilometers * 0.621371;
        }
        public static double milesToKilometers(double miles)
        {
            return miles / 0.621371;
        }
    }
}
