namespace S20261116;

class Program
{
    static void Main(string[] args)
    {
        string lol = "Sike its the woong number";
        Console.WriteLine(lol.Length);
        Console.WriteLine(lol[21]);
        Console.WriteLine(lol.CompareTo(lol));
        Console.WriteLine(lol.Substring(21));
        Console.WriteLine(lol.Contains("u"));
        Console.WriteLine(lol.IndexOf("m"));
        Console.WriteLine(lol.LastIndexOf("m"));
        Console.WriteLine(lol.StartsWith("S"));
        Console.WriteLine(lol.EndsWith("s"));
    }
}

