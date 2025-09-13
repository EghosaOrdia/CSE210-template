using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job Job1 = new()
        {
            _company = "Microsoft",
            _jobTitle = "Senior Software Engineer",
            _startYear = 2025,
            _endYear = 2030
        };

        Job Job2 = new()
        {
            _company = "Meta",
            _jobTitle = "Tech Lead",
            _startYear = 2030,
            _endYear = 2035,
        };

        Job1.DisplayJobDetails();
    }
}