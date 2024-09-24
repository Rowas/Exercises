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
            Length = length;
            Width = width;
            Height = height;
        }
    }

    internal class Vehicle
    {

        public Brands Brand { get; set; }
        public Colors Color { get; set; }

        public Size Size = new Size(0, 0, 0);

        //Size size2 = new Size(RandSize().Item1, RandSize().Item2, RandSize().Item3)

        public Vehicle(Brands brand, Colors color)
        {
            Brand = brand;
            Color = color;
        }

        public Vehicle(Brands brand)
        {
            Brand = brand;
            Color = Colors.White;
            Size size1 = new Size(RandSize().Item1, RandSize().Item2, RandSize().Item3);
        }

        public override string ToString()
        {
            return $"A {this.Color} {this.Brand}";
        }
        
        public (double, double, double) RandSize()
        {
            var rand = new Random();

            var randLength = rand.NextDouble() + rand.Next(2, 4);
            var randWidth = rand.NextDouble() + rand.Next(1, 3);
            var randHeight = rand.NextDouble() + rand.Next(1, 2);
            var size = new Size(randLength, randWidth, randHeight);

            return (randLength, randWidth, randHeight);
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
            return $"A {this.Color} {Model} from {this.Brand}";
        }
    }

}

