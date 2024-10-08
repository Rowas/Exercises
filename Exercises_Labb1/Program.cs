﻿/*
//Labb Exercise1
string wordCheck1 = "Hello World!";
foreach (char c in wordCheck1)
{ 
    if (c ==  ' ')
    {
        break;
    }
    else
    {
        Console.Write(c);
    }
}
*/

/*
//Labb Exercise2
string wordCheck2 = "This is just some other text";
foreach (char c in wordCheck2)
{
    if (c == ' ')
    {
        Console.WriteLine("");
    }
    else
    {
        Console.Write(c);
    }
}
*/

/*
//Labb Exercise3
string wordCheck3 = "Detta är uppgift 3";
int i = 1;
foreach (char c in wordCheck3)
{
    if (i % 2 == 0)
    {
        Console.Write("*");
    }
    else
    {
        Console.Write(c);
    }
    i++;
}
*/

/*
//Labb Exercise4
string wordCheck4 = "Hello World";
foreach (char c in wordCheck4)
{
    if (c == 'l')
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(c);
    }
    else if (c == 'o')
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(c);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(c);
    }
        
}
/*

/*
//Labb Exercise5
string wordCheck = "Hello World";
for (int i = 0; i < wordCheck.Length - 1; i++)
{

    if (wordCheck[i] == wordCheck[i + 1])
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(wordCheck[i]);
        Console.Write(wordCheck[i + 1]);
        i++;
    }
    else
    {
        Console.ForegroundColor= ConsoleColor.Gray;
        Console.Write(wordCheck[i]);
    }
    if (i == wordCheck.Length - 2)
    {
        Console.WriteLine(wordCheck[i + 1]);
    }
}
*/

/*
//Labb Exercise6
string longString = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
string shortString = "oo";

for  (int i = 0; i < longString.Length - 1; i++)
{ 
    if (longString.Substring(i, shortString.Length) == shortString)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(longString.Substring(i, 2));
        i++;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(longString[i]);
    }
}
*/

/*
//Labb Exercise7
string longString = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
string shortString = "chuck";

for (int i = 0; i <= longString.Length - shortString.Length; i++)
{
    if (longString.Substring(i, shortString.Length) == shortString)
    {
        for (int y = i; y < shortString.Length + i; y++)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(longString.Substring(y, 1));
        }
        i += shortString.Length-1;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(longString[i]);
    }
    if (i >= longString.Length - shortString.Length)
    {
        for (int y = i; y < longString.Length-1; y++)
        {
            if (longString.Substring(i, 1).Contains(shortString) == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.Write(longString.Substring(y+1, 1));
        }
    }
}
Console.ForegroundColor = ConsoleColor.Gray;
*/

/*
//Labb Exercise8
string longString = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
Console.WriteLine(longString);
Console.WriteLine("Enter string to search from in above text: ");
string shortString = Console.ReadLine();

for (int i = 0; i <= longString.Length - shortString.Length - 1; i++)
{
    int j = 0;
    if (longString.Substring(i, shortString.Length) == shortString)
    {
        while (j < shortString.Length - 1)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(longString.Substring(i, 1));
            i++;
            j++;
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(longString.Substring(i, 1));
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(longString[i]);
    }
    if (i == longString.Length - shortString.Length - 1)
    {
        i++;
        while (i <= longString.Length - 1)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(longString.Substring(i, 1));
            i++;
        }
    }
    Console.ForegroundColor= ConsoleColor.Gray;
}
*/

/*
//Labb Exercise9
string printString = "Hello world!";
for  (int i = 0; i < printString.Length; i++)
{
    for (int j = 0; j <= i; j++)
    Console.Write(printString.Substring(i, 1));
    Console.WriteLine();
}
*/

/*
//Labb Exercise10
static void Exercise10()
{
    string chopString = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
    string[] choppedArray = chopString.Split(" ");
    int endLine = 0;
    
    while(endLine < choppedArray.Length)
    {
        for (int i = endLine; i <= endLine+1; i++)
        {
            Console.Write(choppedArray[i]);
        }
        Console.WriteLine();
        endLine++;
    }
}
Exercise10();
*/

//Labb Exercise11

/*
//Labb Exercise12
static void Exercise12()
{
    string text = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
    
    int removeMin = 0;
    //int removePlus = 0;
    int startIndex = 0;
    string foundWord = "";
    int endLine = 0;

    static (string, int) FindWord(string providedText, int wordIndex)
    {
        int indexReturn = 0;
        char findSpace = ' ';
        indexReturn = providedText.IndexOf(findSpace, wordIndex);
        string wordReturn = providedText.Substring(wordIndex, indexReturn);
        return (wordReturn, indexReturn);
    }

    static (string, string) wordChop(string foundWord, string chopText, int startIndex, int removeMin)
    {

        string beforeWord = chopText.Remove(removeMin);
        string afterWord = chopText.Remove(0, startIndex);

        return (beforeWord, afterWord);
    }

    static void PrintText(string word, string before, string after)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(before);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(word);
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(after);
    }

    while (endLine <= text.Length)
    {
        (foundWord, startIndex) = FindWord(text, startIndex);
        (string before, string after) = wordChop(foundWord, text, startIndex, removeMin);
        PrintText(foundWord, before, after);
        removeMin = startIndex;
        endLine = endLine + startIndex;
    }

    
}
Exercise12();
*/

/*
//Labb Exercise13
string stringValue = "abcdefghijklmnopqrstuvwxyz";

for (int i = 0; i < stringValue.Length-4; i++)
{
    Console.Write(stringValue.Substring(0, i));
    while (true)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(stringValue.Substring(i, 5));
        break;
    }
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write(stringValue.Substring(i + 5, stringValue.Length - 5 - i));
    Console.WriteLine();
}
*/


/*
//Labb Exercise14
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("Enter a string: ");
string userString = Console.ReadLine();
string firstLetter = userString.Substring(0,1);
Console.ForegroundColor = ConsoleColor.Red;
for (int i = 0; i <= userString.Length - 2; i++)
{
    Console.Write(userString.Substring(i, 1));
    if (userString.Substring(i+1,1) == firstLetter)
    {
        Console.Write(userString.Substring(i+1, 1));
        Console.ForegroundColor = ConsoleColor.Gray;
        i++;
    }
    if (i == userString.Length-2)
    {
        Console.Write(userString.Substring(i+1,1));
    }
}
Console.ForegroundColor= ConsoleColor.Gray;
*/

/*
//Labb Exercise15
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("Enter a string: ");
string userString = Console.ReadLine();
int x = 0;
Console.WriteLine();
string firstRun = userString.Substring(0, x + 1);
int nRun = 0;
Console.ForegroundColor = ConsoleColor.Red;
for (int i = 0; i < userString.Length - 4; i++)
{
    Console.Write(userString.Substring(0, i));
    while (true)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(userString.Substring(i, 5));
        break;
    }
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.Write(userString.Substring(i + 5, userString.Length - 5 - i));
    Console.WriteLine();
}
*/