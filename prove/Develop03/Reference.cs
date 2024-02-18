public class Reference
{
    string _book = "";
    int _chapter = 0 ;
    string _verse = "";

    public Reference(string book, int chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    private static string Book()
    {
        return "";
    }
    private static int Chapter()
    {
        return 0;
    }
    private static string Verse()
    {
        return "";
    }
    public void Display()
    {
        Console.WriteLine($"{_book} {_chapter}:{_verse}");
    }
}