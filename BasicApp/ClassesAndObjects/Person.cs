namespace CollegeManagement;
public class Person(string n, DateTime d, char g)
{
    public string name = n;
    public DateTime dateOfBirth = d;
    public char gender = g;

    string resume = "";

    public string Resume{
        get{
            return resume;
        }
        set{
            if(value.Length >=5)
            resume = value;
        }
    }



    public virtual void PrintDetails()
    {
        // var output = name + ", " + rollNumber + ", " +  dateOfBirth.ToLongDateString(); 

        // string interpolation
        var message = $"{name}\t\t{dateOfBirth.ToLongDateString()}\t\t{gender}";
        Console.Write(message);
    }
}