using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 50);
        int guess = -1;
        int guestCount = 0;
        string isPlaying = "y";
        while (isPlaying == "y" && isPlaying != "n")
        {
            Console.Write("What is your guess? (1-50) ");
            guess = int.Parse(Console.ReadLine());

            if (guess == magicNumber)
            {
                Console.WriteLine($"Congrats! You guessed the magic number in {guestCount} tries!");
                Console.Write("Would you like to play again? (y/n) ");
                isPlaying = Console.ReadLine().ToLower();

                if (isPlaying == "y")
                {
                    magicNumber = randomGenerator.Next(1, 50);
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                }
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
                guestCount++;
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
                guestCount++;
            }
        }    
    }
}