using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string desc, int points)
        : base(name, desc, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public void MarkComplete()
    {
        _isComplete = true;
    }

    public override bool IsComplete() => _isComplete;

    public override string ToCsvRecord()
    {
        // type,title,desc,points,total_count,bonus,bonus_count,current_count,current_points,is_completed
        return $"SimpleGoal,{_shortName},{_description},{_points},0,0,0,0,{(_isComplete ? _points : 0)},{_isComplete}";
    }
}
