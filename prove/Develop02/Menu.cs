class Menu
{
    public int ProcessMenu()
    {
        bool done = false;
        int input = 5;

        Console.WriteLine("(1) New entry");
        Console.WriteLine("(2) Save Journal");
        Console.WriteLine("(3) Load Journal");
        Console.WriteLine("(4) Read Journal");
        Console.WriteLine("(5) Delete Entry");
        Console.WriteLine("(6) Exit");
        //input = Int32.Parse(Console.ReadLine());


        while (!done)
        {
            input = Int32.Parse(Console.ReadLine());
            if (input < 1 || input > 5)
            {
                Console.WriteLine("Sorry that it not a valid input, try again");
                continue;
            }
            done = true;
        }
        return input;
    }
}