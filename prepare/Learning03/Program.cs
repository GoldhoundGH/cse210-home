using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction ();
        Console.WriteLine(f1.GetFractionString());
        
        Fraction f2 = new Fraction (6);
        Console.WriteLine(f2.GetFractionString());
        
        Fraction f3 = new Fraction (6,7);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue().ToString());

        f3.SetNumer(2);
        f3.SetDenom(4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());


        Random randNum = new Random();

        int count = 0;
        string fractStr = "";
        double fractDouble = 0.0;
        Fraction randomF = new Fraction ();
        while (count < 20)
        {
            count += 1;
            randomF.SetNumer(randNum.Next(1,10));
            randomF.SetDenom(randNum.Next(1,10));
            fractStr = randomF.GetFractionString();
            fractDouble = randomF.GetDecimalValue();

            Console.WriteLine($"Fraction {count}: string: {fractStr} Number: {fractDouble}");
        }
    }
}