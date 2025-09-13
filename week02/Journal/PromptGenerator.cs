public class PromptGenerator
{
    private readonly Random _rnd = new();
    private readonly List<string> _prompts =
    [
        "Who was the most interesting person I interacted with today?",
        "How did I see the hand of the Lord in my life today?",
        "If I had one thing I could do over today, what would it be?",
        "What are three things you're grateful for today?",
        "Describe your mood in one word and explain why.",
        "What was the highlight of your day?",
        "What's something you learned today?",
        "Write about someone who made you smile today.",
        "What do you wish you handled differently today?",
        "What's a small win you had today?",
        "If today were a chapter in your life story, what would its title be?",
        "What's one thing you're looking forward to?",
        "What's one thing you wish you could let go of?",
        "What was something that challenged you today?",
        "If you could relive one moment from today, which would it be and why?",
        "What habits are serving you well lately?",
        "What are you currently avoiding that you need to face?",
        "Who or what inspired you today?",
        "What's something you regret not doing today?",
        "What's a quote or phrase that describes your current mindset?",
        "How did you show kindness today?",
        "What's a dream you've been ignoring?",
        "Write a short letter to your future self.",
        "What's been on your mind all day?",
        "What would you tell your younger self today?",
        "What fear did you push through today (or wish you had)?",
        "What's something you'd like to improve about yourself?",
        "How do you define success today?",
        "What do you need more of in your life right now?",
        "Write about a moment today when you felt truly present.",
        "What are you avoiding and why?",
        "What's one area of your life that needs more attention?",
        "How would you describe today to a stranger?",
        "What emotion dominated your day, and what triggered it?"
    ];

    public string GetRandomPrompt()
    {
        int idx = _rnd.Next(_prompts.Count);
        return _prompts[idx];
   }
}