using System.ComponentModel;

public class Pets
{
    public string _name;

    public Pets(string name)
    {
        _name = name;
    }

    public string displayName()
    {
        return $"{_name}";
    }

}