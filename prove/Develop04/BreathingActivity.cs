class BreathingActivity : BaseActivity
{
    public BreathingActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Breathing()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_seconds);
        int counter = 0;
        int secondsPerBreath = 5;
        bool breatheIn = true;
        while(endTime > DateTime.Now || breatheIn)
        {

            if(breatheIn)
            {
                Console.WriteLine("Breath in");
            }
            else
            {
                Console.WriteLine("Breath out");
            }
            breatheIn = !breatheIn;
            
            CountDown(secondsPerBreath);
        }

    }
        public void Run()
    {
        _seconds = StartActivity();
        Breathing();
        EndActivity();
    }
}