using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private int _currentPoints;

    public ChecklistGoal(string name, string desc, int points, int target, int bonus)
        : base(name, desc, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
        _currentPoints = 0;
    }

    public override int RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            _currentPoints += _points;
            int earned = _points;

            if (_amountCompleted == _target)
            {
                earned += _bonus;
                _currentPoints += _bonus;
            }

            return earned;
        }
        return 0;
    }

    public void SetProgress(int completed, int earnedPoints)
    {
        _amountCompleted = completed;
        _currentPoints = earnedPoints;
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description}) — {_amountCompleted}/{_target}";
    }

    public override string ToCsvRecord()
    {
        return $"ChecklistGoal,{_shortName},{_description},{_points},{_target},{_bonus},{_bonus},{_amountCompleted},{_currentPoints},{IsComplete()}";
    }
}
