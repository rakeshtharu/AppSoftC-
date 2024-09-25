namespace CollegeManagement;
class Teacher(string n, string q, DateTime d, char g) : Person(n, d, g)
{
    public string qualification = q;

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