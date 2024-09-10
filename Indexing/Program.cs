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
    List<string> userStrings = new List<string>();
    Console.WriteLine("Enter 7 strings in total (one per line) and have them printed in reverse order. ");
    for (int i = 0; i < 7; i++)
    {
        string stringEntered = Console.ReadLine();
        userStrings.Add(stringEntered);
    }

    userStrings.Reverse();

    Console.Clear();

    Console.WriteLine("Printing words in reverse: ");
    foreach (string strings in userStrings)
    {
        Console.WriteLine(strings);
    }
}
Exercise7();
*/

/*
//delayed print, not enough until 10 words, then print 10 words ago
static void Exercise8()
{

}
Exercise8();
*/

/*
//Word pyramid
static void Exercise9()
{
    string defString = "Hello World";
    for (int i = 0; i < defString.Length; i++)
    {
        string printString = defString.Substring(0, i + 1);
        Console.WriteLine(printString);
    }
}
Exercise9();
*/

/*
//Colored letters, user defined string and char
static void Exercise10()
{
    Console.WriteLine("Enter a string: ");
    string reqString = Console.ReadLine();

    Console.WriteLine("Pick a char to highlight: ");
    char pickedChar = Convert.ToChar(Console.Read());

    for (int i = 0; i < reqString.Length; i++)
    {
        if (reqString[i] == pickedChar)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        Console.Write(reqString[i]);
    }
    Console.ForegroundColor = ConsoleColor.Gray;
}
Exercise10();
*/

/*
//User defined string and start & stop of coloring
static void Exercise11()
{
    Console.WriteLine("Enter a sentence: ");
    string reqSentence = Console.ReadLine();

    Console.WriteLine("Pick a start point (number): ");
    int startNum = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Pick a start point (number): ");
    int stopNum = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < reqSentence.Length; i++)
    {
        if (i < startNum - 1 || i > stopNum - 1)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(reqSentence[i]);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(reqSentence[i]);
        }
    }
    Console.ForegroundColor = ConsoleColor.Gray;
}
Exercise11();
*/

/*
//Color shifting in user defined string between instances of chars
using System.Reflection.Metadata;

static void Exercise12()
{
    int letterFound = 0;
    Console.WriteLine("Enter a sentence: ");
    string userString = Console.ReadLine();
    Console.WriteLine("Enter a letter: ");
    char userLetter = Convert.ToChar(Console.ReadLine());

    foreach (char c in userString)
    {
        if (c == userLetter)
        {
            if (letterFound == 1)
            {
                Console.Write(c);
                letterFound--;
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(c);
                letterFound++;
            }
        }
        else if (c != userLetter && letterFound == 0)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(c);
        }
        else
        {
            Console.Write(c);
        }
    }
    Console.ForegroundColor = ConsoleColor.Gray;
}
Exercise12();
*/
