namespace S20261109;

class Program
{
    static void Main(string[] args)
    {
        Complex c = new Complex(-1.2,0.1);
        double z = 0;
        for(int i = 0; i < 100; i++)
        {
            z = z * z + (c.re + c.im);
            if(c.re < -2 && c.re < 1.1 & c.im > -1.1 && c.im < 1.1)
            {
	            continue;
            }
            else
            {
	            break;
            }
        }
    }
}

/*class Schulklasse
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
*/