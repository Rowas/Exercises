//Exercise 1

//?????????


//Exercise 2 

//?????????

//Exercise 3

Func<string, string, string> myFirstDelegate = FullName;

Console.WriteLine(myFirstDelegate("John", "Doe"));

static string FullName(string first, string last)
{
    return $"{first} {last}";
}

