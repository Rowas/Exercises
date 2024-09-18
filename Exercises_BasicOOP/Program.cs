/*
//Exercise 1
//Create a class that represents a person
//Two fields, firstName and lastName
//Print full name of two instances of class person


Person person1 = new Person() { firstName = "Martin", lastName = "King" };
Person person2 = new Person() { firstName = "Mike" , lastName = "Tyson" };

Console.WriteLine($"Person 1's full name is: {person1.firstName} {person1.lastName}");

Console.WriteLine($"Person 2's full name is: {person2.firstName} {person2.lastName}");

class Person
{
    public string firstName = "John";

    public string lastName = "Doe";
}
*/

/*
//Exercise 2
//Update to Exercise 1
//Method public string GetFullName()

Person person1 = new Person() { firstName = "Martin", lastName = "King" };
Person person2 = new Person() { firstName = "Mike", lastName = "Tyson" };


Console.WriteLine($"Person 1's full name is: {person1.GetFullName()}");

Console.WriteLine($"Person 2's full name is: {person2.GetFullName()}");


class Person
{
    public string firstName = "John";

    public string lastName = "Doe";

    public string GetFullName()
    {
        return firstName + " " + lastName;
    }
}
*/

/*
//Exercise 3
//Update to Exercise 2
//Method public string GetFullNameReversed()

Person person1 = new Person() { firstName = "Martin", lastName = "King" };
Person person2 = new Person() { firstName = "Mike", lastName = "Tyson" };


Console.WriteLine($"Person 1's full name is: {person1.GetFullName()}");

Console.WriteLine($"Person 2's full name is: {person2.GetFullName()}");

Console.WriteLine($"Person 1's full name reversed is: {person1.GetFullNameReversed()}");

Console.WriteLine($"Person 1's full name reversed is: {person2.GetFullNameReversed()}");

class Person
{
    public string firstName = "John";

    public string lastName = "Doe";

    public string GetFullName()
    {
        return firstName + " " + lastName;
    }

    public string GetFullNameReversed()
    {
        char[] charArrayName = GetFullName().ToCharArray();

        Array.Reverse(charArrayName);

        string outputName = new string(charArrayName);

        return outputName;
    }
}
*/

/*
//Exercise 4
//Update to Exercise 2
//Method public string GetFullName() with overload for title

Person person1 = new Person() { firstName = "Martin", lastName = "King" };
Person person2 = new Person() { firstName = "Mike", lastName = "Tyson" };


Console.WriteLine($"Person 1's full name is: {person1.GetFullName()}");

Console.WriteLine($"Person 2's full name is: {person2.GetFullName()}");

Console.WriteLine($"Person 1's full name is: {person1.GetFullName("Dr.")}");

Console.WriteLine($"Person 2's full name is: {person2.GetFullName("Mr.")}");


class Person
{
    public string firstName = "John";

    public string lastName = "Doe";

    public string GetFullName()
    {
        return firstName + " " + lastName;
    }

    public string GetFullNameReversed()
    {
        char[] charArrayName = GetFullName().ToCharArray();

        Array.Reverse(charArrayName);

        string outputName = new string(charArrayName);

        return outputName;
    }
    
    public string GetFullName(string Title)
    {
        return Title + " " + GetFullName();
    }
}
*/

/*
//Exercise 5, 6, 7
//Update to Person Class
//Add fields for parents
//Add reference to parents
//Add class method returning self and parents

Person mother = new Person() { firstName = "Jane", lastName = "Doe" };
Person father = new Person() { firstName = "John", lastName = mother.lastName };

Person mySelf = new Person() { firstName = "Andreas", lastName = mother.lastName, mother = mother, father = father };

Console.WriteLine($"Person 1's full name is: {mySelf.GetFullName()}");

Console.WriteLine(mySelf.mother.GetFullName());
Console.WriteLine(mySelf.father.GetFullName());

Console.WriteLine(mySelf.GetSelfAndParents());

class Person
{
    public string firstName = "John";
    public string lastName = "Doe";
    public Person mother;
    public Person father;

    public string GetFullName()
    {
        return firstName + " " + lastName;
    }

    public string GetSelfAndParents()
    {
        return $"{this.GetFullName()} {Environment.NewLine} Mother is: {this.mother.GetFullName()} {Environment.NewLine} Father is: {this.father.GetFullName()}";
    }
}
*/

/*
//Exercise 8
//Private field for Height with method for retreiving and changing value 

using System.Runtime.CompilerServices;

Person person1 = new Person() { firstName = "Martin", lastName = "King" };

Console.WriteLine($"Person 1's full name is: {person1.firstName} {person1.lastName}");

Console.WriteLine(person1.GetLength());

person1.SetLength(2.11);

Console.WriteLine(person1.GetLength());

class Person
{
    public string firstName = "John";
    public string lastName = "Doe";

    private double length = 1.80;

    private double weight = 80;

    public void SetLength(double length)
    {
        this.length = length;
    }

    public double GetLength()
    {
        return this.length;
    }
}
*/


/*
//Exercise 9
//Private field for weight with method for retreiving and changing value 
//private, unstored, BMI calculation

using System.Runtime.CompilerServices;

Person person1 = new Person() { firstName = "Martin", lastName = "King" };

Console.WriteLine($"Person 1's full name is: {person1.firstName} {person1.lastName}");

person1.SetLength(2.11);

Console.WriteLine(person1.GetLength());

person1.SetWeight(112.7);

Console.WriteLine(person1.GetWeight());

Console.WriteLine(person1.GetBMI());

class Person
{
    public string firstName = "John";
    public string lastName = "Doe";

    private double length = 1.80;

    private double weight = 80;

    public void SetLength(double length)
    {
        this.length = length;
    }

    public double GetLength()
    {
        return this.length;
    }
    public void SetWeight(double weight)
    {
        this.weight = weight;
    }

    public double GetWeight()
    {
        return this.weight;
    }

    public double GetBMI()
    {
        return (this.weight / Math.Pow(this.length, 2));
    }
}
*/