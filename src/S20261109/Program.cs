namespace S20261109;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

class Schulklasse
{
    int anzahlSchueler = 0;
    string nameKV = "";

    public override string ToString()
    {
        return $"KV:{this.nameKV} Schueler:{this.anzahlSchueler}";
    }

    public int Dazu()
    {
        return ++anzahlSchueler;
    }

    public int Raus(int n)
    {
        return anzahlSchueler -= n;
    }

    public void KlassenWechselnNach(Schulklasse X)
    {
        this.anzahlSchueler--;
        X.anzahlSchueler++;
    }

    public Schulklasse()
    {
        anzahlSchueler = 22;
        nameKV = "Günther Strasser";
    }
}
