using System;

class Program
{
    static void Main(string[] args)
    {
        string name;
        Console.WriteLine("What's your name");
        name = Console.ReadLine();
        Console.WriteLine($"Nice to meet you {name}!");
    }
}