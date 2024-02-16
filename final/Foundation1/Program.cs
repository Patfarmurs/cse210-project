using System;
using System.Collections.Generic;

class Program
{
    static void Main(string [] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Video 1", "Author 1", 120);
        video1.AddComment(new Comment("User1", "Great video!"));
        video1.AddComment(new Comment("User2", "Interesting content."));

        Video video2 = new Video("Video 2", "Author 2", 180);
        video2.AddComment(new Comment("User3", "I enjoyed watching this."));
        video2.AddComment(new Comment("User4", "Very informative."));

        videos.Add(video1);
        videos.Add(video2);

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
