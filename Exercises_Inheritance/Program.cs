using Exercises_Inheritance;
using System.Drawing;


Vehicle car1 = new Vehicle(Brands.Ford, Colors.Red);
Vehicle car2 = new Vehicle(Brands.Honda);


Console.WriteLine($"{car1.Color} {car1.Brand}");

Console.WriteLine();

Console.WriteLine($"{car2.Color} {car2.Brand}");

Console.WriteLine();

Vehicle car3 = new Vehicle(Brands.Audi, Colors.Black);

Console.WriteLine(car3);

Console.WriteLine(new Vehicle(Brands.Toyota, Colors.White));

Console.WriteLine();

Console.WriteLine(new Car(Brands.Toyota, "Yaris", Colors.White));

Console.WriteLine();