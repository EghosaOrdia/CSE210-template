public class ReflectingActivity : Base
{
    private List<string> _prompts;
    private List<string> _reflections;
    private Random _randomGenerator;
    public ReflectingActivity()
    {
        _activity = "Reflecting";
        _prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };
        _reflections = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other sit,uations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };
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


        int totalDuration = _duration * 1000;
        double timePerQuestion = totalDuration / 2;

        _endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < _endTime && _reflections.Count > 0)
        {
            int randomReflectionIndex = _randomGenerator.Next(_reflections.Count);
            string randomReflection = _reflections[randomReflectionIndex];
            _reflections.RemoveAt(randomReflectionIndex);
            Console.Write($"> {randomReflection} ");
            SpinnerAnimation((int) timePerQuestion);
            Console.WriteLine();
        }

        Console.WriteLine("Well done!!\n");
        SpinnerAnimation(3000);

        Console.WriteLine($"You have completed another {_duration} seconds of the {_activity} activity.");
        SpinnerAnimation(3000);
        Console.Clear();
    }
}