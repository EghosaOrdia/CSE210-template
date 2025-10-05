public class LisitngActivity : Base
{
    private List<string> _prompts;
    private Random _randomGenerator;
    public LisitngActivity()
    {
        _activity = "Listing";
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _randomGenerator = new Random();
    }
    public void StartActivity()
    {
        string welcome = GetWelcomeMessage(_activity);
        Console.WriteLine(welcome);

        string description = GetDescription("This activity will help you reflect on good things in your life by having you list as many things as you can in a certain area.\n");
        Console.WriteLine(description);

        SetDuration();
        Console.Clear();

        Console.Write("Get ready...");
        SpinnerAnimation(3000);

        int randomIndex = _randomGenerator.Next(_prompts.Count);
        string randonPrompt = _prompts[randomIndex];
        Console.WriteLine("List as many things as you can to the following prompts:");
        Console.WriteLine($"--- {randonPrompt} ---");
        Console.WriteLine("You may begin in: ");
        CountDown(5);

        _endTime = DateTime.Now.AddSeconds(_duration);

        List<string> items = new List<string>();
        while (DateTime.Now < _endTime)
        {
            Console.Write("> ");
            string userResponse = Console.ReadLine();
            items.Add(userResponse);
        }
        Console.WriteLine($"You listed {items.Count} items!\n");
        Console.WriteLine("Well done!!\n");
        SpinnerAnimation(3000);
    }

}