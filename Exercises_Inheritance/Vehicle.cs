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
        public Colors Color { get; set; } = Colors.White;

        //public Size Size = new Size(0,0,0);

        public Size Size { get; set; }

        public Vehicle(Brands brand, Colors color)
        {
            this.Brand = brand;
            this.Color = color;

            var rand = new Random();

            Size size = new Size();
            size.Length = rand.NextDouble() * 2 + 3.5;
            size.Width = rand.NextDouble() * 0.7 + 1.5;
            size.Height = rand.NextDouble() * 2 + 1;
            Size = size;
        }

        public Vehicle(Brands brand) : this(brand, Colors.White)
        {
            this.Brand = brand;

            //var rand = new Random();

            //var randLength = rand.NextDouble() + rand.Next(2, 4);
            //var randWidth = rand.NextDouble() + rand.Next(1, 3);
            //var randHeight = rand.NextDouble() + rand.Next(1, 2);
            //this.Size = new Size(randLength, randWidth, randHeight);
        }

        public Vehicle() : this(Brands.Toyota, Colors.White)
        {

        }

        public override string ToString()
        {
            return $"A {this.Color.ToString().ToLower()} {this.Brand}";
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
            return $"A {this.Color.ToString().ToLower()} {this.Size.Length:f1} meter long {Model} from {this.Brand}";
        }
    }

}

