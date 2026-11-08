using System.Diagnostics.Metrics;

class ListingActivity : BaseActivity
{
    private List<string> _promts = [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    ];
    public ListingActivity(string name, string description) : base(name, description)
    {
    }

    public void Run()
    {
        _seconds = StartActivity();
        List();
        EndActivity();
    }

    public void List()
    {
        Random random = new();
        int counter = 0;

        Console.WriteLine(_promts[random.Next() % _promts.Count]);
        CountDown(5);
        
        DateTime endTime = DateTime.Now.AddSeconds(_seconds); 
        Console.Write(" ");
        Console.CursorLeft--;
        while(endTime > DateTime.Now)
        {
            Console.CursorVisible = true;
            Console.ReadLine(); 
            Console.CursorVisible = false;
            counter++;
        }
        Console.WriteLine($"You listed {counter} things");
        
    }
}