using System.IO;
using CollegeManagement;
public class FileAndFolderHandler
{
    string filePath = @"D:\AppsoftCsharp\BasicApp\FileIO\Data\student.txt";
    FileInfo FInfo => new FileInfo(filePath);
    public void CreateFile()
    {
        try
        {
            File.WriteAllText(filePath, "This File contains reports on students of NAST");
            Console.WriteLine($"{FInfo.Name} File Created");
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void ReadFile()
    {
        var content = File.ReadAllText(filePath);
        Console.WriteLine(content);
    }
    public void CreateFolder(string newFolder)
    {
        var folderPath = Path.Combine(FInfo.DirectoryName!, newFolder);
        Directory.CreateDirectory(folderPath);
    }
    public void ReadCsv()
    {
        var csvPath = Path.Combine(FInfo.DirectoryName!, "student.csv");
        var lines = File.ReadAllLines(csvPath);
        //need to print name and dob
        var header = lines[0];
        var headerParts = header.Split(",");
        Console.WriteLine($"{headerParts[0]}\t\t{headerParts[2]}");
       
       List<Student> students =[];
       
        foreach (var dataline in lines.Skip(1))
        {
        //     var dataParts = dataline.Split(",");
        //     var rollNumber = int.Parse(dataParts[3]);
        //     var dob = DateTime.Parse(dataParts[]);
        //     var student = new Student(dataParts[0],rollNumber, dataParts[1])
        //   //  student.(student);
        //     Console.WriteLine($"{dataParts[0]}\t\t{dataParts[2]}");
        }
    }
}