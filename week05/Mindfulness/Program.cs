using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new();
        bool continueActivity = true;
        while (continueActivity)
        {
            Console.WriteLine("Hello World! This is the Mindfulness Project.");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listening activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");

            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                Console.Clear();
                breathingActivity.StartActivity();
            }
            else if (userInput == 4)
            {
                continueActivity = false;
            }
        }

    }
}