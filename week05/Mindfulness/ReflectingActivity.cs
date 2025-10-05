public class ReflectingActivity : Base
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private Random _randomGenerator;
    public ReflectingActivity()
    {
        _activity = "Reflecting";
        _randomGenerator = new Random();
    }

    public void StartActivity()
    {
        string welcome = GetWelcomeMessage(_activity);
        Console.WriteLine(welcome);

        string description = GetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n");
        Console.WriteLine(description);

        SetDuration();
        Console.Clear();

        Console.Write("Get ready...");
        SpinnerAnimation(3000);
        Console.Clear();

        _endTime = DateTime.Now.AddSeconds(_duration);

        Console.WriteLine("Consider the following prompt:\n");
        int randomIndex = _randomGenerator.Next(_prompts.Count);
        string randonPrompt = _prompts[randomIndex];
        Console.WriteLine($"--- {randonPrompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to coninue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        CountDown(4);

        Console.Clear();

        while (DateTime.Now < _endTime)
        {
            Console.Write("> How did you feel when it happened? ");
            SpinnerAnimation(10000);
            Console.WriteLine("\n");
            
            Console.Write("> What is your favourite thing about this experience? ");
            Console.WriteLine("\n");
        }

        Console.WriteLine("Well done!!\n");
        SpinnerAnimation(3000);

        Console.WriteLine($"You have completed another {_duration} seconds of the {_activity} activity.");
        SpinnerAnimation(3000);
        Console.Clear();
    }
}