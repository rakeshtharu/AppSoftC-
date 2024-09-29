//Language Integrated Query
//used for querying collection
public class Linq
{
    int[] marks = [23, 25, 26, 21, 4483, 22, 11, 45, 232, 78];

    public void Test()
    {
        //get list of pass marks ofornly (40 or mmore)
        //Imperative Way
        // List<int> passMarks = [];
        // foreach(var mark in marks)
        // {
        //     if(mark >= 40){
        //         passMarks.Add(mark);
        //     }
        // }

        //Declarative way
        var pMarks = marks.Where(mark => mark >=40);
    }
}

