using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

public class Resume
{

    public string name;
    public List<Job> jobs = new(); 
    public void Display()
    {

        Console.WriteLine(name);
        foreach(Job job in jobs)
        {
            job.Display();
        }
    }

}