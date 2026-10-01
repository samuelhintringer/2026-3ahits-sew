using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace OOP;

class Schule
{
    public string name;
    public int anzahlSchueler;
    public int anzahlLehrer;

    Schule(string name, int anzahlLehrer, int anzahlSchueler)
    {
        this.name = name;
        this.anzahlLehrer = anzahlLehrer;
        this.anzahlSchueler = anzahlSchueler;
    }
}

class Program
{
    private static void Main(string[] args)
    {
        Schule htl = new Schule("HTL Braunau", 67, 6767);
    }
}