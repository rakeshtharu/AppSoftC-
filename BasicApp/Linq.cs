// LINQ - Language Integrated Query
// Used for querying collections

using CollegeManagement;

public class LINQ
{
    int[] marks = [23, 45, 67, 12, 90, 24, 46, 58, 89, 24, 88, 55];
    List<Student> students = [
        new Student("Ramesh", 12, new DateTime(2000, 12, 12), 'M'),
        new Student("Ram", 22, new DateTime(1990, 7, 10), 'F'),
        new Student("Krishna", 32, new DateTime(2010, 1, 12), 'M'),
        new Student("Bishnu", 52, new DateTime(2008, 2, 12), 'F'),
        new Student("Shiba", 66, new DateTime(2001, 11, 5), 'M')
    ];

    public void Test()
    {
        // Get list of pass marks only (40 or more)

        // Imperative way
        List<int> passMarks = [];
        foreach (var mark in marks)
        {
            if (mark >= 40)
            {
                passMarks.Add(mark);
            }
        }

        // Declarative way
        var pMarks = marks.Where(mark => mark >= 40);

        // Get sum of passmarks
        var totalMarks = marks.Where(mark => mark >= 40).Sum();

        // Get all marks out of 10
        var marks10 = marks.Select(mark => (double)mark / 10);

        // Get all passmarks out of 10
        // Method syntax
        var pMarks10 = marks.Where(mark => mark >= 40).Select(mark => (double)mark / 10);
        
        // Expression syntax
        pMarks10 = from mark in marks
                   where mark >= 40
                   select (double)mark / 10;

        // Get all male students
        var maleStudents = students.Where(student => student.gender == 'M');

        // Get student names who are adults now
        var sNames = students.Where(s => (DateTime.Now - s.dateOfBirth).TotalDays / 365 >= 18).Select(s => s.name);
    }
}

