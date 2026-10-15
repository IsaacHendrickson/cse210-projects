class Menu
{
public
    int PrintMenu()
    {
        Console.WriteLine("Welcome");
        Console.WriteLine("(1) Practice");
        Console.WriteLine("(2) Add Scripture");
        Console.WriteLine("(3) Exit");

        int result = 1;
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out result))
            {
                int inputNum = Int32.Parse(input);
                return inputNum;
            }
            Console.WriteLine("Sorry try again");
        }
    }
}