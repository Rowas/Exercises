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
}
Exercise3();
*/