public class EternalGoal: Goal
{
    private int goalCount;
    public EternalGoal(string inputTitle, string inputDescription, int inputPoints)
    {
        title = inputTitle;
        description = inputDescription;
        points = inputPoints;
        goalCount = 0;
    }

    public int GetGoalCount()
    {
        return goalCount;
    }
}