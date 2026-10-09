using System.Diagnostics.Contracts;

class Journal
{
    public List<Entry> _entries = [];

    public void WriteToFile(string file)
    {
        File.WriteAllText(file, "");
        foreach(Entry entry in _entries)
        {
            bool _skipEntry = false;

            string[] lines = System.IO.File.ReadAllLines(file);
            foreach(string line in lines)
            {
                if(entry._date == line.Split("|")[0])
                {
                    _skipEntry = true;
                }
            }
            if (!_skipEntry)
            {
                File.AppendAllText(file, $"{entry._date}|{entry._prompt}|{entry._response}\n");
            }
        }
    }

    public void ReadJournal()
    {        
        int _index = 1;
        foreach(Entry entry in _entries)
        {
           Console.WriteLine($"{_index}:{entry._date} - {entry._prompt}: {entry._response}"); 
            _index++;
        }
    }
    public void LoadJournal(string fileName)
    {
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        string[] list = ["", "", ""];
        foreach (string _line in lines)
        {
            Entry entry = new();
            list = _line.Split("|");
            entry._date = list[0];
            entry._prompt = list[1];
            entry._response = list[2];
            _entries.Add(entry);
        }
    }
    public void EditEntry(int index)
    {
        Console.WriteLine("New entry");
        _entries[index+1]._response = Console.ReadLine();
    } 
    public void DeleteEntry()
    {
        Console.WriteLine("Which entry would you like to delete");
        string indexStr = Console.ReadLine();
        int index = Int32.Parse(indexStr);
        _entries.RemoveAt(index-1);
    }
}