using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Inheritance
{
    public enum Brands
    {
        Ford,
        Honda,
        Audi,
        BMW,
        Toyota
    };
    public enum Colors
    {
        Red,
        Blue,
        Green,
        Black,
        White
    };
    internal class Vehicle
    {
        public Brands Brand { get; set; }
        public Colors Color { get; set; }

        public Vehicle(Brands brand, Colors color)
        {
            Brand = brand;
            Color = color;
        }

        public Vehicle(Brands brand)
        {
            Brand = brand;
            Color = Colors.White;
        }

        public override string ToString()
        {
            return $"A {Color} {Brand}";
        }
    }
}
