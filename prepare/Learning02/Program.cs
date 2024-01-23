using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        // first "Car" is our class name. it needs to be uper-case. second "car" can be named anything except the class that we put it in. (Change to model or make of car). 

        // new variable. To create an instance of a car. you have to use new.
        int count = 23;
        var cars = new List<Car>();


        Car car = new Car();
        car.model = "Honda";
        car.make = "Civic";
        car.gallons = 10;
        car.milesPerGallon = 30;

        var owner = new Person();
        owner.name = "bob";
        owner.phone = 333-3333;
        car.owner = owner;

        cars.Add(car);

        foreach (var c in cars)
        {
            // System.Console.WriteLine($"{c.make} {c.model}: totalrange = {c.TotalRange()}");
            c.Display();
        }
        
        owner = new Person();
        owner.name = "sue";
        owner.phone = 444-4444;
        car.owner = owner;
        
        // var cars = new List<string>();
        // var models = new List<string>();

        // var make1 = "Honda";
        // var model1 = "Civic";

        // var make2 = "Ford";
        // var model2 = "F-150";

        // Cannot do it this way, too many variables.
    }
}


// to create a class, we make the class variable, and then declare it. Use uper-case. abstraction means that we are creating a class. 

// You can create your own data type. Boolean, string, int, (Car)