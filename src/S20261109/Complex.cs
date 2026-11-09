public class Complex {
    private readonly double re;   // Realteil
    private readonly double im;   // Imaginärteil

    public Complex(double real, double imag) {
        re = real;
        im = imag;
    }

    public override string ToString() 
    {
        if (im >= 0)
            return $"{re} + {im}i";
        else
            return $"{re} - {Math.Abs(im)}i";
    }
    public double Abs() {
        return Math.Sqrt(re * re + im * im);
    }

    public Complex Plus(Complex b) {
        return new Complex(re + b.re, im + b.im);
    }

    public Complex Times(Complex b)
    {
        double real = re * b.re - im * b.im;
        double imag = re * b.im + im * b.re;

        return new Complex(real, imag);
    }
}