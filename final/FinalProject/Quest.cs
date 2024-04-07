using System.Diagnostics;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

public class Quest
{
    private List<int> numberList = new List<int>();
    
    public int[] LevelsList = 
        {
            1, 2, 3
        };

    public int assignedLevel;

    public int assignLevel()
    {
        Random random = new Random();
        int randomLevelIndex = random.Next(0, LevelsList.Length);
        assignedLevel = LevelsList[randomLevelIndex];
        return assignedLevel;
    }
    
// When the user hits the feed/ trick/ or play button, this should run and give it a number if the
    public void PerformAction()
    {
        // Define the ranges
        List<int[]> ranges = new List<int[]>
        {
            new int[] {1, 2, 3},
            new int[] {4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20}, 

        };

        Random random = new Random();

        int randomIndex = random.Next(0, ranges.Count);
        int[] selectedRange = ranges[randomIndex];

        if (selectedRange == ranges[0])
        {
            // We want action one to be preformed here.
            // It will have something to do with petLevel++ 
            levelUp();
        }
        else 
        {
            noLevelUp();
        }
    }

    public void levelUp()
    {
        // For this one, we want to change the hardcoded level of the pet into the level that the just acquired and we want to save it to the file that we are having the user save the information on.

    }

    public void noLevelUp()
    {
        // For no levelUp, if we can have it say words of encouragement or give some narration on to the progress of the pet, that would be beneficial for the already slow gameplay. Could I do a random word generator for this? how do I 
    }
    // This is going to be the list of animals which is the list of the type of animals, the name, and the level they are.
    private List<Pets> animals = new List<Pets>();

    // This formats #2 in the list where the user wants to view the pets. it calles the function from pets and uses that information.
    public void viewPets()
    {
        int number = 1;

        foreach(Pets name in animals)
        {   
            // 
            Console.WriteLine($"{number}) {name.displayInfo()}");
            number++;
        }
        Console.ReadKey();
    }

    public void createPet()
    {
        bool loop = true;
        while(loop)
        {
            Console.WriteLine("---Welome to the Pet Shop!---");
            Console.WriteLine("\nWhat pet are you looking for? ");
            Console.WriteLine("    1) Tree Species\n    2) Frog Species\n    3) Bird Species\n    4) Rock Species\n");
            Console.WriteLine("Which pet would you like? ");

            string Species = Console.ReadLine();

            if(Species == "1")
            {
                Console.WriteLine("Whats the name for your new Tree Species pet? ");
                string petName = Console.ReadLine();
                string petType = "Tree";
                int petLevel = assignLevel();


                Tree tree1 = new Tree(petName, petType, petLevel);
                animals.Add(tree1);

                // Input randomizer what level they start off as

                loop = false;
            }
            else if (Species == "2")
            {
                Console.WriteLine("Whats the name for your new Frog Species pet? ");
                string petName = Console.ReadLine();
                string petType = "Frog";
                int petLevel = assignLevel();

                Frog frog1 = new Frog(petName, petType, petLevel);
                animals.Add(frog1);

                // Input randomizer what level they start off as

                loop = false;
            }
            else if (Species == "3")
            {
                Console.WriteLine("Whats the name for your new Bird Species pet? ");
                string petName = Console.ReadLine();
                string petType = "Bird";
                int petLevel = assignLevel();

                Bird bird1 = new Bird(petName, petType, petLevel);
                animals.Add(bird1);

                // Input randomizer what level they start off as

                loop = false;
            }
            else if (Species == "4")
            {
                Console.WriteLine("Whats the name for your new Rock Species pet? ");
                string petName = Console.ReadLine();
                string petType = "Rock";
                int petLevel = assignLevel();

                Rock rock1 = new Rock(petName, petType, petLevel);
                animals.Add(rock1);

                // Input randomizer what level they start off as

                loop = false;
            }
            else
            {
                Console.WriteLine("Invalid input, please try again!");
            }
        }
    }




    // Need to edit save Goal and Load goals to match the project. delete this when done or mark as completed.

    // Uncomment here for other stuff.

//     public void saveGoal()
//     {
//         Console.WriteLine("What do you want the file name to be? ");
//         var txtName = Console.ReadLine();

//         using (StreamWriter outputFile = new StreamWriter(txtName))
//         {
//             // Append the entry to the file
//             outputFile.WriteLine(_pointsTotal);

//             foreach(Goal goal in listOfGoals)
//             {   

//             outputFile.WriteLine(goal.formatGoals());

//             }
//         }
//     }

//     public void LoadEntry()
//     {
//         Console.WriteLine("What file would you like to open? ");
//         var fileName = Console.ReadLine();
//         string[] lines = System.IO.File.ReadAllLines(fileName);

//         foreach (string line in lines)
//         {
//             string[] Parts = line.Split("~");

//             if (Parts[0] == "SimpleGoal")
//             {
//                 Goal simple2 = new Simple(Parts[1], Parts[2], int.Parse(Parts[3]), bool.Parse(Parts[4].ToLower()));
//                 listOfGoals.Add(simple2);
//             }
//             else if (Parts[0] == "ChecklistGoal")
//             {
//                 Goal checklist2 = new Checklist(Parts[1], Parts[2], int.Parse(Parts[3]), int.Parse(Parts[4].ToLower()), int.Parse(Parts[5]), int.Parse(Parts[6]));
//                 listOfGoals.Add(checklist2);
//             }
//             else if (Parts[0] == "EternalGoal")
//             {
//                 Goal eternalGoal2 = new Eternal(Parts[1], Parts[2], int.Parse(Parts[3]));
//                 listOfGoals.Add(eternalGoal2);
//             }
//             else
//             {
//                 _pointsTotal = int.Parse(Parts[0]);
//             }
//         }
//         Console.Clear();
//     }
}