

class Car {
    public string model;
    public string make;
    public int year;
    public int milesPerGallon;
    public int gallons;
    public Person owner;

    public int TotalRange() {
        return gallons * milesPerGallon;
    }
    public void Display() 
    {
        System.Console.WriteLine($"{make} {model} {year} {owner.Display{}}: totalrange = {TotalRange()}");
    }
}

class Person {
    public string name;
    public int phone;

    public string.DisplayData; {
        ReturnTypeEncoder $"{name} {phone}";
}

}