using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _durationInSeconds;

    public Activity(string name, string description, int durationInSeconds)
    {
        _name = name;
        _description = description;
        _durationInSeconds = durationInSeconds;
    }

    public virtual void StartActivity()
    {
        Console.WriteLine($"Starting {_name} activity...");
        Console.WriteLine(_description);
        Console.WriteLine($"Setting duration to {_durationInSeconds} seconds.");
        Console.WriteLine("Prepare to begin...");

        // Pause for several seconds with animation
        Console.WriteLine("Going to sleep for a second...");
        Thread.Sleep(1000);
        Console.WriteLine("I'm back!!");
    }

    public virtual void EndActivity()
    {
        Console.WriteLine("Good job! You have completed the activity.");
        Console.WriteLine($"You have completed the {_name} activity for {_durationInSeconds} seconds.");
        // Pause for several seconds before finishing
        Console.Write("+");
        Thread.Sleep(500);

        Console.Write("\b \b"); 
        Console.Write("-"); 
    }
}