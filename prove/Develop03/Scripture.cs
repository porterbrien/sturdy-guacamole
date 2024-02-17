using System.Globalization;
using System.Runtime.InteropServices.Marshalling;

public class Scripture
{
    //  Im going to have this one

    private List<Word> _list = new List<Word>();
    private List<int> index = new List<int>();

    string _scripture = "";

    // This function goes through the our "_list" and makes it into an array. It then says to split the scripture into seperate words using the built in .Split function. In the foreach loop, it makes the array we just made and turns it into another list.
    public Scripture(string Scripture)
    {
        _scripture = Scripture;
        string[] array = Scripture.Split(" ");

        foreach(string letters in array)
        {
            _list.Add(new Word(letters));
        }
    }
    // This function selects a random word three times.
    public void randomScripture()
    {
        Random random = new Random();
        int number = random.Next(0, _list.Count);
        _list[number].hidden();
        if (!index.Contains(number))
        {
            index.Add(number);
        }
    }
    public string checkIndex()
    {
        if (index.Count == _list.Count)
        {
            string quit = "quit";
            return quit;
        }
        else
        {
            string noQuit = "dont";
            return noQuit;
        }
        
    }

    public void printScripture()
    {
        for (int i = 0; i < _list.Count; i++)
        {
            Console.Write(_list[i].getWord());
            Console.Write(" ");
        }
    }
}