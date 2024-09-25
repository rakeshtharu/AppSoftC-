namespace CollegeManagement;
class Student(string n, int r, DateTime d, char g) : Person(n, d, g)
{
    public int rollNumber = r;

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