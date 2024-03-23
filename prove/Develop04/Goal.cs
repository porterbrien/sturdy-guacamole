public abstract class Goal
{
    public int _pointsAwarded;
    public string _description;
    public string _name;

    // public Goal(){}
    
    public Goal(string name, string description, int pointsAwarded)
    {
        _name = name;
        _description = description;
        _pointsAwarded = pointsAwarded;

    }

    public abstract string displayGoals();
    public abstract int recordEvent();
    public abstract string formatGoals();

}