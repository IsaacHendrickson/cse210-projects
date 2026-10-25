class ScriptureReferance
{
    private string _referance;

    public ScriptureReferance(string book, int chapter, int verse)
    {
        chapter.ToString();
        verse.ToString();
        _referance = $"{book} {chapter}: {verse}";
    }

    public ScriptureReferance(string book, int chapter, int verse, int endVerse)
    {
        chapter.ToString();
        verse.ToString();
        endVerse.ToString();
        _referance = $"{book} {chapter}: {verse}-{endVerse}";
    }

    public string GetReferance()
    {
        return _referance;
    }
    

}