class Menu
{
    public int ProcessMenu()
    {
        bool _done = false;
        int _input = 5;

        Console.WriteLine("(1) New entry");
        Console.WriteLine("(2) Save Journal");
        Console.WriteLine("(3) Load Journal");
        Console.WriteLine("(4) Read Journal");
        Console.WriteLine("(5) Delete Entry");
        Console.WriteLine("(6) Exit");

        while (!_done)
        {
            _input = Int32.Parse(Console.ReadLine());
            if (_input < 1 || _input > 6)
            {
                Console.WriteLine("Sorry that it not a valid input, try again");
                continue;
            }
            _done = true;
        }
        return _input;
    }
}