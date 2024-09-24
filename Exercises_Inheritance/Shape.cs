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
    }
    public class Circle : Shape
    {
        
    }
}
