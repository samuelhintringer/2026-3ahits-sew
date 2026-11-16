Complex k = new Complex(-1.2, 0.1);
for (int i = 0; i < 100; i++)
{
    if (k.re < -2 && k.re < 1.1 & k.im > -1.1 && k.im < 1.1)
    {
        continue;
    }
    else
    {
        break;
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