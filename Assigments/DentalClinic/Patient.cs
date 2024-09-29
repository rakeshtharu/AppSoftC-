public class Patient : Person, IMedicine
{
    // Additional properties for Patient
    public string Condition { get; set; }

    // Constructor calling base class constructor
    public Patient(string name, int age, string address, string condition) : base(name, age, address)
    {
        Condition = condition;
    }

    // Implement IMedicine methods
    public void PrescribeMedicine()
    {
        Console.WriteLine("Patient receives a prescription.");
    }

    public void Treat()
    {
        Console.WriteLine("Patient is being treated.");
    }

    // Override base class method
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Condition: {Condition}");
    }
}
