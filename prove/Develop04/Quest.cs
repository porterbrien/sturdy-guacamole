using System.ComponentModel;
using System.Reflection.Metadata;

public class Quest{

    // Need constructor 
    // This one has the 

    private List<Goal> listOfGoals = new List<Goal>();
    public int _pointsTotal;

    public Quest(int pointsTotal)
    {

        _pointsTotal = pointsTotal;

    }

    // This is the second menu for when the user chooses 1 
    public void typesOfGoals()
    {
        Console.WriteLine($"    1. Simple Goal\n    2. Checklist Goal\n    3. Eternal Goal");
        string inputUser = Console.ReadLine();

        if (inputUser == "1")
        {
            // Goals name
            Console.WriteLine("What is the name of the Goal? ");
            string name = Console.ReadLine();

            // Description of this goal
            Console.WriteLine("What is a short description of this goal? ");
            string description = Console.ReadLine();

            // How many points the goal is worth
            Console.WriteLine("How many points is this goal worth?");
            int pointsAwarded = int.Parse(Console.ReadLine());

            Goal simple1 = new Simple(name, description, pointsAwarded, false);
            listOfGoals.Add(simple1);

            Console.Clear();
        }
        else if(inputUser == "2")
        {
            // Needs to be made
            // Goals name
            Console.WriteLine("What is the name of the Goal? ");
            string name = Console.ReadLine();

            // Description of this goal
            Console.WriteLine("What is a short description of this goal? ");
            string description = Console.ReadLine();

            // How many points the goal is worth
            Console.WriteLine("How many points is this goal worth?");
            int pointsAwarded = int.Parse(Console.ReadLine());

            // bonus points
            Console.WriteLine("How many points will be awarded when you finish this goal? ");
            int bonusPoints = int.Parse(Console.ReadLine());

            // how many to complete
            Console.WriteLine("How many times will you do this goal till it is completed? ");
            int timesToCompleted = int.Parse(Console.ReadLine());

            Goal checklist1 = new Checklist(name, description, pointsAwarded, bonusPoints, timesToCompleted, 0);
            listOfGoals.Add(checklist1);

            Console.Clear();
        }
        else if(inputUser == "3")
        {
            // Needs to be made
            // Goals name
            Console.WriteLine("What is the name of the Goal? ");
            string name = Console.ReadLine();

            // Description of this goal
            Console.WriteLine("What is a short description of this goal? ");
            string description = Console.ReadLine();

            // How many points the goal is worth
            Console.WriteLine("How many points is this goal worth?");
            int pointsAwarded = int.Parse(Console.ReadLine());

            Goal eternal1 = new Eternal(name, description, pointsAwarded);
            listOfGoals.Add(eternal1);

            Console.Clear();
        }
    }

    public void displayList()
    {
        int number = 1;

        foreach(Goal goal in listOfGoals)
        {   
            // 
            Console.WriteLine($"{number}) {goal.displayGoals()}");

            number++;
        }
    }

    public void pointsTotal()
    {
         Console.WriteLine($"You have {_pointsTotal} points.");
    }

    // Saving the file to txt doc.
    public void saveGoal()
    {
        Console.WriteLine("What do you want the file name to be? ");
        var txtName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(txtName))
        {
            // Append the entry to the file
            outputFile.WriteLine(_pointsTotal);

            foreach(Goal goal in listOfGoals)
            {   

            outputFile.WriteLine(goal.formatGoals());

            }
        }
    }

    // Loading the goals from txt file saved to the bin
    public void LoadEntry()
    {
        Console.WriteLine("What file would you like to open? ");
        var fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] Parts = line.Split("~");

            if (Parts[0] == "SimpleGoal")
            {
                Goal simple2 = new Simple(Parts[1], Parts[2], int.Parse(Parts[3]), bool.Parse(Parts[4].ToLower()));
                listOfGoals.Add(simple2);
            }
            else if (Parts[0] == "ChecklistGoal")
            {
                Goal checklist2 = new Checklist(Parts[1], Parts[2], int.Parse(Parts[3]), int.Parse(Parts[4].ToLower()), int.Parse(Parts[5]), int.Parse(Parts[6]));
                listOfGoals.Add(checklist2);
            }
            else if (Parts[0] == "EternalGoal")
            {
                Goal eternalGoal2 = new Eternal(Parts[1], Parts[2], int.Parse(Parts[3]));
                listOfGoals.Add(eternalGoal2);
            }
            else
            {
                _pointsTotal = int.Parse(Parts[0]);
            }
        }
        Console.Clear();
    }

    // This one is going to record whether the user wants to check off an item in the list.
    public void markQuest()
    {
        displayList();
        Console.WriteLine("\n\n");
        Console.WriteLine("Which event would you like to complete? ");
        int eventCompletion = int.Parse(Console.ReadLine());



        int points = listOfGoals[eventCompletion-1].recordEvent();
        _pointsTotal += points;


        Console.Clear();

    }
}