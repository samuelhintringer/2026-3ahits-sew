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

class Rechteck
{
    double a = 0.0;
    double b = 0.0;

    public override string ToString()
    {
        return $"{a} {b}";
    }

    public void Resize()
    {
        if(a < b) b -= a;
        if(b < a) a -= b;
    }

    public void Inflate(double p)
    {
        if(p > 100.0 || p < 1.0)
        {
            return;
        }
        p/=100;
        a += a * p;
        b += b * p;
    }

    public double Area()
    {
        return a * b;
    }

    public int Tile(Rechteck r)
    {
        return Math.Floor(Area(100,64)/r.Area());
    }

    public Rechteck(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    public Rechteck() : this(10,20){}
}
