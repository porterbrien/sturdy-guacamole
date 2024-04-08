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
    public int assignedPoints;
    public string assignedFood;

    public int assignLevel()
    {
        Random random = new Random();
        int randomLevelIndex = random.Next(0, LevelsList.Length);
        assignedLevel = LevelsList[randomLevelIndex];
        return assignedLevel;
    }

    // This is going to be the list of animals which is the list of the type of animals, the name, and the level they are.
    private List<Pets> animals = new List<Pets>();

    // This formats #2 in the list where the user wants to view the pets. it calls the function from pets and uses that information.
    public void viewPets()
    {
        int number = 1;

        foreach(Pets name in animals)
        {   
            // 
            Console.WriteLine($"{number}) {name.displayInfo()}");
            number++;
        }
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();

    }
    public void viewPets2()
    {
        int number = 1;

        foreach(Pets name in animals)
        {   
            // 
            Console.WriteLine($"{number}) {name.displayInfo()}");
            number++;
        }
    }

    public void createPet()
    {
        bool loop = true;
        while(loop)
        {
            Console.Clear();
            Console.WriteLine("---Welome to the Pet Shop!---");
            Console.WriteLine("What pet are you looking for? ");
            Console.WriteLine("    1) Tree Species\n    2) Frog Species\n    3) Bird Species\n    4) Rock Species\n");
            Console.WriteLine("Which pet would you like? ");

            string Species = Console.ReadLine();

            if(Species == "1")
            {
                Console.WriteLine("Whats the name for your new Tree Species pet? ");
                string petName = Console.ReadLine();
                string petType = "Tree";
                int petLevel = assignLevel();

                Tree tree1 = new Tree(petName, petType, petLevel, 0);
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

                Frog frog1 = new Frog(petName, petType, petLevel, 0);
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

                Bird bird1 = new Bird(petName, petType, petLevel, 0);
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

                Rock rock1 = new Rock(petName, petType, petLevel, 0);
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
    public void activitiesList()
    {
        bool loop = true;
        while (loop)
        {
            Console.Clear();
            Console.WriteLine("---Welcome to the Activities Hub---");
            Console.WriteLine("Select a Pet you would like to upgrade:");
            // Display the list of pets
            Console.WriteLine();
            viewPets2();
            Console.WriteLine("\nWhich pet would you like to upgrade? (select index or type \"quit\"): ");

            // Read user input and attempt to parse it into an integer
            int choiceIndex;
            string readThis = Console.ReadLine();
            if (readThis == "quit")
            {
                return;
            }
            if (!int.TryParse(readThis, out choiceIndex))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer index.");
                continue; // Restart the loop
            }

            // Check if the selected index is within the valid range
            if (choiceIndex < 1 || choiceIndex > animals.Count)
            {
                Console.WriteLine("Invalid index. Please enter a valid index within the range.");
                continue; // Restart the loop
            }

            // Get the selected pet (adjust index to zero-based)
            Pets selectedPet = animals[choiceIndex - 1];
            selectedPet.Level();
            
        }
    }

    public void saveFile()
    {
        Console.WriteLine("What do you want the file name to be? ");
        var txtName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(txtName))
        {
            // Append the entry to the file
            // outputFile.WriteLine(_pointsTotal);

            foreach(Pets name in animals)
            {   

            outputFile.WriteLine(name.formatInfo());

            }
        }
    }

    public void loadFile()
    {
        Console.WriteLine("What file would you like to open? ");
        var fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] Parts = line.Split("~");

            if (Parts[1] == "Tree")
            {
                Pets tree1 = new Tree(Parts[0], Parts[1], int.Parse(Parts[2]), int.Parse(Parts[3]));
                animals.Add(tree1);
            }
            else if (Parts[1] == "Frog")
            {
                Pets frog1 = new Frog(Parts[0], Parts[1], int.Parse(Parts[2]), int.Parse(Parts[3]));
                animals.Add(frog1);
            }
            else if (Parts[1] == "Bird")
            {
                Pets bird1 = new Bird(Parts[0], Parts[1], int.Parse(Parts[2]), int.Parse(Parts[3]));
                animals.Add(bird1);
            }
            else if (Parts[1] == "Rock")
            {
                Pets rock1 = new Rock(Parts[0], Parts[1], int.Parse(Parts[2]), int.Parse(Parts[3]));
                animals.Add(rock1);
            }
            else
            {
                // _pointsTotal = int.Parse(Parts[0]);
            }
        }
        Console.Clear();
    }
}