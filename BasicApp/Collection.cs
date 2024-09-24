class Collections
{
    // Learn about arrays
    public void LearnArrays()
    {
        string[] names = new string[10];
        names[0] = "Bishnu";
        // ...

        int[] ages = [23, 45, 56, 67];        
    }

    public void LearnList()
    {
        // List<string> names = new();
        // names.Add("Rakesh");

        List<string> names = ["Bishnu"];
    }

    public void LearnDictionary()
    {
        // Key value pairs
        // Store coutry name and its population
        Dictionary<string, long> countryPopulation = new();
        countryPopulation.Add("Nepal", 23423442);
        countryPopulation.Add("India", 34323423442);
        countryPopulation.Add("China", 14323423442);
    }
}