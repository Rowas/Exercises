using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Inheritance
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

    struct Size
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }
        public Size(int width, int height, int length)
        {
            Width = width;
            Height = height;
            Length = length;
        }
    }

    internal class Vehicle
    {
        public Brands Brand { get; set; }
        public Colors Color { get; set; }

        public Vehicle(Brands brand, Colors color) : this(brand)
        {
            Color = color;
        }

        public Vehicle(Brands brand)
        {
            Brand = brand;
            Color = Colors.White;
            Size size = new Size(0, 0, 0);
        }

        public override string ToString()
        {
            return $"A {Color} {Brand}";
        }
    }
}
