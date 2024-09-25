public class Person(string n, DateTime d, char g)
{
    public string name = n;
    public DateTime dateOfBirth = d;
    string resume = "";
    public char gender = g;

    public virtual void PrintDetails()
    {
        // var output = name + ", " + rollNumber + ", " +  dateOfBirth.ToLongDateString(); 

        // string interpolation
        var message = $"{name}\t\t{dateOfBirth.ToLongDateString()}\t\t{gender}";
        Console.Write(message);
    }
}