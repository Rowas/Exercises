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