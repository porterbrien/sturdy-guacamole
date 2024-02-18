using System;
using System.ComponentModel;
using System.Net.Quic;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Luke", 10, "19)");
        Scripture scripture1 = new Scripture("Behold, I give unto you power to tread on serpents and scorpions, and over all the power of the enemy: and nothing shall by any means hurt you");
        // Word word1 = new Word();


        Console.WriteLine("Hello Develop03 World!");
        
        // if user hits enter, then take a few words away from the program.
        // 
        // Else if 
        string still = "";

        while (still != "quit" && scripture1.checkIndex() != "quit")
        {
            Console.Clear();
            // print out ("chapter": "verse: > "scripture text"
            Console.WriteLine("\n");
            reference1.Display();
            scripture1.printScripture();
            Console.WriteLine("\n\nPress \"Enter\" to practice\n\nType \"quit\" to quit the program.");
            string userInput = Console.ReadLine();
            // print out ("press enter to keep practicing!")
            for (int i = 0; i < 3; i++)
            {
                scripture1.randomScripture();
            }
            if (userInput == "quit")
            {
                still = "quit";
            }
            Console.WriteLine(scripture1.checkIndex());
            Console.WriteLine(still != "quit" || scripture1.checkIndex() != "quit");
        }
    }
}