using System.IO;
namespace PeopleManagement;

public class CSVParser
{
    public List<Person> ParseCsv()
    {
        string filePath = @"D:\AppsoftCsharp\Assigments\PeopleManagement\File\People.csv";

        var FInfo = new FileInfo(filePath);
        var csvPath = Path.Combine(FInfo.DirectoryName!, "People.csv");

        var people = new List<Person>();
        var lines = File.ReadAllLines(csvPath);

        //Skip is used to skip header
        foreach (var line in lines.Skip(1))
        {
            var values = line.Split(',');

            var person = new Person
            {
                Index = int.Parse(values[0]),
                UserId = values[1],
                FirstName = values[2],
                LastName = values[3],
                Sex = values[4],
                Email = values[5],
                Phone = values[6],
                DateOfBirth = DateTime.Parse(values[7]),
                JobTitle = values[8]
            };
            people.Add(person);
        }
        return people;
    }
}