using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello FinalProject World!");
        Quest quest1 = new Quest();

        bool finished = true;

        while (finished)
        {

            // print the menu first
            Console.Clear();
            Console.WriteLine("Welcome to the studio!\n---This is your home page!---");
            Console.WriteLine("    1) Create a pet\n    2) View my pets\n    3) Level a Pet\n    4) Save Progress\n    5) Load progress\n    6) Quit Program");
            Console.WriteLine("Select an item from the menu: ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                quest1.createPet();
            }

            if (userInput == 2)
            {
                quest1.viewPets();
            }

            if (userInput == 3)
            {
                // viewPets();
                // Console.WriteLine("\n\n");


                // quest1.levelPet() > activity menu (randomizer for leveling up) | Food Menu (randomizer for leveling up) | Tricks menu (randomizer for leveling up);

                // I want to have an increasing chance of the pet to level up the more tries there are from the user.
            }
            
            if (userInput == 4)
            {
                // quest1.saveFile();
            }

            if (userInput ==5)
            {
                // quest1.loadFile();
            }

            if (userInput == 6)
            {
                finished = false;
            }
        }
    }
}