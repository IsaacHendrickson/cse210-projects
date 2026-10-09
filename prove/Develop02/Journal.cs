using System.Diagnostics.Contracts;

class Journal
{
    public List<Entry> entries = [];

    public void WriteToFile(string file)
    {
        File.WriteAllText(file, "");
        foreach(Entry entry in entries)
        {
            bool skipEntry = false;

            string[] lines = System.IO.File.ReadAllLines(file);
            foreach(string line in lines)
            {
                if(entry.date == line.Split("|")[0])
                {
                    skipEntry = true;
                }
            }
            if (!skipEntry)
            {
                File.AppendAllText(file, $"{entry.date}|{entry.prompt}|{entry.response}\n");
            }
        }
    }

    public void ReadJournal()
    {        
        int index = 1;
        foreach(Entry entry in entries)
        {
           Console.WriteLine($"{index}:{entry.date} - {entry.prompt}: {entry.response}"); 
            index++;
        }
    }
    public void LoadJournal(string fileName)
    {
        entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        string[] list = ["", "", ""];
        foreach (string line in lines)
        {
            Entry entry = new();
            list = line.Split("|");
            entry.date = list[0];
            entry.prompt = list[1];
            entry.response = list[2];
            entries.Add(entry);
        }
    }
    public void EditEntry(int index)
    {
        Console.WriteLine("New entry");
        entries[index+1].response = Console.ReadLine();
    } 
    public void DeleteEntry()
    {
        Console.WriteLine("Which entry would you like to delete");
        string indexStr = Console.ReadLine();
        int index = Int32.Parse(indexStr);
        entries.RemoveAt(index-1);
    }
}