using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

public class Simple : Goal
{
    // Constructor that takes its values from this child class and inputs it into the parent class

    // Needs an is _completed 
    bool _completion;

    public Simple(string name, string description, int pointsAwarded, bool completion) : base(name, description, pointsAwarded)
    {
        _completion = completion;
    }

    public override string displayGoals()
    {
        if (!_completion)
        {
            return $"[ ] {_name} : {_description}";
        }
        else
        {
            return $"[X] {_name} : {_description}";
        }
    }
    
    public override int recordEvent()
    {
        _completion = true;
        
        return _pointsAwarded;
    }
    
    public override string formatGoals()
    {
        return $"SimpleGoal~{_name}~{_description}~{_pointsAwarded}~{_completion}";
    }
}