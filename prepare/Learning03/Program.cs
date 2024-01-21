using System;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        // This is the while loop that I was practicing, It counts the numbers by one untill it reaches to 5 and then it turns off.
        // This is the first count
        // int count1 = 0;
        // while (count1 < 5)
        // {
        //     Console.WriteLine($"First loop count is {count1}");
        //     count1++;
        // }

        // This is the Do-while loop that I was practicing, it doesnt have a break in the code. The Do-while loop will always run once, then it will look at the condition and decide if it needs to run again.
        // string menu1 = "Menu";
        // do
        // {
        //     Console.WriteLine($"I want to see the menu.");
        // }
        // while (menu1 == "Menu" );

        // This is my For loop practice. For loops are considered the opposite of a while loop and will only run a finite amount of times. One of the things that I was doing wrong was putting my semicolon after my for loop parenthaseis. This code counts by 1 till it reaches 20.
        // for (int i = 0; i < 20; i+=1)
        // {
        //     Console.WriteLine(i);
        // }

        // Random Numbers. One question that I have for this one is how do I make it print a plethora of random numbers?
        // Random randomgenerator = new Random();
        // int number = randomgenerator.Next(1,11);

        // Console.WriteLine($"{number}");
        Random randomNumber = new Random();
        int number = randomNumber.Next(1,11);

        bool correctGuess = false;

        string question1 = "Whats the magic number? ";
        Console.WriteLine($"{question1}");

        while (!correctGuess)
        {
            Console.WriteLine("Enter a number: ");
            int guess1 = Convert.ToInt32(Console.ReadLine());

            if (guess1 > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess1 < number)
            {
                Console.WriteLine("Higher");
            }   
            else if(guess1 == number)
            {
                Console.WriteLine("Thats correct!");
                correctGuess = true;
            }  
            else
            {
                Console.WriteLine("Invalid answer, try again.");
            }    


        }
        Console.ReadKey();
    }
}
