public class Person
{
    // Auto-implemented properties
    public string name { get; set; }
    public int age { get; set; }
    public string address { get; set;}

    // Parameterized constructor
    public Person(string name, int age, string address)
    {
        this.name = name;
        this.age = age;
        this.address = address;
    }

    // Virtual method that can be overridden
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Address : {address},");
    }
}
