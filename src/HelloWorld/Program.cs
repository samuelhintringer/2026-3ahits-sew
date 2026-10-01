using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace OOP;


class Schule
{
    public string name;
    public int anzahlSchueler;
    public int anzahlLehrer;

    public Schule(string name, int anzahlLehrer, int anzahlSchueler)
    {
        this.name = name;
        this.anzahlLehrer = anzahlLehrer;
        this.anzahlSchueler = anzahlSchueler;
    }
}

class Animal
{
    public string name;
    public string color;
    
    public virtual void sound()
    {
        Console.WriteLine("Moo");
    }
}

class Dog : Animal
{
    public override void sound()
    {
        Console.WriteLine("Woof");
    }
}

class Program
{
    private static void Main(string[] args)
    {
        Schule htl = new Schule("HTL Braunau", 67, 6767);
        Dog doggo = new Dog();
        doggo.sound();
    }
}