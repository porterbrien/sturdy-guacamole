using System.Net;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public string _date = "";
    public string _prompt = "";
    public string _response = "";
    // 
    // This is part of the constructor if I understand that correctly, its a choose "this" or "that situation.
    public Entry() {}
    // 
    // This is the Constructor That i built. I got help from the LAB and I need to research more about constructors to understand them better.
    public Entry(string date, string prompt, string response) {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public List<Entry> entries = new List<Entry>();
    // 
    // I created an array of prompts because I dont plan on adding or removing any prompts anytime soon.
    public string[] prompts = 
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    // 
    // Pulls a random prompt from the library "RANDOM" 
    public string randomPrompt(){
        Random prompt = new Random();
        int number = prompt.Next(0, prompts.Length);
        return prompts[number];
    }
    // 
    // Method for the Constructor. Puts it all into one variable per line. Needs three parameters. Go to Program and pass the parameters into it.
    public void createEntry(string date, string prompt, string response)
    {
        Entry _entry = new Entry(date, prompt, response);
        entries.Add(_entry);
    }
    // 
    // This is my formatted print string, it does not return a variable.

//playing around
//
    public string GetFormattedEntries()
    {
        List<string> formattedEntries = new List<string>();

        foreach (Entry entry in entries)
        {
            formattedEntries.Add($"Date: {entry._date};\nPrompt: {entry._prompt};\n\n>{entry._response};\n\n");
        }

        return string.Join(Environment.NewLine, formattedEntries);
    }

    public string saveFormatEntries()
    {
        List<string> stringforfile = new List<string>();

        foreach (Entry entry in entries)
        {
            stringforfile.Add($"Date: {entry._date};Prompt: {entry._prompt};>{entry._response};\"");
        }
        return string.Join(Environment.NewLine, stringforfile);
    }

    public void print()
    {
        Console.WriteLine($"Date:{_date}\nPrompt:{_prompt}\n\n>{_response}\n\n");
    }
    // 
    // Prints the correct entry.
    public void displayEntry()
    {
        foreach (Entry entry in entries)
        {
            entry.print();
        }
    }
    // public string response() {
    //     Console.
    // }
}


