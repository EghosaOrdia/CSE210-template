using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new("Proverbs", 1, 1);
        bool quit = false;

        while (!quit)
        {
            Console.WriteLine(reference.GetDisplayText());
            Console.WriteLine(reference.GetScriptureText());

            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string userResponse = Console.ReadLine().ToLower();

            if (userResponse == "quit")
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("Enter scripture(Proverbs, Genesis, Psalms, Revelations) eg. Proverbs: ");
                string book = Console.ReadLine();
                Console.WriteLine("Enter chapter(only chapter 1 available): ");
                int chapter = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter start verse(only verses 1-6 available): ");
                int verse = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter end verse(only verses 1-6 available): ");
                int endVerse = int.Parse(Console.ReadLine());
                reference = new Reference(book, chapter, verse, endVerse);
            }
        }
    }
}