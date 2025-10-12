public class SimpleGoal: Goal
{
    public SimpleGoal(string inputTitle, string inputDescription, int inputPoints)
    {
        title = inputTitle;
        description = inputDescription;
        points = inputPoints;
        isComplete = false;
    }
    public override void RecordEvent()
    {
        isComplete = true;
    }  
}