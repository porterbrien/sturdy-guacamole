using System.ComponentModel;

public abstract class Pets
{
    public string _name;
    public string _petType;
    public int _petLevel;

    public Pets(string name, string petType, int petLevel)
    {
        _name = name;
        _petLevel = petLevel;
        _petType = petType;
    }

    public string displayName()
    {
        return $"{_name}";
    }
    public abstract string displayInfo();
}