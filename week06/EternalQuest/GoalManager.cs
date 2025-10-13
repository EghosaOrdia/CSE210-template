using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine($"\nYou have {_score} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals (CSV)");
            Console.WriteLine("4. Load Goals (CSV)");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordEvent(); break;
                case "6": quit = true; break;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choice: ");
        string type = Console.ReadLine();

        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int pts = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(title, desc, pts));
                break;
            case "2":
                _goals.Add(new EternalGoal(title, desc, pts));
                break;
            case "3":
                Console.Write("Target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(title, desc, pts, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid type.");
                break;
        }
    }

    private void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals yet.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record.");
            return;
        }

        Console.WriteLine("Select a goal:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        Console.Write("Choice: ");
        int idx = int.Parse(Console.ReadLine()) - 1;
        if (idx < 0 || idx >= _goals.Count)
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        int earned = _goals[idx].RecordEvent();
        _score += earned;
        Console.WriteLine($"Earned {earned} points!");
    }

    private void SaveGoals()
    {
        Console.Write("Filename (e.g., goals.csv): ");
        string filename = Console.ReadLine();

        using (var writer = new StreamWriter(filename))
        {
            writer.WriteLine("type,title,desc,points,total_count,bonus,bonus_count,current_count,current_points,is_completed");
            writer.WriteLine($"SCORE,{_score},,,,,,,,");

            foreach (var g in _goals)
            {
                writer.WriteLine(g.ToCsvRecord());
            }
        }

        Console.WriteLine("Goals saved to CSV.");
    }

    private void LoadGoals()
    {
        Console.Write("Filename to load: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();

        string[] lines = File.ReadAllLines(filename);
        bool headerSkipped = false;

        foreach (string line in lines)
        {
            if (!headerSkipped)
            {
                headerSkipped = true;
                continue;
            }

            if (line.StartsWith("SCORE"))
            {
                var parts = line.Split(',');
                _score = int.Parse(parts[1]);
                continue;
            }

            if (string.IsNullOrWhiteSpace(line)) continue;

            _goals.Add(Goal.FromCsvRecord(line));
        }

        Console.WriteLine("Goals loaded successfully.");
    }
}
