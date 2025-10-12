public class ChecklistGoal: Goal
{
    private int targetCount;
    private int currentCount;
    private int bonus;
    public ChecklistGoal(string inputTitle, string inputDescription, int inputPoints, int inputTargetCount, int inputBonus)
    {
        title = inputTitle;
        description = inputDescription;
        points = inputPoints;
        bonus = inputBonus;
        targetCount = inputTargetCount;
        currentCount = 0;
    }
    public int GetTargetCount()
    {
        return targetCount;
    }
    public int GetGoalBonusCount()
    {
        return targetCount;
    }
    public int GetGoalBonus()
    {
        return bonus;
    }
    public override string GetDetailsString()
    {
        return $"[] {title} -- Completed {currentCount}/{targetCount}";
    }
}