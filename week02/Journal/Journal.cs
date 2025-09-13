using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<string> _entries = [];
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
        _entries = [];
        _filename = filename;

        if (!File.Exists(_filename))
        {
            Console.WriteLine($"'{_filename}' does not exist.");
            return;
        }
        string[] lines = System.IO.File.ReadAllLines(_filename);

        foreach (string line in lines)
        {
            _entries.Add(line);
        }
    }

    public static void ShowAllSavedJournals(string extension = "*.txt")
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        string[] files = Directory.GetFiles(currentDirectory, extension);

        if (files.Length == 0)

        {
            Console.WriteLine("No journal files found in this directory.\n");
            return;
        }

          Console.WriteLine("Here are your saved journal files:\n");

        for (int i = 0; i < files.Length; i++)
        {
            string fileName = Path.GetFileName(files[i]);
            Console.WriteLine($"{i + 1}. {fileName}");
        }
        Console.WriteLine();
    } 
    }