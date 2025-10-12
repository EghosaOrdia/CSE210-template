public class GoalManager
{
    private List<Goal> goals;
    private int totalPoints;

    public GoalManager(){
        goals = new List<Goal>();
        totalPoints = 0;
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int userInput = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string title = Console.ReadLine();

        Console.Write("What is a short description for it? ");
        string description = Console.ReadLine();

        Console.Write("What is the number of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (userInput == 1)
        {
            Goal newSimpleGoal = new SimpleGoal(title, description, points);
            goals.Add(newSimpleGoal);
        }
        else if (userInput == 2)
        {
            Goal newEternalGoal = new EternalGoal(title, description, points);
            goals.Add(newEternalGoal);
        }
        else if (userInput == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int bonusCount = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for completing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            Goal newChecklistGoal = new ChecklistGoal(title, description, points, bonusCount, bonus);
            goals.Add(newChecklistGoal);
        }
    }

    public void ListGoalDetails()
    {
        // goals.ForEach(goal => Console.WriteLine(goal.GetTitle()));
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetDetailsString()}");
        }
    }

    public int GetTotalPoints()
    {
        return totalPoints;
    }
}