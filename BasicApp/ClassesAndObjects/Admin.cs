class Admin(string n, string r, DateTime d, char g) : Person(n, d, g)
{
    public string role = r;

    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($"\t\t{role}");
    }

    // Static member
    public static void PrintHeader()
    {
        var header = $"Name\t\tDate Of Birth\t\tGender\t\trole";
        Console.WriteLine(header);
    }
}