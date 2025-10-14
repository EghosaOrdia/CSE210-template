using System;
using System.Collections.Generic;
using System.Globalization;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime Date
    {
        get { return _date; }
    }

    public int Minutes
    {
        get { return _minutes; }
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        string dateStr = _date.ToString("dd MMM yyyy", CultureInfo.InvariantCulture);
        string activityName = this.GetType().Name;
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();
        string unit = "miles";
        string speedUnit = "mph";
        string paceUnit = "min per mile";

        return $"{dateStr} {activityName} ({_minutes} min) – Distance {distance:F1} {unit}, Speed {speed:F1} {speedUnit}, Pace: {pace:F1} {paceUnit}";
    }
}
