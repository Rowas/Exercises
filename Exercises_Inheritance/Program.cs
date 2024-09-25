using Exercises_Inheritance;
using System.Drawing;


// Exercise 1 through 5
// Car and Vehicle classes

Console.WriteLine();

Vehicle vehicle1 = new Vehicle(Brands.Toyota, Colors.Blue);
Vehicle vehicle2 = new Vehicle(Brands.BMW);

Console.WriteLine($"Car 1 is a: {vehicle1.Brand}, of the color: {vehicle1.Color}");
Console.WriteLine($"Car 2 is a: {vehicle2.Brand}, of the color: {vehicle2.Color}");
Console.WriteLine();
Console.WriteLine($"{vehicle1} and {vehicle2}");
Console.WriteLine();
Console.WriteLine(new Vehicle(Brands.Toyota, Colors.White));
Console.WriteLine();
Console.WriteLine(new Car(Brands.Toyota, "Yaris", Colors.White));
Console.WriteLine();
Console.WriteLine($"Car1 is of the following size:\nLength: {vehicle1.Size.Length:f1} m\nWidth: {vehicle1.Size.Width:f1} m\nHeight: {vehicle1.Size.Height:f1} m");


// Exercise 6 through 12

//var circle1 = new Circle(5);
//Console.WriteLine(circle1);
//Console.WriteLine($"Area: {circle1.Area:f2}");
//Console.WriteLine($"Circumference: {circle1.Circumference:f2}");

//Console.WriteLine();

//var square1 = new Square(5);
//Console.WriteLine(square1);
//Console.WriteLine($"Area: {square1.Area:f2}");
//Console.WriteLine($"Circumference: {square1.Circumference:f2}");


//var square2 = new Square(3.2);
//square2.Print();

//var circle2 = new Circle(4.5);
//circle2.Print();


//Shape[] shapes = new Shape[10];

//var rand = new Random();

//for (int i = 0; i < shapes.Length; i++)
//{
//    int randColor = rand.Next(1, 16);
//    if (rand.Next(0, 10) > 5)
//    {
//        shapes[i] = new Square(rand.Next(1, 10), (ConsoleColor)randColor);
//    }
//    else
//    {
//        shapes[i] = new Circle(rand.Next(1, 10), (ConsoleColor)randColor);
//    }
//}

//Shape.PrintAll(shapes);

//Console.WriteLine();