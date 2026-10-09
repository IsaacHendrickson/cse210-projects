using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;
using System.Xml;

class Entry
{
    public string date;
    public string prompt;
    public string response;

    public void getEntry(string input, DateTime dateText)
    {
        Console.WriteLine(input);
        response = Console.ReadLine();
        prompt = input;
        date = dateText.ToString("yyyy-MM-dd HH:mm:ss");
    }

}