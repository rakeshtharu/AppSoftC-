namespace PeopleManagement;
public class PeopleReport
{
    public void SaveMales(List<Person> people)
    {
        var males = people.Where(p => p.Sex.Equals("male", StringComparison.OrdinalIgnoreCase)).ToList();
        WriteToFile(males, "males.csv");
    }
    public void SaveFemales(List<Person> people)
    {
        var adultFemales = (from p in people
                            where string.Equals(p.Sex, "female", StringComparison.OrdinalIgnoreCase)
                            && CalculateAge(p.DateOfBirth) >= 18
                            select p).ToList();

        //  var adultFemales = people.Where(p => p.Sex.Equals("female", StringComparison.OrdinalIgnoreCase) && CalculateAge(p.DateOfBirth) >= 18).ToList();
        WriteToFile(adultFemales, "Females.csv");
    }

    public void SaveDotComUsers(List<Person> people)
    {
        var dotComUsers = (from p in people
                   where p.Email.EndsWith("@example.com", StringComparison.OrdinalIgnoreCase)
                   select new { p.UserId, p.Email, p.Phone }).ToList();

       // var dotComUsers = people.Where(p => p.Email.EndsWith("@example.com", StringComparison.OrdinalIgnoreCase)).Select(p => new { p.UserId, p.Email, p.Phone }).ToList();
        using (var writer = new StreamWriter("dotcomusers.csv"))
        {
            writer.WriteLine("UserId,Email,Phone");
            foreach (var user in dotComUsers)
            {
                writer.WriteLine($"{user.UserId},{user.Email},{user.Phone}");
            }
        }

    }

    private void WriteToFile(List<Person> people, string fileName)
    {
        using (var writer = new StreamWriter(fileName))
        {
            writer.WriteLine("Index, UserId, FirstName, LastName, Sex,Email, Phone, DateOfBirth, JobTitle");
            foreach (var person in people)
            {
                writer.WriteLine($"{person.Index},{person.UserId},{person.FirstName},{person.LastName},{person.Sex},{person.Email},{person.Phone},{person.DateOfBirth:yyyy-mm-d},{person.JobTitle}");
            }
        }
    }
    private int CalculateAge(DateTime dob)
    {
        var today = DateTime.Today;
        var age = today.Year - dob.Year;
        if (dob > today.AddYears(-age)) age--;
        return age;
    }
}