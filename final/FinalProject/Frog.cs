class Frog : Pets
{
    public Frog(string name, string petType, int petLevel) : base(name, petType, petLevel)
    {
        _name = name;
        _petType = petType;
        _petLevel = petLevel;
    }

    public override string displayInfo(){
        return $"Name: {_name}, Type: {_petType}, Level: {_petLevel}";
    }

    // public string displayName()
    // {
    //     return $"{_name}";
    // }
}