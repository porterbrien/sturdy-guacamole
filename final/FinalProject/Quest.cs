using System.Diagnostics;
using System.Runtime.InteropServices.Marshalling;

public class Quest{
    
    private List<Quest> Animals = new List<Quest>();

    private int[] Levels = {
        1, 2, 3
    };

    private void randomLevel()
    {
        Random Level = new Random();
    }

    public void createPet()
    {
        bool loop = false;
        while(loop)
        {
            Console.WriteLine("    ---Welome to the Pet Shop!--- ");
            Console.WriteLine("What pet are you looking for? ");
            Console.WriteLine("    1) Tree Species    2) Frog Species    3) Bird Species    4) Rock Species");
            Console.WriteLine("Which pet would you like? ");
            int Species = int.Parse(Console.ReadLine());

            if(Species == 1)
            {
                Console.WriteLine("Whats the name for your new Tree Species pet? ");
                string petName = Console.ReadLine();

                // Input randomizer what level they start off as

                loop = true;
            }
            else if (Species == 2)
            {
                Console.WriteLine("Whats the name for your new Tree Species pet? ");
                string petName = Console.ReadLine();

                // Input randomizer what level they start off as

                loop = true;
            }
            else if (Species == 3)
            {
                Console.WriteLine("Whats the name for your new Tree Species pet? ");
                string petName = Console.ReadLine();

                // Input randomizer what level they start off as

                loop = true;
            }
            else if (Species == 4)
            {
                Console.WriteLine("Whats the name for your new Tree Species pet? ");
                string petName = Console.ReadLine();

                // Input randomizer what level they start off as

                loop = true;
            }
            else
            {
                Console.WriteLine("Invalid input, please try again!");
            }
        }
    }

    public void viewPets()
    {

    }
}