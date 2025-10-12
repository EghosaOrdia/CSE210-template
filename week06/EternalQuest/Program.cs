using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager goalManager = new GoalManager();
        while (true)
        {
            Console.WriteLine($"You have {goalManager.GetTotalPoints()} points\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create new Goals");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");


            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                goalManager.CreateGoal();
            } else if (userInput == 2)
            {
                goalManager.FetchGoals();
            } else if (userInput == 6)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid Option. Please enter an option from the menu");
            }
        }
    }
}