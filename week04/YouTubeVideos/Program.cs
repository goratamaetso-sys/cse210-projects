using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        
        Video video = new Video ("Learning C#", "Gorata", 500);

        video.AddComment(new Comment("Bakang", "Great explanation!"));
        video.AddComment(new Comment("Boitumelo", "Enjoyable and Helpful!"));

        video.DisplayInfo();
    }
}