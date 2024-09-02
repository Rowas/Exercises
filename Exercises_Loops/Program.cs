/*
//integers 20 to 30
static void Exercise1()
{
    int numberLow = 20;
    int numberHigh = 30;
    for (int i = numberLow; i <= numberHigh; i++)
    {
        Console.WriteLine(i);
    }
}
Exercise1();
*/

/*
//Even number up to 30
static void Exercise2()
{
    int numberEnd = 30;
    for (int i = 0; i <= numberEnd; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }
}
Exercise2();
*/

/*
//Every third "Hey"
static void Exercise3()
{
    int numberEnd = 30;
    for (int i = 0; i <= numberEnd; i++)
    {
        if (i % 3 == 0)
        {
            Console.WriteLine("Hey");
        }
        else
        {
            Console.WriteLine(i);
        }
    }
}
Exercise3();
*/

/*
//Multiplication table
static void Exercise4()
{
    int userNum = 0;
    Console.WriteLine("Enter an integer for it's multiplication table (up to 10):");
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out userNum))
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{userNum} times {i} equals {userNum * i}");
            }
            break;
        }
        else
        {
            Console.WriteLine("Invalid input, enter an integer.");
        }
    }

}
Exercise4();
*/
