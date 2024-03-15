using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        goal goal1 = new goal();
        quest quest1 = new quest();

        bool loop = true;

        while (loop)
        {
            Console.Clear();
            activity1.StartMsg();
            activity1.Menu();

            Console.WrtieLine($"You have {points} points.");
            Console.WriteLine("Please Select an activity from the menu:");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                //Create new goal
                typesofGoals();

            }
            else if(userInput == "2")
            {
                //List Goals

            }
            else if(userInput == "3")
            {
                //Save Goals

            }
            else if(userInput == "4")
            {
                //Load Goals

            }
            else if(userInput == "5")
            {
                //Record Event

            }
            else if(userInput == "6")
            {
                // Quit
                loop = false;
            }
        }
    }
}