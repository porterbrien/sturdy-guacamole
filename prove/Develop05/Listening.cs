class Listing : Activity 
{
    // This class need to have the start and ending message.
    // This class calls the RandomPrompt() 
    // calls the ani() function.

    public Listing() : base("Listing","This activity is 30 Seconds Long!\n\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.","Good Job!"){}

    private void Prompt(){
        Console.WriteLine("Describes the program to the user and starts the activity.");
    }
    
    public string[] list=
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public void randomPrompt(){
        string user = "";
        
        Random prompt = new Random();
        int number = prompt.Next(0,list.Length);
        string userPrompt = $"{list[number]}";
        Console.WriteLine("List as many answers as you can to the following prompt:");
        Console.WriteLine($"---{userPrompt}---");
        start();

        while (user != "quit" && startTime() == false)
        {
            user = Console.ReadLine();
        }
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