/*
//Add first and last name together and greet. 
static void Exercise1()
{
    static void Greet(string fName = "", string lName = "")
    {
        Console.WriteLine($"Greetings {fName} {lName}");
    }
    Greet("Andreas", "Andersson");
}
Exercise1();
*/

//Add first and last name together, return result

/*
static void Exercise2()
{
    static string FullName(string fName = "", string lName = "")
    {
        return $"{fName} {lName}";
    }
    Console.WriteLine(FullName("Andreas", "Andersson"));
}
Exercise2();
*/

/*
static void Exercise3()
{
    static bool StringCheck(string compString = "", int compNum = 0)
    {
        if (compString.Length > compNum)
        { 
            return true; 
        }
        return false;
    }
    StringCheck("Try this string for size", 20);
    Console.WriteLine($"Is the string longer than the integer: {StringCheck("Try this string for size", 20)}");
}
Exercise3();
*/

/*
//Convert C to F
static void Exercise4()
{
    static double convertC(double celsius)
    {
        double fahrenheit = 9.0 / 5.0 * celsius + 32.0;
        return fahrenheit;
    }

    Console.WriteLine("Provide a temperature in Celsius: ");
    Console.WriteLine($"The provided temperature is {convertC(Double.Parse(Console.ReadLine()))} F");
}
Exercise4();
*/

/*
//Add - between every letter of a string
static void Exercise5()
{
    static string bindestreck(string namn)
    {
        int j = 0;
        string[] nyttNamn = new string[namn.Length];
        foreach (char c in namn)
        {
            nyttNamn[j] = Convert.ToString(c);
            j++;
        }
        string ReturnNamn = string.Join("-", nyttNamn);
        return ReturnNamn;
    }
    Console.WriteLine(bindestreck("Fredrik"));
}
Exercise5();
*/


/*
//Own version of string.join()
using System.Text.Json;

static void Exercise6()
{
    static string MyJoin(string seperator, params string[] elements)
    {
        int j = 0;
        string[] joinedElements = new string[elements.Length * 2];
        for (int i = 0; i < joinedElements.Length; i++)
        {
            if (i % 2 == 0)
            {
                joinedElements[i] = elements[j];
                j++;
            }
            else if (j == elements.Length)
            {
                break;
            }
            else
            {
                joinedElements[i] = seperator;
            }
        }
        string returnElements = String.Concat(joinedElements);
        return returnElements;
    }
    Console.WriteLine(MyJoin("->", "Sweden", "Finland", "Norway"));
}
Exercise6();
*/

/*
//Take int[] and return average as double
static void Exercise7()
{
    static double intArr(params int[] numbers)
    {
        double average = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            average = average + numbers[i];
        }
        average = average / numbers.Length;
        return average;
    }
    Console.WriteLine($"The average is: {intArr(1, 2, 3)}");
}
Exercise7();
*/

/*
//Translate int number to string number on user request
static void Exercise8()
{
    static string[] NumberToWords()
    {
        Console.WriteLine("Provide some numbers: ");
        string requestedNumbers = Console.ReadLine();

        string[] numberList = new string[10] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

        int[] results = new int[requestedNumbers.Length];

        string[] returnResults = new string[requestedNumbers.Length];

        int x = 0;

        foreach (char c in requestedNumbers)
        {
            results[x] = (int)char.GetNumericValue(c);
            x++;
        }

        for (int i = 0; i < requestedNumbers.Length; i++)
        {
            returnResults[i] = numberList[results[i]];
        }
        return returnResults;
    }
    Console.WriteLine(NumberToWords());
}
Exercise8();
*/


//Convert whole number to matching words
//static void Exercise9()
//{
string inputString = " ";
string Tera = "billion";
string Mega = "million";
string Kilo = "thousands";
string Hecto = "hundred";
string[] Tens = new string[] { "Eleven", "Twelve", "Thrirteen", "Fourtheen", "Fiftheen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
string[] FirstTens = new string[] { "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
string[] Ones = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
int count = 0;

Console.WriteLine("Enter a number (Please, no more than 1 Billion)");
inputString = Console.ReadLine();

int[] Numbers = new int[inputString.Length];

for (int i = 0; i < inputString.Length; i++)
{
    Numbers[i] = (int)Char.GetNumericValue(Convert.ToChar(inputString[i]));
}

if (Numbers.Length == 1)
{
    Console.WriteLine(Ones[Numbers[0]]);
}
else if (Numbers.Length == 2)
{

    if (Numbers[1] == 0)
    {
        Console.WriteLine(FirstTens[Numbers[0] - 1]); 
    }
    else if (Numbers[0] == 1 && Numbers[1] > 0)
    {
        Console.WriteLine(Tens[Numbers[1] - 1]);
    }
    else if (Numbers[1] > 0)
    {
        Console.WriteLine($"{FirstTens[Numbers[0] - 1]} {Ones[Numbers[1]]}");
    }
}
else if (Numbers.Length == 3)
{
    if (Numbers[1] == 0 && Numbers[2] == 0)
    {
        Console.WriteLine($"{Ones[Numbers[0]]} {Hecto}");
    }
    else if (Numbers[1] > 0 && Numbers[2] == 0)
    {
        Console.WriteLine($"{Ones[Numbers[0]]} {Hecto} {FirstTens[Numbers[0] - 1]}");
    }
    else if (Numbers[1] == 0 && Numbers[0] > 0)
    {
        Console.Write($"{Ones[Numbers[0]]} {Hecto} {Ones[Numbers[2]]}");
        Console.WriteLine();
    }
    else if (Numbers[1] > 0 && Numbers[2] > 0)
    {
        Console.WriteLine($"{Ones[Numbers[0]]} {Hecto} {FirstTens[Numbers[1] - 1]} {Ones[Numbers[2]]}");
    }
}
else if (Numbers.Length == 4)
{

}


//}
//Exercise9();



/*
//UNFINISHED!!!
//Find occurance of 'c' in "Text". 
//UNFINISHED!!!

static void Exercise10()
{
    string wordString = " ";
    string searchChar = " ";
    int startIndex = 0;
    int stopIndex = 0;
    List<int> occurrenceList = new List<int>();
    while (wordString == " ")
    {
        Console.WriteLine("Enter a word/sentence: ");
        wordString = Console.ReadLine();
        Console.WriteLine("Enter a char to find occurrence of: ");
        searchChar = Console.ReadLine();
    }
    static (int, int) FindIndex(string wordString, string searchChar, int startIndex)
    {
        int stopIndex = 0;
        for (int i = startIndex; i < wordString.Length; i++)
        {
            if (wordString.Substring(i, 1) == searchChar)
            {
                startIndex = i;
                return (startIndex, stopIndex);
            }
            stopIndex++;
        }
        return (0, stopIndex);
    }
    while (stopIndex < wordString.Length)
    {
        (startIndex, stopIndex) = (FindIndex(wordString, searchChar, startIndex));
        occurrenceList.Add(startIndex);
        startIndex++;
    }

    Console.WriteLine($"Char {searchChar} occurs on index position: {occurrenceList}");

}
Exercise10();
//UNFINISHED!!!
//UNFINISHED!!!
*/

/*
//Dice throwing simulator. 
using System;

static void Exercise11()
{
    static int ThrowDice(int diceSides)
    {
        var randNum = new Random();
        int diceThrow = randNum.Next(diceSides+1);
            switch (diceThrow)
            {
                case 0:
                    diceThrow = randNum.Next(diceSides+1);
                    break;
                default:
                    break;
            }
        return diceThrow;
    }
    //Console.WriteLine(ThrowDice());

    static void ThrowMultipleDice(int n, int y)
    {
        int[] throws = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Dice nr {i+1} is {ThrowDice(y)}.");
        }
        return;
    }
    Console.WriteLine("Input number of dice to throw: ");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine("Input number of sides for the dice: ");
    int y = int.Parse(Console.ReadLine());
    Console.WriteLine("");
    ThrowMultipleDice(x, y);
}
Exercise11();
*/

/*
//Draw a box using a function(x, y)

static void Exercise12()
{
    int width = 3;
    int height = 3;
    static void DrawBox(int width, int height)
    {
        Console.Clear();
        int y = 0;
        while (true)
        {
            if (y == 0)
            {
                for (int i = 0; i < width; i++)
                {
                    Console.SetCursorPosition(i, y);
                    Console.Write("#");
                }
            }
            else if (y == height-1)
            {
                for (int i = 0; i < width; i++)
                {
                    Console.SetCursorPosition(i, y);
                    Console.Write("#");
                }
            }
            else
            {
                for (int i = 0; i < width; i++)
                {
                    if (i > 0 && i < width-1)
                    {
                        Console.SetCursorPosition(i, y);
                        Console.Write("-");
                    }
                    else
                    {
                        Console.SetCursorPosition(i, y);
                        Console.Write("#");
                    }
                }
            }
            y++;
            if (y >= height)
            {
                break;
            }
        }
    }

    Console.WriteLine("Enter width of box to draw: ");
    width = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter height of box to draw: ");
    height = int.Parse(Console.ReadLine());
    DrawBox(width, height);
}
Exercise12();
*/

/*
//Move @ in a box using function from previous Exercise
//Hard coding box size of 25x25

static void Exercise13()
{
    static void DrawBox(int width, int height)
    {
        Console.Clear();
        int y = 0;
        while (true)
        {
            if (y == 0)
            {
                for (int i = 0; i < width; i++)
                {
                    Console.SetCursorPosition(i, y);
                    Console.Write("#");
                }
            }
            else if (y == height - 1)
            {
                for (int i = 0; i < width; i++)
                {
                    Console.SetCursorPosition(i, y);
                    Console.Write("#");
                }
            }
            else
            {
                for (int i = 0; i < width; i++)
                {
                    if (i > 0 && i < width - 1)
                    {
                        Console.SetCursorPosition(i, y);
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.SetCursorPosition(i, y);
                        Console.Write("#");
                    }
                }
            }
            y++;
            if (y >= height)
            {
                break;
            }
        }
    }

    DrawBox(25, 25);

   

    static void MoveMent()
    {
        Console.SetCursorPosition(0, 26);
        ConsoleKeyInfo checkKey;
        Console.WriteLine("Move with arrow-keys on the keyboard. \nPressing Esc will cancel the program.");
        int x = 12;
        int y = 12;
        Console.SetCursorPosition(x, y);
        Console.CursorVisible = false;
        do
        {
            while (Console.KeyAvailable == false)
            {
                Thread.Sleep(25);
            }
            checkKey = Console.ReadKey(true);
            switch (checkKey.Key)
            {
                case ConsoleKey.RightArrow:
                    if (x != 23)
                    {
                        Console.SetCursorPosition(x, y);
                        x++;
                        Console.Write(" ");
                        Console.SetCursorPosition(x, y);
                        Console.Write("@");
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (x != 1)
                    {
                        Console.SetCursorPosition(x, y);
                        x--;
                        Console.Write(" ");
                        Console.SetCursorPosition(x, y);
                        Console.Write("@");
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (y != 1)
                    {
                        Console.SetCursorPosition(x, y);
                        y--;
                        Console.Write(" ");
                        Console.SetCursorPosition(x, y);
                        Console.Write("@");
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (y != 23)
                    {
                        Console.SetCursorPosition(x, y);
                        y++;
                        Console.Write(" ");
                        Console.SetCursorPosition(x, y);
                        Console.Write("@");
                    }
                    break;
            }
        } while (checkKey.Key != ConsoleKey.Escape);
        Console.SetCursorPosition(0, 29);
        Console.WriteLine("Goodbye!");
    }

    Console.SetCursorPosition(12, 12);
    Console.Write("@");

    MoveMent();
}
Exercise13();
*/

