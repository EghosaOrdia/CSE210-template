using System;
// Exceeding creativity: Used CSV for saving instead of .txt file
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
       
    }
}