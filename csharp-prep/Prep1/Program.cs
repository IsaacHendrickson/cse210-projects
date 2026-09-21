using System;

class Program
{
    static void Main(string[] args)
    {
        string name;
        string lastName;
        Console.WriteLine("What's your name");
        name = Console.ReadLine();
        Console.WriteLine("What's your last name");
        lastName = Console.ReadLine();

        Console.WriteLine($"Welcome {lastName}, {name} {lastName}");
    }
}   