public class LisitngActivity : Base
{
    private List<string> _prompts;
    private Random _randomGenerator;
    public LisitngActivity()
    {
        _activity = "Listing";
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
        Console.Clear();

        _endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < _endTime)
        {
            Console.WriteLine("List as many things as you can to the following prompts:");
        }

    }

}