public class Goal{
    protected int points;
    protected string title;
    protected string description;

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
        return $"[] {title}";
    }
}