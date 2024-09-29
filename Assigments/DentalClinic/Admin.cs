public class Admin : Person
{
    // Additional properties for Admin
    public string Department { get; set; }

    // Constructor calling base class constructor
    public Admin(string name, int age, string address, string department) : base(name, age, address)
    {
        Department = department;
    }

    // Override base class method
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Department: {Department}");
    }
}
