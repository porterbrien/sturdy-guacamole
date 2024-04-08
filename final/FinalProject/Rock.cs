class Rock : Pets
{
    public Rock(string name, string petType, int petLevel, int assignedPoints) : base(name, petType, petLevel, assignedPoints)
    {
        _name = name;
        _petType = petType;
        _petLevel = petLevel;
        _assignedPoints = assignedPoints;
    }

    public override string displayInfo()
    {

        return $"Name: {_name}, Type: {_petType} Level: {_petLevel} Progress: {_assignedPoints}/100";
    }
}