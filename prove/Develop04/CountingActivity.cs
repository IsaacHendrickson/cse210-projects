class CountingActivity : BaseActivity
{
    public CountingActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Counting()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_seconds);

        while(endTime > DateTime.Now)
        {            
            CountUp(5);
        }

    }
        public void Run()
    {
        _seconds = StartActivity();
        Counting();
        EndActivity();
    }
}