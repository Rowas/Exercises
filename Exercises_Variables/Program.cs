
/*
//Greetings
static void Exercise1()

{
    Console.WriteLine("Greetings!");
    Console.WriteLine("Could you please tell me your name?");
    string userName = Console.ReadLine();
    Console.WriteLine("Excellent! Nice to meet you " + userName);
}
*/

/*
//Multiplication
static void Excercies2()
{
    Console.WriteLine("Multiplication of two numbers.");

    Console.WriteLine("Provide the first number:");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("");

    Console.WriteLine("Provide the second number:");
    int number2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("");

    Console.WriteLine("The result of the multiplication is: ");
    Console.WriteLine(number1 * number2);
}
*/

/*
//Password Check
static void Exercise3()
{
    string tryAgain = "";
    bool isRunning = true;

    while (isRunning)
    {
        Console.WriteLine("Enter password: ");

        string secretPassword = "qwerty";

        string publicPassword = Console.ReadLine();

        if (publicPassword == secretPassword)
        {
            Console.WriteLine("Password is a match");
            isRunning = false;
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("Wrong password.");
            Console.WriteLine("Try again? y/n");
            tryAgain = Console.ReadLine();
            switch (tryAgain)
            {
                case "Y":
                    Console.WriteLine("");
                    break;
                case "y":
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("Ending program.");
                    isRunning = false;
                    break;
            }
        }
    }
}
*/

/*
//Comparison
static void Exercise4()
{
    Console.WriteLine("Comparison of a number with 100.");
    Console.WriteLine("Enter number to compare:");
    int compareNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("");

    switch (compareNumber)
    {
        case > 100:
            Console.WriteLine("The number is greater than 100!");
            break;
        case < 100:
            Console.WriteLine("The number is less than 100!");
            break;
        default:
            Console.WriteLine("The number is exactly equal to 100!");
            break;
    }
}
*/

/*
//Double and Half
static void Exercise5()
{
    Console.WriteLine("And with that out of the way, I will now give you ");
    Console.WriteLine("the numbers that are twice and half as much as a ");
    Console.WriteLine("provided number. Please give me a number for ");
    Console.WriteLine("comparison.");
    Console.WriteLine("Enter number: ");
    decimal evalNumber = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("The number you provided: " + evalNumber);
    Console.WriteLine("The number that is twice as much: " + evalNumber * 2);
    Console.WriteLine("The number that is half as much: " + evalNumber / 2);
}
*/

/*
//Calculator
static void Exercise6()
{

}
*/

/*
//Sum and Average
static void Exercise7()
{
    double parsedValue = 0.0;
double sumNumber = 0.0;
int enteredNum = 0;

Console.WriteLine("Enter numbers for sum and average.");
Console.WriteLine("To end, enter a non-number.");
while (true)
{
    if (double.TryParse(Console.ReadLine(), out parsedValue))
    {
        sumNumber = sumNumber + parsedValue;
        Console.WriteLine($"Sum of entered numbers: {sumNumber}");
        enteredNum++;
    }
    else
    {
        Console.WriteLine($"Average of entered numbers: {sumNumber / enteredNum}");
        break;
    }
}
*/


