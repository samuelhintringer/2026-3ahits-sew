using System.Linq.Expressions;
using System.Net.Http.Headers;

namespace OOP;

class Bankaccount
{
    double balance;
    double interestRate;
    string owner;
    int transCount;

    public string ToString()
    {
        return $"Balance: {balance}\nInterest Rate: {interestRate}\nOwner: {owner}";
    }

    public void In(double amount)
    {
        balance += amount;
    }

    public void Out(double amount)
    {
        balance -= amount;
    }

    public double Jahresabschluss()
    {
        if(transCount > 5)
        {
            if(transCount > 10)
            {
                balance -= (double)(transCount - 10) * 0.05 + 5;
            }
            else
            {
                balance -= (double)(transCount - 5) * 5;
            }
        }
        transCount = 0;
        balance += balance * interestRate / 100;
        return balance * interestRate / 100;
    }

    public void InterestUp(int num)
    {
        interestRate += (double)num / 10;
    }

    public void InterestDown(int num)
    {
        interestRate -= (double)num / 10;
    }

    public void Transfer(Bankaccount Maxi, double amount)
    {
        balance -= amount;
        Maxi.balance += amount;
        transCount++;
    }

    public Bankaccount() : this(500, 0.5, "")
    {
        
    }

    public Bankaccount(double balance, double interestRate, string owner)
    {
        this.balance = balance;
        this.interestRate = interestRate;
        this.owner = owner;
    }
}

class Program
{
    private static void Main(string[] args)
    {
        
    }
}

