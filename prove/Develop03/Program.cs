using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference();
        Scripture scripture1 = new Scripture();
        Word word1 = new Word();

        Console.WriteLine("Hello Develop03 World!");
        
        // if user hits enter, then take a few words away from the program.
        // 
        // Else if 
        still = "";

        while (still != "quit")
        {
                // print out ("chapter": "verse: > "scripture text"
                book = "Luke";
                chapter = 10;
                verseText = "19) Behold, I give unto you power to tread on serpents and scorpions, and over all the power of the enemy: and nothing shall by any means hurt you";
                reference1.Reference(book, chapter, verse);
                console.WriteLine("");
                console.WriteLine("\n\nPress enter to practice");
                console.Readline();
                // print out ("press enter to keep practicing!")
                // if "enter" *remove three words and replace them with blanks lines ("___")
        }
    }
}