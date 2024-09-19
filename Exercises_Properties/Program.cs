//Exercise1
//Get/set _firstname

Person mySelf = new Person();

mySelf.FirstName = "Slim";

Console.WriteLine($"Hi, my name is {mySelf.FirstName}");

class Person
{
    private string _firstName = "Bond";
    
    public string FirstName
    {
        get
        {
            return _firstName;
        }
        set
        {
            _firstName = value;
        }
    }
}