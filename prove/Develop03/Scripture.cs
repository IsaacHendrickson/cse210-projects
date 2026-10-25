using System.Runtime.CompilerServices;

class Scripture
{

    private List<Word> _words;
    private ScriptureReferance _referance;
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse = -1;
    private bool end = false;



    // public Scripture(string scripture)
    // {
    //     List<string> words = scripture.Split(' ').ToList();
    //     foreach (string word in words)
    //     {
            
    //         Word word1 = new(word);
    //         //Console.WriteLine(word1.GetWord());
    //         _scripture.Add(word1);
    //         //Console.WriteLine(word1.GetWord());
    //     }
    // }

    public Scripture(string bookName, int chapter, int verse, string text)
    {
        _referance = new(bookName, chapter, verse);
        _words = ConvertToWords(text);
        //Console.WriteLine(_words[0]);

    }
    public Scripture(string bookName, int chapter, int startVerse, int endVerse,  string text)
    {
        _referance = new(bookName, chapter, startVerse, endVerse);
        _words = ConvertToWords(text);
    }

    private List<Word> ConvertToWords(string text)
    {
        List<Word> tempWords = new List<Word>();

        string[] words = text.Split(' ');
        foreach(string word in words)
        {
            Word tempWord = new(word);
            tempWords.Add(tempWord);
            Console.WriteLine(word);
        }
        return tempWords;
    }
    private void HideWords()
    {
        Random random = new();
        int index = random.Next() % _words.Count;
        for (int i = 0; i < 3; i++)
        {
            foreach(Word word in _words)
            {
                end = true;
                if (!word.IsHidden())
                {
                    end = false;
                    break;
                }
            }
            if (end)
            {
                break;
            }
            while(_words[index].IsHidden())
            {
                index = random.Next() % _words.Count;
            }
            _words[index].HideWord();
        }        

        PrintScripture();

        
    }
    public void PrintScripture()
    {        
        string input;
        Console.Clear();
        Console.WriteLine(_referance.GetReferance());

        foreach(Word word in _words)
        {
            word.Display();
        }
        Console.WriteLine();

        //Console.WriteLine("(1): Hide words");
        //Console.WriteLine("(2): Exit");
        input = Console.ReadLine();
        if (input == "" && !end)
        {
            HideWords();
        }
    }



}