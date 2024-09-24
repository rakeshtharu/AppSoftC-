public class Person
{
    public Person(string n, DateTime d, char g)
    {
        name = n;
        dateOfBirth = d;
        gender = g;
    }

    public string name = "";
    public DateTime dateOfBirth;
    string resume = "";
    public char gender;

    public virtual void PrintDetails()
    {
        // var output = name + ", " + rollNumber + ", " +  dateOfBirth.ToLongDateString(); 

        // string interpolation
        var message = $"{name}\t\t{dateOfBirth.ToLongDateString()}\t\t{gender}";
        Console.Write(message);
    }
}