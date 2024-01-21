using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Add a bunch of numbers and enter 0 when done. ");
        List<int> words = new List<int>();
        int rightNum = 0;
        int userAnswer = -1;
        {
            while (userAnswer != rightNum)
            {
                Console.WriteLine("Enter number: ");
                string userResponse = Console.ReadLine();

                userAnswer = int.Parse(userResponse);

                if (userAnswer != 0 )
                {
                    words.Add(userAnswer);
                }
            }

        }

        int sum = 0;
        foreach (int number in words)
        {
            sum += number;
        }
        Console.WriteLine($"The sum total is {sum}");


        float average = ((float)sum) / words.Count;
        Console.WriteLine($"The average of the list is {average}");

        int max = words[0];
        foreach (int word in words)
        {
            if (word > max)
            {
                max = word;
            }
        }
        Console.WriteLine($"The max is {max}");



    }
}
//     //primitive types
//         int i;
//         string s;
//         char c; 
//         float f;
//         double d;
//         byte b;

//         // lists - new keyword
//         List<int> myInts = new List<int>();
//         var otherInts = new List<int>();

//         // add item


//         myInts.Add(10);
//         myInts.Add(3.4);
//         myInts.Add(45);

//         // iterate over items

//         foreach(var n in myInts) {
//             System.Console.WriteLine($"n = {n}");
//         }

//         // Have to return an interger because we said we would return one.
//         int Add2(int number) {
//             return number + 2;

//         }
//         // void
//         void PrintName (string name) {
//             System.Console.WriteLine(name);

//         }

//         int answer = Add2(10, "bob");
//         PrintName($"Bob is {answer}");
// }