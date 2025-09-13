using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        var journal = new Journal();
        var promptGenerator = new PromptGenerator();
        bool exit = false;

        while (exit == false)
        {
            Console.Write("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do today? ");
            string userResponse = Console.ReadLine();
            int userInput = int.Parse(userResponse);
            string randomPrompt = promptGenerator.GetRandomPrompt();

            // Write
            if (userInput == 1)
            {
                Console.Write(randomPrompt + "\n> ");
                string response = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                string DateText = theCurrentTime.ToShortDateString();
                string entry = $"Date: {DateText} - Prompt: {randomPrompt}\n{response}";
                journal.AddEntry(entry);
            }
            // Display
            else if (userInput == 2)
            {
                journal.DisplayEntries();
            }
            // Load
            else if (userInput == 3)
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                journal.Load(filename);
            }
            // Save
            else if (userInput == 4)
            {
                Console.WriteLine("What is the filename? (include.txt as extension) ");
                string filename = Console.ReadLine();
                journal.Save(filename);
            }
            // Quit
            else if (userInput == 5)
            {
                exit = true;
            }
        }
    }
}