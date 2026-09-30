using System;
using System.ComponentModel.DataAnnotations;

public class Job
{
    public string jobName;
    public string company = "";
    public int started;
    public int ended;

    public void Display()
    {
        Console.WriteLine($"{jobName} ({company}) {started}-{ended}");
    }

}