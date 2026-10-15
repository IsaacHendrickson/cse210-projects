using System.Runtime.CompilerServices;

class Word
{
private
    string _word;

public

    void HideWord(string word)
    {
        string newWord = "";
        for(int i = 0; i > _word.Length; i++)
        {
            newWord += '_';
        }
        _word = newWord;
    }
}