class goal{

    public goal(){
        _pointsAwarded = pointsAwarded
    }
    public void typesOfGoals(){
        Console.WriteLine($"1. Simple Goal\n2.Eternal Goal\n3. Checklist Goal");
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
        else (!inputUser){
            Console.WriteLine("That is not an option, please try again.");
        }
    }
}