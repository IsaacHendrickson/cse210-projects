class CountingActivity : BaseActivity
{
    public CountingActivity(string name, string description) : base(name, description)
    {
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