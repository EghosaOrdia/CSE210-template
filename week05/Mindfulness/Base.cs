public class Base
{

    protected int _duration;
    protected DateTime _startTime;
    protected DateTime _endTime;
    protected string _activity;
    protected string GetWelcomeMessage(string activityName)
    {
        _activity = activityName;
        return $"Welcome to the {activityName} Activity.\n";
    }
    protected string GetDescription(string description)
    {
        return description;
    }

    public int GetDuration()
    {
        return _duration;
    }
    protected void SetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }
    public DateTime GetStartTime()
    {
        return _startTime;
    }

    public DateTime GetEndTime()
    {
        return _endTime;
    }

    public string GetActivity()
    {
        return _activity;
    }
    
    public void SpinnerAnimation(int duration)
    {
        string[] spinner = ["|", "/", "-", "\\"];
        int interval = 100;
        int totalTicks = duration / interval;

        for (int i = 0; i < totalTicks; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(interval);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
    }
    protected void CountDown(int duration)
    {
        for (int i = duration; i >= 1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
    }
}