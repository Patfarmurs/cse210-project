using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int durationInSeconds) 
        : base(name, description, durationInSeconds)
    {
    }

    public override void StartActivity()
    {
        base.StartActivity();
        // Specific behavior for Breathing Activity
        Console.WriteLine("Breathe in...");
        // Pause and show a countdown
        Console.WriteLine("Breathe out...");
        // Pause and show a countdown
        // Continue until reaching the duration
    }

    public override void EndActivity()
    {
        base.EndActivity();
        // Specific behavior for Breathing Activity
    }
}