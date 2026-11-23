namespace S20261116;

class Program
{
    static void Main(string[] args)
    {
        string lol = "Sike its the woong number";

        //stringsOut(lol);
        Console.WriteLine(Rev(lol));
    }

    static public void stringsOut(string x)
    {
        Console.WriteLine(x.Length);
        Console.WriteLine(x[21]);
        Console.WriteLine(x.CompareTo(x + "34"));
        Console.WriteLine(x.Substring(21));
        Console.WriteLine(x.Contains("u"));
        Console.WriteLine(x.IndexOf("m"));
        Console.WriteLine(x.LastIndexOf("m"));
        Console.WriteLine(x.StartsWith("S"));
        Console.WriteLine(x.EndsWith("s"));
        Console.WriteLine(x.ToLower());
        Console.WriteLine(x.ToUpper());
        Console.WriteLine(x.Insert(2, "L"));
        Console.WriteLine(x.PadLeft(27));
        Console.WriteLine(x.PadRight(27));
        Console.WriteLine(x.Trim());
        Console.WriteLine(x.TrimStart());
        Console.WriteLine(x.TrimEnd());
        return;
    }

    static public string Rev(string x)
    {
        char[] temp = x.ToCharArray();
        for (int i = 0; i < x.Length; i++)
        {
            temp[i] = x[x.Length-i-1];
        }
        return temp.ToString();
    }
}
