using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello FinalProject World!");
        Quest quest1 = new Quest();

        bool finished = false;

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
                quest1.assignLevel();
                // levelPets();
                // Console.WriteLine("\n\n");


                // quest1.levelPet() > activity menu (randomizer for leveling up) | Food Menu (randomizer for leveling up) | Tricks menu (randomizer for leveling up); 

                // I want to have an increasing chance of the pet to level up the more tries there are from the user.
                // To do this. If the user feeds a pet, the chance for leveling up is 10-100. if random does not get number "1-10", move slider to "1-20" so there will be 20-100 chance. so on. 


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
                finished = true;
            }
        }
    }
}