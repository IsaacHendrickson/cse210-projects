class Menu
{
    public int DisplayMenu()
    {
        Console.CursorVisible = true;
        Console.WriteLine("Welcome to Activity Hub");
        Console.WriteLine("(1) Breathing Activity");
        Console.WriteLine("(2) Reflection Activity");
        Console.WriteLine("(3) Listing Activity");
        Console.WriteLine("(4) Exit");


        int input = Int32.Parse(Console.ReadLine());
        Console.CursorVisible = false;

        return input;
    }
}