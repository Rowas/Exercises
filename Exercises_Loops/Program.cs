﻿/*
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

/*
//Sum of numbers from 1 to 1000
static void Exercise5()
{
    int endNum = 1000;
    int sumNum = 0;
    for (int i = 1; i <= endNum; i++)
    {
        sumNum = sumNum+i;
    }
    Console.WriteLine($"Sum of all numbers from 1 to 1000 is {sumNum}");
}
Exercise5();
*/

/*
//Rice on a chessboard
static void Exercise6()
{
    Console.WriteLine("Rice on a chess board.");

    decimal rice = 1;
    int square = 1;

    for (int i = 0; i < 64; i++)
    {
        Console.WriteLine($"Rice on square {square} is {rice}");
        rice = Convert.ToDecimal(Math.Pow(2, square));
        square++;
    }
}
Exercise6();
*/

/*
//Print filled box to user spec size
static void Exercise7()
{
    int boxHeight = 1;
    int boxWidth = 1;
    int printHeight = 1;
    Console.WriteLine("Enter height of box");
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out boxHeight))
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid input, enter an integer.");
        }
    }
    Console.WriteLine("Enter width of box");
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out boxWidth))
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid input, enter an integer.");
        }
    }
    while (true)
    {
        for (int i = 0; i < boxWidth; i++)
        {
            Console.Write("X");
        }
        if (printHeight == boxHeight)
        {
            break;
        }
        else
        {
            Console.WriteLine("");
            printHeight++;
        }
    }
}
Exercise7();
*/

/*
//Print striped box to user spec size
static void Exercise8()
{
    int boxHeight = 1;
    int boxWidth = 1;
    int printHeight = 1;
    Console.WriteLine("Enter height of box");
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out boxHeight))
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid input, enter an integer.");
        }
    }
    Console.WriteLine("Enter width of box");
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out boxWidth))
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid input, enter an integer.");
        }
    }
    while (true)
    {
        for (int i = 0; i < boxWidth; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }
        }
        if (printHeight == boxHeight)
        {
            break;
        }
        else
        {
            Console.WriteLine("");
            printHeight++;
        }
        
    }
}
Exercise8();
*/

/*
//Checkered box to user spec size
static void Exercise9()
{
    int boxHeight = 1;
    int boxWidth = 1;
    int printHeight = 1;
    Console.WriteLine("Enter height of box");
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out boxHeight))
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid input, enter an integer.");
        }
    }
    Console.WriteLine("Enter width of box");
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out boxWidth))
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid input, enter an integer.");
        }
    }
    while (true)
    {
        for (int i = 0; i < boxWidth; i++)
        {
            if (printHeight % 2 == 0)
            {
                if (i % 2 == 0)
                {
                    Console.Write("O");
                }
                else
                {
                    Console.Write("X");
                }
            }
            else
            {
                if (i % 2 == 0)
                {
                    Console.Write("X");
                }
                else
                {
                    Console.Write("O");
                }
            }
        }
        if (printHeight == boxHeight)
        {
            break;
        }
        else
        {
            Console.WriteLine("");
            printHeight++;
        }

    }
}
Exercise9();
*/

/*
//Hollowed box to user spec size
static void Exercise10()
{
    int boxHeight = 1;
    int boxWidth = 1;
    int printHeight = 1;
    Console.WriteLine("Enter height of box");
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out boxHeight))
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid input, enter an integer.");
        }
    }
    Console.WriteLine("Enter width of box");
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out boxWidth))
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid input, enter an integer.");
        }
    }
    while (true)
    {
        for (int i = 0; i < boxWidth-1; i++)
        {
            if (printHeight == 1 || printHeight == boxHeight)
            {
                Console.Write("X");
            }
            else if (printHeight > 1 && i == 0)
            {
                Console.Write("X");
            }
            else if (i < boxWidth-1)
            {
                Console.Write(" ");
            }
        }
        if (printHeight == boxHeight)
        {
            Console.WriteLine("X");
            break;
        }
        else
        {
            Console.WriteLine("X");
            printHeight++;
        }

    }
}
Exercise10();
*/

/*
//Number pyramid, 1 through 9
static void Exercise11()
{
    int startValue = 1;
    int endValue = 2;
    do
    {
        for (int i = startValue; i < endValue; i++)
        {
            Console.Write(i);
        }
        endValue++;
        Console.WriteLine("");
    } while (endValue <= 10);
}
Exercise11();
*/

/*
//9 number pyramids, 1 through 9
static void Exercise12()
{
    int innerLoop = 2;
    int outerLoop = 1;
    while (innerLoop <= 10)
    {
        innerLoop = 2;
        for (int j = 1; j <= outerLoop; j++)
        {
            for (int i = 1; i < innerLoop; i++)
            {
                if (i == innerLoop)
                {
                    break;
                }
                else
                {
                    Console.Write(i);
                }
            }
            Console.WriteLine("");
            innerLoop++;
        }
        Console.WriteLine("");
        outerLoop++;
    }
}
Exercise12();
*/


//Number of primes up to a user requested amount
static void Exercise13()
{
    Console.WriteLine("Enter the wished for number of primes to show:");

    int primeNumber = 0;
    decimal checkedNum = 2;

    decimal RequestPrimes = Convert.ToDecimal(Console.ReadLine());

    do
    {
        Task PrimeCalc = Task.Run(() =>
        {
            bool isPrime = true;
            for (decimal i = 2; i < checkedNum; i++)
            {
                if (checkedNum % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                primeNumber++;
                if (primeNumber % 1000 == 0)
                {
                    Console.WriteLine($"Prime number {primeNumber} is {checkedNum}");
                }
            }
            checkedNum++;
        });
    } while (primeNumber != RequestPrimes);
}
Exercise13();


/*
//Game - Guess the number
static void Exercise14()
{
    var randNum = new Random();
    int correctGuess = randNum.Next(101);
    var guess = 0;

    while (guess != correctGuess)
    {
        Console.Write("Guess a number between 1 and 100: ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out guess))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input, enter an integer.");
            }
        }
        if (guess > correctGuess)
        {
            Console.WriteLine("Wrong, too high, try again.");
        }
        else if (guess < correctGuess)
        {
            Console.WriteLine("Wrong, too low, try again.");
        }

    }
    Console.WriteLine("");
    Console.WriteLine("You guessed correct!");
}
Exercise14();
*/

/*
//Rock, Paper, Scissors
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

static void Exercise15()
{
    static string CompareResult(int cpuChoice, int pcChoice)
    {
        string result;
        if (cpuChoice == pcChoice)
        {
            result = "Draw";
        }
        else if (cpuChoice == 0 && pcChoice == 2)
        {
            result = "CPU Wins";
        }
        else if (cpuChoice == 2 && pcChoice == 0)
        {
            result = "PC Wins";
        }
        else if (cpuChoice == 2 && pcChoice == 1)
        {
            result = "CPU Wins";
        }
        else if (cpuChoice == 1 && pcChoice == 2)
        {
            result = "PC Wins";
        }
        else if (cpuChoice == 1 && pcChoice == 0)
        {
            result = "CPU Wins";
        }
        else
        {
            result = "PC Wins";
        }
        return result;

    }
    var randChoice = new Random();
    string[] options = new string[3] { "Rock", "Paper", "Scissors" };
    string playerChoice;
    int pcChoice = 3;
    int cpuChoice;
    int cpuWins = 0;
    int pcWins = 0;
    int draw = 0;
    int rounds = 0;
    bool isStop = false;
    while (true)
    {
        Console.WriteLine("Pick a choice: ");
        Console.WriteLine("Rock, Paper, or Scissors.");
        Console.WriteLine("Type Stop to end the game.");
        while (true)
        {

            playerChoice = Console.ReadLine();
            switch (playerChoice)
            {
                case "Rock":
                    pcChoice = 0;
                    break;
                case "Paper":
                    pcChoice = 1;
                    break;
                case "Scissors":
                    pcChoice = 2;
                    break;
                case "Stop":
                    isStop = true;
                    break;
                default:
                    Console.WriteLine("Not a valid choice, try again.");
                    continue;
            }
            break;
        }
        if (isStop == true)
        {
            break;
        }
        cpuChoice = randChoice.Next(3);

        string result = CompareResult (cpuChoice, pcChoice);

        Console.WriteLine(result);

        if (result == "PC Wins")
        {
            rounds++;
            pcWins++;
        }
        else if (result == "CPU Wins")
        {
            rounds++;
            cpuWins++;
        }
        else
        {
            rounds++;
            draw++;
        }

    }
    Console.WriteLine();
    Console.WriteLine("Game has ended.");
    Console.WriteLine();
    Console.WriteLine("Results are as follows: ");
    Console.WriteLine();
    Console.WriteLine($"Rounds won by Player: {pcWins}");
    Console.WriteLine($"Rounds won by CPU: {cpuWins}");
    Console.WriteLine($"Rounds ended in a draw: {draw}");
}
Exercise15();
*/