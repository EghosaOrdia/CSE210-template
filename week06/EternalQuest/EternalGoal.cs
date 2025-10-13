using System;

public class EternalGoal : Goal
{
    private int _totalEarned;

    public EternalGoal(string name, string desc, int points)
        : base(name, desc, points)
    {
        _totalEarned = 0;
    }

    public override int RecordEvent()
    {
        _totalEarned += _points;
        return _points;
    }

    public override bool IsComplete() => false;

    public override string ToCsvRecord()
    {
        return $"EternalGoal,{_shortName},{_description},{_points},0,0,0,0,{_totalEarned},false";
    }
}
