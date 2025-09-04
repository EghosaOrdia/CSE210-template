using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        int number = -1;
        int sum = 0;
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("You entered 0, exiting the program.");

            }
        }
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }
        double avg = (double)sum / numbers.Count;
        int max = numbers.Max();
        int minPositive = int.MaxValue;
        foreach (var num in numbers)
        {
            if (num > 0 && num < minPositive)
            {
                minPositive = num;
            }
        }
        numbers.Sort();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");
        if (minPositive == int.MaxValue)
        {
            Console.WriteLine("There are no positive numbers.");
        }
        else
        {
            Console.WriteLine($"The smallest positive number is: {minPositive}");
        }
        Console.WriteLine("The sorted numbers are: ");
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}