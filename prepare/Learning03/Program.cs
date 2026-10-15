using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new(2,3);

        Console.WriteLine(fraction.GetTop());
        Console.WriteLine(fraction.GetBottom());

        fraction.SetTop(2);
        fraction.SetBottom(5);
        Console.WriteLine($"Fraction 1: String {fraction.GetFractionString()}, Number {fraction.GetDecimalValue()}");

        Random random = new();

        for (int i = 0; i < 20; i++)
        {
            fraction.SetTop(random.Next(1,20));
            fraction.SetBottom(random.Next(1,20));

            Console.Write(i+1 + ": Fraction " + fraction.GetFractionString()
             + ", Value " + fraction.GetDecimalValue() + "\n");
        }

    }
}