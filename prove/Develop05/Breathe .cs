using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.Marshalling;
using System.Reflection;
using System;

class Breathe : Activity
{
// This class need to have the start and ending message.
    // This class needs to Loop Timer()
    // -Loop Timer() needs to call ani()
    // Needs to call the clock() for the timer.

    public Breathe() : base("Breathe","This activity is 30 Seconds Long!\n\nThis activity will help you relax by walking you through a breathing exercise where we will breathe in and out slowly. Clear your mind and focus on your breathing.","Good Job!\n\nYou Completed another 30 seconds of the Breathing Activity!"){}

    public void BreatheIn(){
        Console.Write($"Breathe In...");
        // thread.timer(5000);
        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("0");
        
        // Console.
    }
    public void BreatheOut(){
        Console.Write($"\nBreathe Out...");
        // thread.timer(5000);
        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("0");
    }
}