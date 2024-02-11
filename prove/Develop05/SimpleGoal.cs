
// Simple goal class
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value)
    {
        _Name = name;
        Value = value;
    }

    public override void RecordEvent()
    {
        IsCompleted = true;
    }
}