/*
static int CalculateDiffFromNow(int futureYear)
{
    int currentYear = DateTime.Now.Year;

    int yearDiff = futureYear - currentYear;

    if (yearDiff < 1)
    {
        throw new ArgumentOutOfRangeException();
    }

    return yearDiff;
}

try
{
    int futureYear = 2019;
    int years = CalculateDiffFromNow(futureYear);
    Console.WriteLine($"The year {futureYear} is {years} in the future.");

}
catch (ArgumentOutOfRangeException)
{
    Console.WriteLine("The year is not in the future!");
}
*/

/*
Cat[] cats = new Cat[100];

for (int i = 0; i < cats.Length; i++)
{
    cats[i] = new Cat() { name = $"Katt{i + 1}", age = i + 1 };
}

foreach (var cat in cats)
{
    Console.WriteLine($"{cat.name} är {cat.age} år");
}

class Cat
{
    public string name = "default name";

    public int age = 0;
}
*/


//Action<int, int> addition = Add;

//addition(5, 6);

//static void Add(int a, int b)
//{
//    Console.WriteLine(a + b);
//}


//Func<char, int, string> repeatChar = PrintAdd;

//Console.WriteLine(repeatChar('a', 5));

//static string PrintAdd(char a, int b)
//{
//    return new string(a, b);
//}

//Console.WriteLine("Hello, World!".Encapsulate1("***"));

//Console.WriteLine("Hello, World!".Encapsulate2("<<", ">>"));

//static class StringExtensions
//{
//    public static string Encapsulate1(this string s, string EncapString)
//    {
//        return EncapString + s + EncapString;
//    }

//    public static string Encapsulate2(this string s, string prefix, string suffix)
//    {
//        return prefix + s + suffix;
//    }
//}

//var list = Enumerable
//    .Range(0, 50)
//    .AsParallel()
//    .Select(i => CostlyOperation(i))
//    .ToList();
//Console.WriteLine("\nProcessing Complete! Here is the processed data:\n");
//list.ForEach(i => Console.WriteLine(i));

//static int CostlyOperation(int n)
//{
//    for (int i = 0; i < 1000_000; i++)
//    Console.WriteLine($"Processing element {n}");
//    return n;
//}

