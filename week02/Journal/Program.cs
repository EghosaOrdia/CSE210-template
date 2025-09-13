using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        var journal = new Journal();
        DateTime theCurrentTime = DateTime.Now;
        string DateText = theCurrentTime.ToShortDateString();
        int option = -1;
        Random rnd = new();

        while (option != 5)
        {
            int userOption = journal.ShowOptions();

            int idx = rnd.Next(journal.Prompts.Count);
            string randomPrompt = journal.Prompts[idx];
            if (userOption == 1)
            {
                Console.Write(randomPrompt + "\n> ");
                string response = Console.ReadLine();
                string entry = $"Date: {DateText} - Prompt: {randomPrompt}\n{response}";
                journal.AddEntry(entry);
            }
            else if (userOption == 2)
            {
                journal.DisplayEntries();
            }
            else if (userOption == 3)
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
            }
            else if (userOption == 4)
            {
                Console.WriteLine("What is the filename? (include.txt as extension) ");
                string filename = Console.ReadLine();
                journal.Save(filename);
            }
        }
    }
}