public class ChecklistGoal: Goal
{
    private int goalBonusCount;
    private int goalBonus;
    private int goalCount;
    public ChecklistGoal(string inputTitle, string inputDescription, int inputPoints, int inputGoalBonusCount, int inputGoalBonus)
    {
        title = inputTitle;
        description = inputDescription;
        points = inputPoints;
        goalCount = 0;
        goalBonusCount = inputGoalBonusCount;
        goalBonus = inputGoalBonus;
    }
    public int GetGoalCount()
    {
        return goalCount;
    }
    public int GetGoalBonusCount()
    {
        return goalBonusCount;
    }
    public int GetGoalBonus()
    {
        return goalBonus;
    }
}