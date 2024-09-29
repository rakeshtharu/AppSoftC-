public class CriticalPatient : Patient
{
    // Additional properties for CriticalPatient
    public string ICUStatus { get; set; }

    // Constructor calling base class constructor
    public CriticalPatient(string name, int age, string address, string condition, string icuStatus) 
        : base(name, age, address, condition)
    {
        ICUStatus = icuStatus;
    }

    // Override method from base class
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"ICU Status: {ICUStatus}");
    }
}
