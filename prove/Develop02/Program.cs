using System;
using System.IO;



//entry (date, prompt, responce, func writeToFile(fileName))
// 
class Program
{

    static void Main(string[] args)
    {
        //int input;

        

        Menu menu = new();
        int input;


        Random rand = new();
        int randNum;

        Journal journal = new();

        string fileName = "";

        List<string> prompts = [
        "What was your favorite thing about today",
        "How was your day",
        "Why are you a good person",
        "What made you happy today",
        "What made you upset to day"
        ];

        bool done = false;
        int index;

        Console.WriteLine("Welcome to the journaling program");
        while(!done)
        {
            input = menu.ProcessMenu();
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            if (input == 1)
            {
                Entry entry = new();
                randNum = rand.Next(prompts.Count);
                entry.GetEntry(prompts[randNum], theCurrentTime);
                journal.entries.Add(entry);
            }else if (input == 2)
            {
                Console.WriteLine("Save to what file");
                fileName = Console.ReadLine();
                journal.WriteToFile(fileName);  
            }else if (input == 3)
            {
                Console.WriteLine("Load from what file");
                fileName = Console.ReadLine(); 
                journal.LoadJournal(fileName);
            }else if (input == 4)
            {
                journal.ReadJournal();
            }else if (input == 5)
            {
                journal.DeleteEntry();
            }else if (input == 6)
            {
                done = true;
            }
        }
    }
}