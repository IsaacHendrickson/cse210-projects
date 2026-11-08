using System.Dynamic;

class BaseActivity
{
    protected string _name;
    protected string _description;
    protected int _seconds;

    // BaseActivity(string name, string description)
    // {
    //     _name = name;
    //     _description = description;
    // }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void DisplaySpinnerMessage(int seconds, string message)
    {
        List<char> spinner = ['-', '\\', '|', '/', '-', '\\', '|', '/'];
        int index = 0;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        Console.CursorVisible = false;
        Console.Write(message + " ");
        while(endTime > DateTime.Now)
        {
            if(index == spinner.Count)
            {
                index = 0;
            }
            Console.Write(spinner[index]);
            Console.CursorLeft--;
            Thread.Sleep(100);    
            index++;
        }
        Console.Clear();

        //Console.WriteLine();
    }

    public void CountDown(int seconds)
    {
        int counter = seconds;
        while (counter > 0)
        {
            Console.Write(counter);
            Console.CursorLeft--;
            Thread.Sleep(1000);
            counter--;
        }
    }

        public void CountUp(int seconds)
    {
        int counter = 1;
        while (counter < seconds + 1)
        {
            Console.Write(counter + " sheep");
            Console.CursorLeft-=7;
            Thread.Sleep(1000);
            counter++;
        }
    }

    public int StartActivity()
    {   
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine(_description);
        Console.CursorVisible = true;
        Console.Write("How many seconds would you like the activity to last ");
        int output = Int32.Parse(Console.ReadLine());
        Console.CursorVisible = false;
        DisplaySpinnerMessage(5, "Prepare ");
        return output;
    }
    public void EndActivity()
    {
        Console.WriteLine("Good job");
        Console.WriteLine($"You have completed the {_name}");
        Console.WriteLine($"You spent {_seconds} seconds on the activity");
        DisplaySpinnerMessage(5, "");
    }


}