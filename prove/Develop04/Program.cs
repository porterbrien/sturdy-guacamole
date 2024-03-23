using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop04 World!");
        Console.Clear();
        Quest quest1 = new Quest(0);
        bool loop = true;

        while (loop)
        {

            quest1.pointsTotal();

            Console.WriteLine("Please Select an activity from the menu:");
            Console.WriteLine("    1) Create a new goal\n    2) List Goals\n    3) Save Goals\n    4) Load Goals\n    5) Record an Event\n    6) Quit");
            Console.WriteLine("What would you like to do? ");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                //Create new goal
                Console.Clear();
                quest1.typesOfGoals();
            }
            else if(userInput == "2")
            {
                //List Goals
                Console.Clear();
                quest1.displayList();
                Console.WriteLine("\n\n");
                
            }
            else if(userInput == "3")
            {
                //Save Goals
                Console.Clear();
                quest1.saveGoal();

                Console.Clear();
            }
            else if(userInput == "4")
            {
                //Load Goals
                Console.Clear();
                quest1.LoadEntry();

                Console.Clear();
            }
            else if(userInput == "5")
            {
                //Record Event ask user if the goal is completed. which goal? 
                Console.Clear();
                quest1.markQuest();

                Console.Clear();
            }
            else if(userInput == "6")
            {
                // Quit
                loop = false;
            }
        }
    }
}