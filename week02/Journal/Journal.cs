using System;
using System.Collections.Generic;

public class Journal
{
    private readonly List<string> _entries = [];

    public List<string> Prompts =
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

    public int ShowOptions()
    {
        Console.Write("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do today? ");
        string userInput = Console.ReadLine();
        if (!int.TryParse(userInput, out int option))
        {
            option = -1;
        }
        return option;
    }

    public void AddEntry(string entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.\n");
            return;
        }

        foreach (string entry in _entries)
        {
            Console.Write(entry);
        }
    }

    public void Save(string filename)
    {
        using StreamWriter writer = new(filename, append: true);
        {
            foreach (string entry in _entries)
            {
                writer.WriteLine(entry);
            }
        }
    }

    public void Load(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine($"'{filename}' does not exist.");
            return;
        }
    }
    }