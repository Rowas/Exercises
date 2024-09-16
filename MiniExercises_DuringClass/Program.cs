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

