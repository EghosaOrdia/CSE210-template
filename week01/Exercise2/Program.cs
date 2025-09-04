using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade Percentage?: ");
        float gradePercentage = float.Parse(Console.ReadLine());

        string gradeLetter = "";

        if (gradePercentage >= 90)
        {
            gradeLetter = "A";

        }
        else if (gradePercentage >= 80)
        {
            gradeLetter = "B";

        }
        else if (gradePercentage >= 70)
        {
            gradeLetter = "C";

        }
        else if (gradePercentage >= 60)
        {
            gradeLetter = "D";
        }
        else {
            gradeLetter = "F";
        }

        string sign = "";
        int firstDecimalDigit = (int)(gradePercentage % 10);
        if (firstDecimalDigit >= 7 && gradeLetter != "A" && gradeLetter != "F")
        {
            sign = "+";
        }
        else if (firstDecimalDigit <= 3 && gradeLetter != "F")
        {
            sign = "-";
        }
        gradeLetter += sign;
        Console.WriteLine($"You got a {gradeLetter}.");
        
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("You did not pass the class. Better luck next time!");
        }
    }
}