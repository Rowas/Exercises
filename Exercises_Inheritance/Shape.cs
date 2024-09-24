using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Inheritance
{
    public abstract class Shape
    {
        public abstract double Area { get; }
        public abstract double Circumference { get; }

        public void Print()
        {
            Console.WriteLine($"A {this} has an area of {this.Area:f2} and a circumference of {Circumference:f2}");            
        }
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area => Math.PI * Math.Pow(Radius, 2);

        public override double Circumference => Math.PI * 2 * Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override string ToString()
        {
            return $"Circle with radius {Radius}";
        }
    }

    public class Square : Shape
    {
        public double Side { get; set; }

        public override double Area => Math.Pow(Side, 2);

        public override double Circumference => Side * 4;

        public Square(double side)
        {
            Side = side;
        }

        public override string ToString()
        {
            return $"Square with side {Side}";
        }
    }
}
