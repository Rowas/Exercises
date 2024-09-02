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

/*
//Hide vowels, User defined string, in Swedish
static void Exercise4()
{
    Console.WriteLine("Enter string to print without swedish vowels: ");
    string reqWord = Console.ReadLine();

    char[] vowels = new char[18] { 'A', 'E', 'I', 'O', 'U', 'Y', 'Å', 'Ä', 'Ö', 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };

    char[] hiddenVowels = new char[reqWord.Length];

    int x = 0;

    foreach (char c in reqWord)
    {
        hiddenVowels[x++] = c;
    }
    while (true)
    {
        for (int i = 0; i < hiddenVowels.Length; i++)
        {
            for (int j = 0; j < vowels.Length; j++)
            {
                if (hiddenVowels[i] == vowels[j])
                    hiddenVowels[i] = '*';
            }
            
        }
        if (x == hiddenVowels.Length)
        {
            break;
        }
        else
        {
            x++;
        }
    }
    string printString = new string(hiddenVowels);
    Console.WriteLine(printString);
}
Exercise4();
*/

/*
//Request string from User, check if string is an palindrome
static void Exercise5()
{
    Console.WriteLine("Enter string to test if a palindrome: ");
    string reqWord = Console.ReadLine();

    char[] wordReversed = new char[reqWord.Length];

    int i = reqWord.Length;

    i--;

    foreach (char c in reqWord)
    {
        wordReversed[i] = c;
        i--;
    }
    string printString = new string(wordReversed);

    string testWord1 = reqWord.ToLower();
    string testWord2 = printString.ToLower();

    if (testWord1 == testWord2)
    {
        Console.WriteLine($"{reqWord} is a palindrome.");
    }
    else
    {
        Console.WriteLine($"{reqWord} is not a palindrome.");
    }
}
Exercise5();
*/

/*
//Single line calculator
static void Exercise6()
{

}
Exercise6();
*/

/*
//7 words, user specified, printed reversed order
static void Exercise7()
{

}
Exercise7();
*/