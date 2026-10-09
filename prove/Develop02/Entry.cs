using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;
using System.Xml;

class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void GetEntry(string input, DateTime dateText)
    {
        Console.WriteLine(input);
        _response = Console.ReadLine();
        _prompt = input;
        _date = dateText.ToString("yyyy-MM-dd HH:mm:ss");
    }

}