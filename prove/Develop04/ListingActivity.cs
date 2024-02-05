using System;

public class ListingActivity : Activity
{
    public ListingActivity(string name, string description, int durationInSeconds) 
        : base(name, description, durationInSeconds)
    {
    }

    public override void StartActivity()
    {
        base.StartActivity();
        // Specific behavior for Listing Activity
        Console.WriteLine("Think of a time when you stood up for someone else.");
        // Pause and show a spinner animation
        // Ask the user to reflect on questions with pauses and spinner animation
    }

    public override void EndActivity()
    {
        base.EndActivity();
        // Specific behavior for Listing Activity
    }
}