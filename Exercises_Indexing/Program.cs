//A letter on each row, user specified
static void Exercise1()
{
    Console.WriteLine("Enter a string:");
    string userString = Console.ReadLine();
    foreach (char c in userString)
    {
        Console.WriteLine(c);
    }
}
Exercise1();