using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description})";
    }

       public abstract string ToCsvRecord();

      public static Goal FromCsvRecord(string csv)
    {
        string[] parts = csv.Split(',');

        string type = parts[0];
        string title = parts[1];
        string desc = parts[2];
        int points = int.Parse(parts[3]);

        // 0:type,1:title,2:desc,3:points,4:total_count,5:bonus,6:bonus_count,7:current_count,8:current_points,9:is_completed

        switch (type)
        {
            case "SimpleGoal":
                bool done = bool.Parse(parts[9]);
                var sg = new SimpleGoal(title, desc, points);
                if (done) sg.MarkComplete();
                return sg;

            case "EternalGoal":
                return new EternalGoal(title, desc, points);

            case "ChecklistGoal":
                int total = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                int current = int.Parse(parts[7]);
                int earned = int.Parse(parts[8]);
                var cg = new ChecklistGoal(title, desc, points, total, bonus);
                cg.SetProgress(current, earned);
                return cg;

            default:
                throw new Exception("Unknown goal type in CSV");
        }
    }
}
