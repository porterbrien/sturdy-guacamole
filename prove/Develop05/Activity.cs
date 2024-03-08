using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.InteropServices.Marshalling;

class Activity
{
    // Need to make a StartMsg() that displays the intro to the program
    // Need to make an Endmsg() that displays the end of the program
    // ani() makes the animation function
    // clock() makes the timer
    private string _title;
    private string _description;
    private string _end;
    protected DateTime _timerEnd;

    public Activity(){}

    public Activity(string title, string Description, string end){
        _title = title;
        _description = Description;
        _end = end;
    }
    public void DisplayIntro(){
        Console.WriteLine($"Welcome to the {_title} Activity!\n\n{_description}\n");
    }
    public void DisplayEnd(){
        Console.WriteLine($"{_end}");
    }
    public void Display1(){
        Console.Clear();
        Ani();
        Ready();
        Console.Clear();
        Ani();
        Set();
        Console.Clear();
        Ani();
        Go();
        Console.Clear();
    }
    public void StartMsg(){
        Console.WriteLine($"Welcome to the mindfulness program!");
    }
    public void Menu(){
        Console.WriteLine($"\n   1. Start Breathing Activity\n   2. Start Reflecting Activity\n   3. Start Listening Activity\n   4. Quit The Program\n");
    }
    protected void Ready(){
        Console.WriteLine("Ready?");
        Thread.Sleep(2000);
    }
    protected void Set(){
        Console.WriteLine("Set...");
        Thread.Sleep(1000);
    }
    protected void Go(){
        Console.WriteLine("Go!");
        Thread.Sleep(1000);
    }
    public void Ani(){
        for (int i = 0; i < 3; i++ )
        {
            Console.Write("-");

            Thread.Sleep(150);

            Console.Write("\b \b"); // Erase the + character
            Console.Write("\\"); // Replace it with the - character
            Thread.Sleep(150);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(150);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(150);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(150);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(150);
            Console.Write("\b \b");
        }
    }
    public void Ani2(){
        for (int i = 0; i < 8; i++ )
        {
            Console.Write("-");

            Thread.Sleep(300);

            Console.Write("\b \b"); // Erase the + character
            Console.Write("\\"); // Replace it with the - character
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(300);
            Console.Write("\b \b");
        }
    }
    public void Continue(){
        Console.WriteLine("\nPress Enter To Start...");
        Console.ReadLine();
    }
    public void Clear(){
        Console.Clear();
        Thread.Sleep(500);
        Ani();
    }
    public void Clock(){
        Thread.Sleep(30000);
    }
    public bool startTime(){
        return DateTime.Now >= _timerEnd;
    }
    public void start(){
        _timerEnd = DateTime.Now.AddSeconds(30);
    }
    public void EndTimer(){
        Thread.Sleep(3500);
    }
}