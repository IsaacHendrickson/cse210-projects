using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new();
        Resume myResume = new();
        myResume.name = "Joghn";
        job1.jobName = "Life";
        job1.company = "Yo mama.inc";
        job1.started = 2024;
        job1.ended = 2026;

        Job job2 = new();
        job2.jobName = "Death";
        job2.company = "Yo mama.llm";
        job2.started = 132;
        job2.ended = 1044;
        //job1.Display();

        myResume.jobs.Add(job1);
        myResume.jobs.Add(job2);

        myResume.Display();



    }
}