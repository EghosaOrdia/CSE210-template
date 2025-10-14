using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3.0));
        activities.Add(new Cycling(new DateTime(2022, 11, 3), 30, 12.0));
        activities.Add(new Swimming(new DateTime(2022, 11, 3), 30, 40));

        foreach (Activity act in activities)
        {
            Console.WriteLine(act.GetSummary());
        }
        
    }
}