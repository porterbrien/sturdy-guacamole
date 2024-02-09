using System.IO;
using System.Runtime.InteropServices;

public class Journal
{
    public void saveEntry(string sentenceWithoutSpaces, string entry)
    {
        using (StreamWriter outputFile = new StreamWriter(sentenceWithoutSpaces))
        {
            // Append the entry to the file
            outputFile.WriteLine(entry);
        }
    }
    public void LoadEntry(string file)
    {
        string filename = file;
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
            {
                string[] parts = line.Split(";");

                string firstName = parts[0];
                string lastName = parts[1];
            }
    }
    public void fileName(){
        Console.WriteLine("What is the name of the text file:");
    }
    public void formatFile(string File){
        Console.WriteLine($"../{File}.txt");
    }
    public void printStatement(string file){
        Console.WriteLine($"Your Journal has been saved to {file}");
    }
}


