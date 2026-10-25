using System.Runtime.CompilerServices;

class Word
{

    private string _word;
    private bool _hidden = false;

    public Word(string word)
    {
        _word = word;
    }

    public void HideWord()
    {
        _hidden = true;
    }

    public string GetWord()
    {
        return _word;
    }

    public bool IsHidden()
    {
        return _hidden;
    }
    public void Display()
    {
        string newWord = "";

        if (!_hidden)
        {
            Console.Write(_word + ' ');
        }
        else
        {
            for(int i = 0; i < _word.Length; i++)
            {
                newWord += "_";
            }
            //Console.Write(_word.Length);
            Console.Write(newWord + ' ');
        }
    }
}