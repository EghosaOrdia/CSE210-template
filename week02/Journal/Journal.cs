using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private readonly List<string> _entries = [];
    private string _filename = "";
    
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
            Console.WriteLine(entry);
            Console.WriteLine("-----");
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
        _filename = filename;

        if (!File.Exists(_filename))
        {
            Console.WriteLine($"'{_filename}' does not exist.");
            return;
        }
        string[] lines = System.IO.File.ReadAllLines(_filename);

        foreach (string line in lines) {
            _entries.Add(line);
        }
    }
    }