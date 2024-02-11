// Checklist goal class
public class ChecklistGoal : Goal
{
    private int timesCompleted;
    private int totalTimes;

    public ChecklistGoal(string name, int value, int totalTimes)
    {
        _Name = name;
        Value = value;
        this.totalTimes = totalTimes;
    }

    public override void RecordEvent()
    {
        timesCompleted++;
        if (timesCompleted == totalTimes)
        {
            IsCompleted = true;
        }
    }
}
