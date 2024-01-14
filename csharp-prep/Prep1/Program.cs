using System;
using System.ComponentModel;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your first name: ");
        String name = Console.ReadLine();

        Console.WriteLine("enter your last name: ");
        String last_name = Console.ReadLine();

        Console.WriteLine($"My name is {last_name}, {name} {last_name}");

        int A = 90;
        int B = 80;
        int C = 70;
        int D = 60;


        Console.Write($"What grade did you get? ");
        String grade = Console.ReadLine();
        int number = int.Parse(grade);

        if (number >= A)
        {
            Console.WriteLine("You received an A ");
        }
        else if (number >= B)
        {
            Console.WriteLine("You recieved a B");
        }
        else if (number >= C)
        {
            Console.WriteLine("You received a C");
        }
        else if (number >= D)
        {
            Console.WriteLine("You recieved a D, you did not pass the course.");
        }
        else
        {
            Console.WriteLine("You recieved less than a 60%, you did not pass the course.");
        }
    }
}