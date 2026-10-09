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

        Console.WriteLine("Welcome to the journaling program");
        while(!done)
        {
            input = menu.processMenu();
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            if (input == 1)
            {
                Entry entry = new();
                randNum = rand.Next(prompts.Count);
                entry.getEntry(prompts[randNum], theCurrentTime);
                journal.entries.Add(entry);
            }else if (input == 2)
            {
                Console.WriteLine("Save to what file");
                fileName = Console.ReadLine();
                journal.writeToFile(fileName);  
            }else if (input == 3)
            {
                Console.WriteLine("Load from what file");
                fileName = Console.ReadLine(); 
                journal.loadJournal(fileName);
            }else if (input == 4)
            {
                journal.readJournal();
            }else if (input == 5)
            {
                done = true;
            }
        }
    }
}