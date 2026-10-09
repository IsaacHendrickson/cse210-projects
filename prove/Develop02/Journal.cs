class Journal
{
    public List<Entry> entries = [];

    public void writeToFile(string file)
    {
        foreach(Entry entry in entries)
        {
            //using StreamWriter outputFile = new StreamWriter(file);
            File.AppendAllText(file, $"{entry.date}|{entry.prompt}|{entry.response}\n");
        }
    }

    public void readJournal()
    {        
        int index = 1;
        foreach(Entry entry in entries)
        {
           Console.WriteLine($"{entry.date} - {entry.prompt}: {entry.response}"); 
            index++;
        }
    }
    public void loadJournal(string fileName)
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
    public void editEntry(int index)
    {
        Console.WriteLine("New entry");
        entries[index+1].response = Console.ReadLine();
    } 
}