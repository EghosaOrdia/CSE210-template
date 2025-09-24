// Wrote and implemented the Scripture generator class which generates a random scripture from a predefined list 
using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureGenerator scriptureGenerator = new();
        Reference reference = scriptureGenerator.GetScriptureReference();
        string text = scriptureGenerator.GetScriptureText();

        Scripture scripture = new(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("\nPress Enter to hide words or type \"quit\" to exit.");
            string input = Console.ReadLine();
            if (input != null && input.Trim().ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWords(3);
        }

        // Final display (all hidden or quitting)
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nGoodbye.");
    }
}