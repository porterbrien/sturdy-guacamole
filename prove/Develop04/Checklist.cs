public class Checklist : Goal
{
    // Constructor that takes its values from this child class and inputs it into the parent class

    // Needs an is _completed 
    // Needs bonus points completion

    int _timesToCompleted;
    int _timesCompleted;
    int _bonusPoints;

    public Checklist(string name, string description, int pointsAwarded, int bonusPoints, int timesCompleted, int timesToCompleted) : base(name, description, pointsAwarded)
    {
        _timesToCompleted = timesToCompleted;
        _bonusPoints = bonusPoints;
        _timesCompleted = timesCompleted;

    }
    
    public override string displayGoals()
    {
        if (_timesCompleted != _timesToCompleted)
        {
            return $"[ ] {_name} : {_description}---{_timesCompleted}/{_timesToCompleted}";
        }
        else
        {
            return $"[X] {_name} : {_description}---{_timesCompleted}/{_timesToCompleted}";
        }
    }
    public override int recordEvent()
    {
        _timesCompleted++;

        return _pointsAwarded;
    }

    public override string formatGoals()
    {
        return $"ChecklistGoal~{_name}~{_description}~{_pointsAwarded}~{_timesCompleted}~{_timesToCompleted}~{_bonusPoints}";
    }
}