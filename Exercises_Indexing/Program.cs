/*
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
*/

/*
//Translate int number to string number on user request
static void Exercise2()
{
    string[] numberList = new string[10] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

    Console.Write($"Enter a number: ");
    int requestNum = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(numberList[requestNum]);
}
Exercise2();
*/

/*
//Print user string in reverse
static void Exercis3()
{
    Console.WriteLine("Enter string to print backwards: ");
    string reqWord = Console.ReadLine();

    string[] reqWordRev = new string[reqWord.Length];

    int i = reqWord.Length;

    i--;

    foreach (char c in reqWord)
    {
        Console.Write(reqWord[i]);
        i--;
    }
}
Exercise3();
*/