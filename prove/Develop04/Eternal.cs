using System.ComponentModel.DataAnnotations;

public class Eternal : Goal
{
    // Constructor that takes its values from this child class and inputs it into the parent class

    public Eternal(string name, string description, int pointsAwarded) : base (name, description, pointsAwarded)
    { 

    }

    public override string displayGoals()
    {
        {
            return $"[ ] {_name} : {_description}";
        }
    }
    public override int recordEvent()
    {
       return _pointsAwarded;
    }

    public override string formatGoals()
    {
       return $"EternalGoal~{_name}~{_description}~{_pointsAwarded}";
    }
}