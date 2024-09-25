namespace CollegeManagement;
class Admin(string n, string dp, DateTime d, char g) : Person(n, d, g), IAdmin
{
    public string dep = dp;

    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($"\t\t{dep}");
    }

    // Static member
    public static void PrintHeader()
    {
        var header = $"Name\t\tDate Of Birth\t\tGender\t\tDepartment";
        Console.WriteLine(header);
    }
    public List<string> GetRoles() => ["Attendance","Curricular activities"];
}