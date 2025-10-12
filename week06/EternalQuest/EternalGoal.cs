public class EternalGoal: Goal
{
    private int currentCount;
    public EternalGoal(string inputTitle, string inputDescription, int inputPoints)
    {
        title = inputTitle;
        description = inputDescription;
        points = inputPoints;
        currentCount = 0;
    }

    public int GetGoalCount()
    {
        return currentCount;
    }

    public override string GetDetailsString()
    {
        return $"[] {title} -- Completed {currentCount}";
    }
}