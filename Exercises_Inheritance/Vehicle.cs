using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Inheritance
{
    public enum Brands { Toyota, BMW, SAAB, Audi, Volvo }
    public enum Colors { Red, Blue, Green, Black, White }

    public struct Size
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Size(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
    }

    internal class Vehicle
    {

        public Brands Brand { get; set; }
        public Colors Color { get; set; }

        public Size Size = new Size(0,0,0);

        public Vehicle(Brands brand, Colors color) : this(brand)
        {
            Brand = brand;
            Color = color;
        }

        public Vehicle(Brands brand)
        {
            Brand = brand;
            Color = Colors.White;

            var rand = new Random();

            var randLength = rand.NextDouble() + rand.Next(2, 4);
            var randWidth = rand.NextDouble() + rand.Next(1, 3);
            var randHeight = rand.NextDouble() + rand.Next(1, 2);
            Size = new Size(randLength, randWidth, randHeight);
        }

        public override string ToString()
        {
            return $"A {this.Color} {this.Brand}";
        }
    }

    internal class Car : Vehicle
    {
        public string Model { get; set; }

        public Car(Brands brand, string model, Colors color) : base(brand, color)
        {
            Model = model;
        }

        public override string ToString()
        {
            return $"A {this.Color} {this.Size.Length:f1} meter long {Model} from {this.Brand}";
        }
    }

}

