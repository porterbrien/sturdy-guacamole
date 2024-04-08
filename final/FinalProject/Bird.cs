using System.IO.Compression;

public class Bird : Pets 
{
    public Bird(string name, string petType, int petLevel, int totalPoints) : base(name, petType, petLevel, totalPoints)
    {
    }

    public override string displayInfo(){
        return $"Name: {_name}, Type: {_petType}, Level: {_petLevel}, Progress: {totalPoints}/100";
    }

    public override string formatInfo()
    {
        return $"{_name}~{_petType}~{_petLevel}~{totalPoints}";
    }

    public override void Level()
    {
    
        Random random = new Random();
        int randomPointIndex = random.Next(0, pointsList.Length);
        int assignedPoints = pointsList[randomPointIndex];
        int randomFoodIndex = random.Next(0, foodList.Length);
        string assignedFood = foodList[randomFoodIndex];
        
        UpdateTotalPoints(assignedPoints);
        bool thisLoop = true;
        while (thisLoop)
        {
            Console.WriteLine("Which activity would you like to do with your pet? ");
            Console.WriteLine("    1) Feed\n    2) Tricks\n    3) Exercise");
            string petInput = Console.ReadLine();
            switch (petInput)
            {
            case "1":
                Console.WriteLine($"You fed your pet {assignedFood}!");
                Console.WriteLine($"---Your pet gained {assignedPoints} points---");
                thisLoop = false; // Exit the loop after feeding
                break;
            case "2":
                // Handle tricks
                Console.WriteLine("Your pet struggled, but learned a new trick!");
                Console.WriteLine($"---Your pet gained {assignedPoints} points---");
                thisLoop = false;
                break;
            case "3":
                // Handle exercise
                Console.WriteLine("Your pet is looking fit!");
                Console.WriteLine($"---Your pet gained {assignedPoints} points---");
                thisLoop = false;
                break;
            default:
                Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                break;
            }
        }
    }
}