using System;

class Program
{
    static int Add2(int number, string name)
    {
        Console.WriteLine("Hello Learning04 World!");
    }


    //primitive types
        int i;
        string s;
        char c; 
        float f;
        double d;
        byte b;

        // lists - new keyword
        List<int> myInts = new List<int>();
        var otherInts = new List<int>();

        // add item


        myInts.Add(10);
        myInts.Add(3.4);
        myInts.Add(45);

        // iterate over items

        foreach(var n in myInts) {
            System.Console.WriteLine($"n = {n}");
        }

        // Have to return an interger because we said we would return one.
        int Add2(int number) {
            return number + 2;

        }
        // void
        void PrintName (string name) {
            System.Console.WriteLine(name);

        }

        int answer = Add2(10, "bob");
        PrintName($"Bob is {answer}");
}