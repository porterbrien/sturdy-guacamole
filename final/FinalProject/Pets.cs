using System.ComponentModel;

public abstract class Pets
{
    protected string _name;
    protected string _petType;
    protected int _petLevel;
    protected int totalPoints;

    protected int[] pointsList =
        {
            7, 8, 9, 10, 11, 12, 13, 14, 15,  16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45
        };
    
    protected string[] foodList = 
    {
        "a loaf of Bread", "a Grape", "an Insect", "a Fish", "some Seeds"
    };

    public Pets(string name, string petType, int petLevel, int totalPoints)
    {
        _name = name;
        _petLevel = petLevel;
        _petType = petType;
        this.totalPoints = totalPoints;

    }

    public string displayName()
    {
        return $"{_name}";
    }

    public int UpdateTotalPoints(int points)
    {
        totalPoints += points;
        if (totalPoints >= 100)
        {
            // Increase level of pets
            // (Assuming you have a method to increase level in the Animal class)
            IncreasePetLevel();
            totalPoints -= 100; // Deduct 100 points after leveling up
        }
        return totalPoints;
    }

    private void IncreasePetLevel()
    {
        // Code to increase level of pets
        _petLevel++;
        Thread.Sleep(2500);
        Console.Clear();
        Console.WriteLine("---LEVEL UP!---");
    }
    // Teachers suggestion, come back to figure it out
    public abstract void Level();

    public abstract string displayInfo();
    public abstract string formatInfo();
    
}