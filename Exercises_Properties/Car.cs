using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Properties
{
    internal class Car
    {
        private string _carColor = "Default Color";
        private int _carLength = 4;

        public int colorNumber;

        private int _speed = 150;
        private double _distance = 0.0;

        public double Distance
        {
            get
            {
                _distance = double.Round(_distance, 2);
                return _distance;
            }
        }

        public int Speed
        {
            get
            {
                return _speed;
            }
        }

        public string CarColor
        {
            get
            {
                return _carColor;
            }
        }

        public int Length
        {
            get
            {
                return _carLength;
            }
        }

        public Car()
        {
            var randLength = new Random();
            _carLength = randLength.Next(3, 6);
            colorNumber = (new Random()).Next(0, 15);
            Console.ForegroundColor = (ConsoleColor)colorNumber;
            _carColor = Console.ForegroundColor.ToString();
            Console.ResetColor();
            _speed = (new Random()).Next(60, 241);
        }

        public Car(string carColor)
        {
            _carColor = carColor;
            var randLength = new Random();
            this._carLength = randLength.Next(3, 6);
        }

        public void DriveForOneHour(double Speed)
        {
            this._distance = Speed / 10 + this._distance;
        }

        public void GetGraph(double carDistance, int colorNumber)
        {
            for (int i = 0; i < 20; i++)
            {
                if (carDistance / 50 > i && carDistance / 50 < i + 1)
                {
                    Console.ForegroundColor = (ConsoleColor)colorNumber;
                    Console.Write("█");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write("-");
                }
            }
        }

        public static void carDuplication(Car dupliCar)
        {
            Console.WriteLine();
            Console.WriteLine($"Car received: \nColor: {dupliCar._carColor}\nLength: {dupliCar._carLength} ");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Car carDuplicated = new Car(dupliCar.CarColor);
                Console.WriteLine($"Copy {i + 1}: \nColor: {dupliCar._carColor}\nNew Length: {carDuplicated.Length}");
            }
        }
    }
}
