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