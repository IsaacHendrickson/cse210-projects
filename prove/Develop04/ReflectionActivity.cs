class ReflectionActivity : BaseActivity
{
    private List<string> _prompts = [
        "Think of a time when you stood up for someone else",
        "Think of a time when you did something really difficult",
        "Think of a time when you helped someone in need",
        "Think of a time when you did something truly selfless"
        ];


    private List<string> _questions = [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    ];
    public ReflectionActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }


    public void Run()
    {
        _seconds = StartActivity();
        Reflect();
        EndActivity();
    }
    public void Reflect()
    {
        Random random = new();
        //random.Next();
        DateTime endTime = DateTime.Now.AddSeconds(_seconds);
        bool prompt = true;
        int counter = 0;
        while(endTime > DateTime.Now)
        {
            if (counter == 0)
            {
                if(prompt)
                {
                    Console.WriteLine(_prompts[random.Next() % _prompts.Count]);
                }
                else
                {
                    Console.WriteLine(_questions[random.Next() % _questions.Count]);
                }
                //counter = secondsPerBreath;
                prompt = !prompt;
            }
                DisplaySpinnerMessage(10, "Think ");
        }
    }
}