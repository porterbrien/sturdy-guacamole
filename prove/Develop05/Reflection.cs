using System.ComponentModel.DataAnnotations;
using System.Dynamic;

class Reflection : Activity
{
    // This class need to have the start and ending message.
    // RandomMsg() this function needs to generate a random msg for the user to reflect on.
    // -Call the Clock() so the user has time to reflect
    // RandomQuestion() this function is the same as RandomMsg() but it calls questions instead
    // call the ani() function. for the animation
    public Reflection() : base("Reflection","This activity is 30 Seconds Long!\n\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. \n\nYou will be given a prompt. When You press enter, you will be given 2 questions relating to the prompt.","Good Job!"){}

    private string _userThought;

    public string[] prompts = 
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    // 
    // Pulls a random prompt from the library "RANDOM" 
    public void randomPrompt(){
        Random prompt = new Random();
        // Next is in the library for Random, The 0 is for between 0-prompts.Length (how ever long the list is)
        int number = prompt.Next(0, prompts.Length);
        // Looks like its selecting the index of the number from the list
        string userPrompt = $"{prompts[number]}";
        Thread.Sleep(150);
        Console.Clear();
        Console.WriteLine("Prompt:");
        Console.WriteLine($"\n---{userPrompt}---");
        Console.WriteLine("\n\nGive Yourself time to think about the prompt.\n\nPress Enter to start this activity...");
        Console.ReadLine();
    }

    public string[] thought = 
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    // 
    // Pulls a random prompt from the library "RANDOM" 
    public void randomThought(){
        Random prompts = new Random();
        int number1 = prompts.Next(0, thought.Length);
        string userThought = $"{thought[number1]}";
         _userThought = userThought;
    }
   
    public void ReflectionPrompts1(){
        Thread.Sleep(10);
        Console.Clear();
        Console.WriteLine($"{_userThought}");
        Ani2();
    }
    public void ReflectionPrompts2(){
        Thread.Sleep(10);
        Console.Clear();
        Console.WriteLine($"{_userThought}");
        Ani2();
    }
    private void Prompt(){
        Console.WriteLine("Describes the program to the user and starts the activity.");
    }

    public void Display(){
        // Starting animation
        Ani();
        Ready();
        Ani();
        Console.Clear();
        Set();
        Ani();
        Console.Clear();
        Go();
        Console.Clear();
        Prompt();
    }
}