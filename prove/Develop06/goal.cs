class goal{

    public goal(){
        _pointsAwarded = pointsAwarded
    }

    // This is the second menu for when the user chooses 1 
    public void typesOfGoals(){
        Console.WriteLine($"    1. Simple Goal\n    2.Eternal Goal\n    3. Checklist Goal");
        string inputUser = Console.ReadLine();

        if (inputUser == 1)
        {
            // Needs to be made
            simpleGoal();
        }
        else if(inputUser == 2)
        {
            // Needs to be made
            eternalGoal();
        }
        else if(inputUser == 3)
        {
            // Needs to be made
            checkListGoal();
        }
        else (!inputUser)
        {
            Console.WriteLine("That is not an option, please try again.");
        }
    }

    // This asks the user for the information about the goal they want to enter. This is the display.
    public void createGoal()
    {
        Console.WriteLine("Whats the name of this Goal? ");
        string goalName = Console.ReadLine();
        Console.WriteLine("Whats a short description of this goal? ");
        string = goalDescription = Console.ReadLine();
        Console.WriteLine("How many points is this goal worth? ");
        string goalPoints = Console.ReadLine();
    }
}