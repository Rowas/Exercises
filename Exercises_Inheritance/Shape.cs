using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Inheritance
{
    public abstract class Shape
    {
        public abstract double Area { get; }
        public abstract double Circumference { get; }

        protected ConsoleColor color;

        public void Print()
        {
            Console.WriteLine($"A {this} has an area of {this.Area:f2} and a circumference of {Circumference:f2}");
        }
        static public void PrintAll(Shape[] shapes1)
        {
            foreach (var shape in shapes1)
            {
                if (shape is Circle)
                {
                    Console.ForegroundColor = shape.color;
                    shape.Print();
                }
                if (shape is Square)
                {
                    Console.ForegroundColor = shape.color;
                    shape.Print();
                }
                Console.ResetColor();
            }
        }

        static public void PrintCircles(Shape[] shapes1)
        {
            foreach (var shape in shapes1)
            {
                if (shape is Circle)
                {
                    shape.Print();
                }
            }
        }
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area => Math.PI * Math.Pow(Radius, 2);

        public override double Circumference => Math.PI * 2 * Radius;

        public Circle(double radius, ConsoleColor color) : this(radius)
        {
            this.color = color;
        }

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

        public Square(double side, ConsoleColor color) : this(side)
        {
            this.color = color;
        }

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
