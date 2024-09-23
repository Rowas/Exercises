/*
//Exercise1
//Get/set _firstname

Person mySelf = new Person();

mySelf.FirstName = "Slim";

Console.WriteLine($"Hi, my name is {mySelf.FirstName}");

class Person
{
    private string _firstName = "Bond";
    
    public string FirstName
    {
        get
        {
            return _firstName;
        }
        set
        {
            _firstName = value;
        }
    }
}
*/

/*
//Exercise2
//Auto-Property LastName

Person mySelf = new Person();

mySelf.FirstName = "Slim";
mySelf.LastName = "Shady";

Console.WriteLine($"Hi, my name is {mySelf.FirstName} {mySelf.LastName}");

class Person
{
    private string _firstName = "Bond";

    public string LastName { get; set; }

    public string FirstName
    {
        get
        {
            return _firstName;
        }
        set
        {
            _firstName = value;
        }
    }
}
*/

/*
//Exercise3
//Read only FullName

Person mySelf = new Person();

mySelf.FirstName = "Slim";
mySelf.LastName = "Shady";

Console.WriteLine($"Hi, my name is {mySelf.FirstName} {mySelf.LastName}");

Console.WriteLine($"My full name is {mySelf.FullName}");

class Person
{
    private string _firstName = "Bond";

    public string FullName
    {
        get
        {
            return $"{_firstName} {LastName}";
        }
    }
    public string LastName { get; set; }

    public string FirstName
    {
        get
        {
            return _firstName;
        }
        set
        {
            _firstName = value;
        }
    }
}
*/

/*
//Exercise4
//Step counter method

Stepcounter stepsTaken = new Stepcounter();

while (true)
{
    stepsTaken.Step();
    Console.WriteLine(stepsTaken.Steps);
    if (stepsTaken.Steps == 1000)
    {
        stepsTaken.Reset();
        Console.WriteLine(stepsTaken.Steps); 
        break;
    }
}

class Stepcounter
{
    private int _steps = 0;

    public int Steps
    {
        get 
        {
            return _steps;
        }
    }

    public void Step()
    {
        _steps++;
    }

    public void Reset()
    {
        _steps = 0;
    }
}
*/

/*
//Exercise5
//Class Car with properties

Car car1 = new Car("Nissan Micra", "White", 5000);

Console.WriteLine($"Model of car: {car1.Model}");
Console.WriteLine($"Colour of car: {car1.Color}");
Console.WriteLine($"Price of car: {car1.Price}");

car1.HalfPrice();

Console.WriteLine($"New price of car: {car1.Price}");

Console.WriteLine();
class Car
{
    private string _model;
    private string _color;
    private int _price;

    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }
    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }
    public int Price
    {
        get { return _price; }
        set { _price = value; }
    }

    public Car()
    {
        Model = "default model";
        Color = "default color";
        Price = 10000;
    }

    public Car(string model, string color, int price)
    {
        Model = model;
        Color = color;
        Price = price;
    }

    public void HalfPrice()
    {
        Price = Price / 2;
    }
}
*/

/*
//Exercise6
//Water glass
//Fill, empty, broken, etc

Waterglass glass1 = new Waterglass();

glass1.Empty();

glass1.Fill();
glass1.Fill();

glass1.Empty();

glass1.Break();
glass1.Break();

glass1.Fill();
glass1.Empty();

Waterglass glass2 = new Waterglass();

glass2.Fill();
glass2.Break();

class Waterglass
{
    private int _waterLevel = 0;
    private bool _isBroken = false;

    public int WaterLevel
    {
        get
        {
            return _waterLevel;
        }
    }

    public void Fill()
    {
        if (_waterLevel == 1 && _isBroken == false)
        {
            Console.WriteLine("The glass is already filled.");
            return;
        }
        else if (_isBroken == true)
        {
            Console.WriteLine("The glass is broken and can't be filled.");
            return;
        }
        _waterLevel = 1;
        Console.WriteLine("The glass is being filled.");
    }

    public void Empty()
    {
        if (_waterLevel == 0 && _isBroken == false)
        {
            Console.WriteLine("The glass is already empty.");
            return;
        }
        else if ( _isBroken == true)
        {
            Console.WriteLine("The glass is broken and can't be emptied.");
            return;
        }
        _waterLevel = 0;
        Console.WriteLine("The glass is being emptied.");
    }

    public void Break()
    {
        if (_isBroken == true)
        {
            Console.WriteLine("The glass is already broken.");
            return;
        }
        _isBroken = true;
        if (_waterLevel == 1)
        {
            Console.WriteLine("The glass is broken and the water runs over the table.");
        }
        else
        {
            Console.WriteLine("The glass is broken and shards are all over the table.");
        }
    }
}
*/

/*
BlueRed blueRed = new BlueRed();

Console.WriteLine("Pick a colour: Blue or Red");
string colour = Console.ReadLine();
switch(colour)
{
    case "Blue":
        Console.WriteLine("How much blue?");
        double blue = Convert.ToDouble(Console.ReadLine());
        blueRed.Blue = blue;
        Console.WriteLine($"Current Values: \nBlue:{blueRed.Blue}\nRed:{blueRed.Red}");
        break;
    case "Red":
        Console.WriteLine("How much red?");
        double red = Convert.ToDouble(Console.ReadLine());
        blueRed.Red = red;
        Console.WriteLine($"Current Values: \nBlue:{blueRed.Blue}\nRed:{blueRed.Red}");
        break;
}

class BlueRed
{
    private double _blue = 50.0;
    private double _red = 50.0;

    public double Blue
    {
        get
        {
            return _blue;
        }
        set
        {
            _blue =+ value;
            _red =- value;
            if (_blue > 100.0 || _red + _blue > 100.0 || _red < 0.0)
            {
                _blue = 100.0;
                _red = 0.0;
                Console.WriteLine($"Min or Max value reached. Setting to: \n Blue = {_blue}\nRed = {_red}");
            }
        }
    }
    public double Red
    {
        get
        {
            return _red;
        }
        set
        {
            _red += value;
            _blue -= value;
            if (_red > 100.0 || _red + _blue > 100.0 || _blue < 0.0)
            {
                _red = 100.0;
                _blue = 0.0;
                Console.WriteLine($"Min or Max value reached. Setting to: \n Red = {_red}\nBlue = {_blue}");
            }
        }
    }
}
*/
using Exercises_Properties;
using System.Net;
using System.Runtime.CompilerServices;

//Exercise8, 9, 10
//Car class + static method + simulation
//static int sumOfLength(int[] carLength, string[] carColor)
//{
//    int sumLength = 0;

//    for (int i = 0; i < 1000; i++)
//    {
//        if (carColor[i] == "Green")
//        {
//            sumLength = carLength[i] + sumLength;
//        }
//    }
//    return sumLength;
//}


//int[] carLength = new int[1000];
//string[] carColor = new string[1000];

Car[] cars = new Car[10];

for (int i = 0; i < cars.Length; i++)
{
    cars[i] = new Car();          
}

bool isOneKLess = true;

Console.CursorVisible = false;

while (isOneKLess == true)
{
    for (int i = 0; i < cars.Length; i++)
    {
        Console.ForegroundColor = (ConsoleColor)cars[i].colorNumber;
        Console.Write($"Car {i + 1}: ");
        Console.ResetColor();
        if (i < 9)
        {
            Console.CursorLeft = +8;
        }
        cars[i].GetGraph(cars[i].Distance, cars[i].colorNumber);
        cars[i].DriveForOneHour(cars[i].Speed);
        if (cars[i].Distance >= 1000)
        {
            Console.ForegroundColor = (ConsoleColor)cars[i].colorNumber;
            Console.Write($"Car {i + 1} ");
            Console.WriteLine($"has now driven 1000 km or more, ending after this loop");
            Console.ResetColor();
            isOneKLess = false;
        }
    }
    Thread.Sleep(1000);
    Console.Clear();
}

for (int i = 0; i < cars.Length; i++)
{
    Console.ForegroundColor = (ConsoleColor)cars[i].colorNumber;
    Console.Write($"Car {i + 1}");
    Console.ResetColor();
    Console.WriteLine($" drove {cars[i].Distance} km.");
}

//Console.WriteLine($"Length of all 'Green' cars is: {sumOfLength(carLength, carColor)}");

//Car carToDupli = new Car();

//Car.carDuplication(carToDupli);
