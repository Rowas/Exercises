
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
