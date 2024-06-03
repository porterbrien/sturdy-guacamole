using System;
using System.ComponentModel.DataAnnotations;
using System.Net.WebSockets;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        Activity activity1 = new Activity();
        Breathe breathe1 = new Breathe();
        Reflection reflecting1 = new Reflection();
        Listing listening1 = new Listing();
        // Needs a menu

        // 1 Breathe Activity
        // 2 Reflection Activity
        // 3 Listening Activity

        bool loop = true;

        while (loop)
        {
            Console.Clear();
            activity1.StartMsg();
            activity1.Menu();
            
            Console.WriteLine("Please Select an activity from the menu:");
            string userInput = Console.ReadLine();

            if (userInput == "1"){
                activity1.Clear();
                breathe1.DisplayIntro();
                activity1.Continue();
                activity1.Display1();
                // Put the Activity in here!
                breathe1.BreatheIn();
                breathe1.BreatheOut();

                Console.WriteLine("\n");
                breathe1.BreatheIn();
                breathe1.BreatheOut();

                Console.WriteLine("\n");
                breathe1.BreatheIn();
                breathe1.BreatheOut();

                // This is the 15 Sec timer for the activity.
                activity1.Clock();
                Console.WriteLine("\n");


                breathe1.DisplayEnd();
                activity1.EndTimer();
                Console.Clear();
            }
            else if(userInput == "2"){
                activity1.Clear();
                reflecting1.DisplayIntro();
                activity1.Continue();
                reflecting1.randomPrompt();
                reflecting1.randomThought();
                reflecting1.ReflectionPrompts1();
                // activity1.Ani();
                reflecting1.randomThought();
                reflecting1.ReflectionPrompts2();
                // activity1.Ani();

                // Put the activity here

                reflecting1.DisplayEnd();
                activity1.EndTimer();
                Console.Clear();
            }
            else if(userInput == "3"){
                activity1.Clear();
                listening1.DisplayIntro();
                activity1.Continue();
                activity1.Display1();

                // Put the activity here

                // 15 sec timer
                listening1.randomPrompt();

                listening1.DisplayEnd();
                activity1.EndTimer();
                Console.Clear();
            }
            else if(userInput == "4"){
                loop = false;
            }
        }
    }
}