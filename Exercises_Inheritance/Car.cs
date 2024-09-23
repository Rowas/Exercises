using Exercise_Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exercises_Inheritance
{
    internal class Car : Vehicle
    {
        public string Model { get; set; }

        public Car(Brands brand, string model, Colors color) : base(brand, color)
        {
            Model = model;
        }

        public override string ToString()
        {
            return $"A {Color} {Model} from {Brand}";
        }
    }
}
