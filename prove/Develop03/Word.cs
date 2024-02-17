using System.Reflection.Metadata.Ecma335;

public class Word
// Stores the letters of that word when told to display it will display or underscore
{
    string _word = "";

    public Word(string word)
    {
        _word = word;
    }

    public void hidden()
    {
        _word = "____";
    }
    
    public string getWord()
    {
       return _word;
    }
}