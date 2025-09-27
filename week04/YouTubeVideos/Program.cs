using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        List<Video> videoList = [];
        // Class Video - variables : title, author, length(in seconds), methods: stores and returns <Comments>
        // Class Comments - tracks author of comment and comment text
        // Write program that creates 4 videos, sets the appropriate values, and adds 4 comments to each video with commenter's name and text, put each video in a list
        // iterate through list, display the title, author, length, number of comments (from the method) and then list out all of the comments for th
        Video video1_python = new("Programming with mosh - Python BootCamp", "Mosh", 500);
        video1_python.AddComment("Eghosa", "Great course bro, i was able to land my dream job in just a month after finishing your course. Thanks a bunch!");
        video1_python.AddComment("Petyr", "You've done well mosh. Much appreciation.");
        video1_python.AddComment("Scott", "Thank you so much. I was able to retire my mother because of the job i got as a result of your course.");
        video1_python.AddComment("Stiles", "Thank youuuuu");
        videoList.Add(video1_python);

        Video video2_javascript = new("Complete Javascript Course", "Jonas Schmedtmann", 640);
        video2_javascript.AddComment("Sophie", "This course changed how I see code!");
        video2_javascript.AddComment("Mark", "Jonas is a wizard — 10/10 would recommend.");
        video2_javascript.AddComment("Tariq", "I'm finally understanding closures 😭");
        video2_javascript.AddComment("Becky", "Clear, concise, and actually fun!");
        videoList.Add(video2_javascript);

        Video video3 = new("10-Minute Abs Workout", "FitGuru", 600);
        video3.AddComment("Ivy", "I did this and now I can't walk.");
        video3.AddComment("Jake", "Why am I sweating and crying?");
        video3.AddComment("Kemi", "This man really said 'easy' 😭");
        video3.AddComment("Leo", "Good routine. Will suffer again tomorrow.");
        videoList.Add(video3);

        Video video4 = new("Learn C# in 10 Minutes", "CodeSensei", 600);
        video4.AddComment("Mina", "This explained more than my lecturer.");
        video4.AddComment("Nate", "I'm still confused, but now in HD.");
        video4.AddComment("Olive", "Love the pace and clarity.");
        video4.AddComment("Paul", "Where was this 3 weeks ago 😩");
        videoList.Add(video4);

        foreach (Video v in videoList)
        {
            Console.WriteLine($"Author: {v.GetAuthor()}\nTitle: {v.GetTitle()}\nVideo Length: {v.GetLength()}s\nNumber of Comments: {v.GetCommentCount()}");
            v.DisplayComments();
            Console.WriteLine();
        }
    }
}