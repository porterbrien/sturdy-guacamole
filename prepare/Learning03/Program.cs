using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
    }
}

// Ask for random number 


Random randomGenerator = new Random();
int number = randomGenerator.Next(1, 11);

int random = 4;
int guess;
do {

// Ask for user guess
    System.Console.Write("What is your guess? ");
    guess = int.Parse(Console.ReadLine());

    // check if guess is higher
    if (guess > random) {
        System.Console.WriteLine("too high");
    }

    // Check if guess is lower
    else if (guess< random) {
        System.Console.WriteLine("Too Low");
    }

    // Check if guess is match
    else 
    {
        System.Console.WriteLine("Correct");
    }
} while (random != guess);
// keep going...