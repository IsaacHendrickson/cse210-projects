using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{


    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome");
    }
    static string PromptUserName()
    {
        Console.Write("Name? ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Number? ");
        string num = Console.ReadLine();
        int numnum = Int32.Parse(num);
        return numnum;
    }
    
    static void PromtUserBirthYear(out int year)
    {
        string yearstr = "";
        Console.Write("birth year? ");
        yearstr = Console.ReadLine();
        year = Int32.Parse(yearstr);
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int num, int year)
    {
        Console.WriteLine("Num squared is " + num);
        Console.WriteLine(name + " you will turn " + (2026 - year) + " this year");
    }


    static void Main(string[] args)
    {
        string name;
        int num;
        int numsqu;
        int year;

        DisplayWelcome();
        name = PromptUserName();
        num = PromptUserNumber();
        PromtUserBirthYear(out year);
        numsqu = SquareNumber(num);
        DisplayResult(name, numsqu, year);
        
    }
}