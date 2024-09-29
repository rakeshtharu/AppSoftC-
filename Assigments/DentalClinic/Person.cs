public class Person
{
    // Auto-implemented properties
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set;}

    // Parameterized constructor
    public Person(string name, int age, string address)
    {
        this.Name = name;
        this.Age = age;
        this.Address = address;
    }

    // Virtual method that can be overridden
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Address : {Address},");
    }
}
