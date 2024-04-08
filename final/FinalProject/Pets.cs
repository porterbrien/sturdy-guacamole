using System.ComponentModel;

public abstract class Pets
{
    public string _name;
    public string _petType;
    public int _petLevel;
    public int _assignedPoints;

    public Pets(string name, string petType, int petLevel, int assignedPoints)
    {
        _name = name;
        _petLevel = petLevel;
        _petType = petType;
        _assignedPoints = assignedPoints;  
    }

    public string displayName()
    {
        return $"{_name}";
    }
    public abstract string displayInfo();
}