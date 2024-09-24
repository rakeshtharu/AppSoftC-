class Methods
{
    //print hello message
    // public void SayHello(){
    //     Console.Write("Hey There !!!");
    // }

    // Print hello message
    public void SayHello() => Console.Write("Hey There!!!");
    //Pass hello greetings as argument
    public void SayHello(String greeting)
    {
        Console.Write(greeting);
    }
    //capitalize greeting message nad return to caller
    public string SayHello(String greeting, string details)
    {
        var x = greeting.ToUpper();
        return $"{x} \n {details}";
    }

    //public void SayHello() => Console.Write("hey There !!");

    

    public float GetAverage(params int[] numbers)
    {
        int sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }
        var a = (float)sum / numbers.Length;
        return a;
    }
    //Modify above method to return sum and average(Using tuples)
    public (int, float) GetResult(params int[] numbers)
    {
        int sum = 0;
        foreach(var num in numbers)
        {
            sum += num;
        }
        var a = (float)sum / numbers.Length;

        return(sum, a);
    }
}