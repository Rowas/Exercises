using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public double Width { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }
        public Size(double width, double height, double length)
        {
            Width = width;
            Height = height;
            Length = length;
        }
    }

    internal class Vehicle
    {
        static Random rand = new Random();

        public Brands Brand { get; set; }
        public Colors Color { get; set; }

        private double length = double.Round(1 + rand.NextDouble(), 2);

        public Size size = new Size(0, 0, 0);

        public Vehicle(Brands brand, Colors color) : this(brand)
        {
            Color = color;
        }

        public Vehicle(Brands brand)
        {
            Brand = brand;
            Color = Colors.White;
        }

        public Vehicle(double width, double height, double length)
        {
            size.Width = width;
            size.Height = height;
            size.Length = length;
        }

        public override string ToString()
        {
            return $"A {Color} {Brand} of the size {size}";
        }
    }
}
