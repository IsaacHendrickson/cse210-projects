class Scripture
{
private
    List<string> _scripture;
    ScriptureReferance _referance;
    
public

    Scripture(string scripture)
    {
        _scripture = scripture.Split(" ").ToList();
    }
    void PrintScripture()
    {
        
    }

}