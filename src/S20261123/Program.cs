// ------------------------------
// S20261123
// ------------------------------

namespace S20261123;

class Program
{
    static void Main(string[] args)
    {
        Dauer a = new Dauer(1, 50);
        Dauer b = new Dauer(25);
        Dauer c = a.Plus(b);
        Console.WriteLine(c);
    }
}
class Dauer
{
    public int stunden;
    public int minuten;
    // a) volle Stunden aus den Minuten zu den Stunden dazuzaehlen
    public Dauer (int stunden, int minuten)
    {
        this.stunden = stunden + minuten / 60;
        this.minuten = minuten % 60;
    }
    // b) Konstruktorverkettung, Stunden = 0
    public Dauer (int minuten) : this (0, minuten)
    {
        Console.WriteLine("Standard");        
    }
    // c)
    public override string ToString()
    {
        return $"{stunden}h {minuten} min";
    }
    // d)
    public int GesamtMinuten ()
    {
        return stunden * 60 + minuten;
    }
    // e)
    public bool IstLaengerAls (Dauer t)
    {
        return ( GesamtMinuten() > t.GesamtMinuten() );
    }
    // f) neues Objekt, this und d bleiben unveraendert
    public Dauer Plus (Dauer t)
    {
        return new Dauer (stunden + t.stunden, minuten + t.minuten);
    }
}