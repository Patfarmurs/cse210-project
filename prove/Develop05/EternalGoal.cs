// Eternal goal class
public class EternalGoal : Goal
{
    public EternalGoal(string name, int value)
    {
        _Name = name;
        Value = value;
    }

    public override void RecordEvent()
    {
        // For eternal goals, user gains value each time it's recorded
    }
}