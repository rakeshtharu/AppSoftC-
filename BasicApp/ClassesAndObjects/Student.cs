class Student : Person
{
    // Default parameterless constructor
    // public Student()
    // {        
    // }

    // Parameterized contructor
    public Student(string n, int r, DateTime d, char g) : base(n, d, g)
    {   
        rollNumber = r;  
    }
    
    public int rollNumber;

    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($"\t\t{rollNumber}");
    }

    // Static member
    public static void PrintHeader()
    {
        var header = $"Name\t\tDate Of Birth\t\tGender\t\tRoll Number";
        Console.WriteLine(header);
    }
}