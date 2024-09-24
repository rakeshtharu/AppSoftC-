class Teacher : Person
{
    public string qualification = "";

    public Teacher(string n, string q, DateTime d, char g) : base(n, d, g)
    {   
        qualification = q;  
    }

    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($"\t\t{qualification}");
    }

    // Static member
    public static void PrintHeader()
    {
        var header = $"Name\t\tDate Of Birth\t\tGender\t\tQualification";
        Console.WriteLine(header);
    }
}