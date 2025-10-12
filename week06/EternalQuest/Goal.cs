public class Goal{
    protected int points;
    protected string title;
    protected string description;
    protected bool isComplete;

    public string GetTitle(){
        return title;
    }

    public string GetDescription(){
        return description;
    }

    public int GetPoints()
    {
        return points;
    }

    public virtual string GetDetailsString()
    {
        return $"{(isComplete ? "[x]" : "[]")} {title}";
    }
    public bool IsComplete()
    {
        return isComplete;
    }

    public virtual void RecordEvent(){}
}