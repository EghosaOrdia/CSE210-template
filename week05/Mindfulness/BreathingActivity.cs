public class BreathingActivity : Base
{
    public BreathingActivity()
    {
        _activity = "Breathing";
    }

    public void StartActivity()
    {
        string welcome = GetWelcomeMessage(_activity);
        Console.WriteLine(welcome);

        string description = GetDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n");
        Console.WriteLine(description);

        SetDuration();
        Console.Clear();

        Console.Write("Get ready...");
        SpinnerAnimation(3000);
        Console.Clear();

        _endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < _endTime)
        {
            Console.Write("Breathe in...");
            CountDown(4);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            CountDown(6);

            Console.WriteLine("\n");
        }

        Console.WriteLine("Well done!!\n");
        SpinnerAnimation(3000);

        Console.WriteLine($"You have completed another {_duration} seconds of the {_activity} activity.");
        SpinnerAnimation(3000);
        Console.Clear();
    }
}