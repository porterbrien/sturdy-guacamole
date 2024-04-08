using System.Diagnostics.Tracing;

public class Points
{
    public int TotalPoints;

    // Constructor to initialize TotalPoints
    public Points()
    {
        TotalPoints = 0;
    }

    // // Method to update TotalPoints and check for level up
    // public int UpdateTotalPoints(int _assignedPoints)
    // {
    //     TotalPoints += _assignedPoints;
    //     if (TotalPoints >= 100)
    //     {
    //         // Increase level of pets
    //         // (Assuming you have a method to increase level in the Animal class)
    //         IncreasePetLevel();
    //         TotalPoints -= 100; // Deduct 100 points after leveling up
    //     }
    //     return TotalPoints;
}

    // // Method to increase level of pets
    // private void IncreasePetLevel()
    // {
    //     // Code to increase level of pets

    //     Console.WriteLine("Level up!");

    // }
