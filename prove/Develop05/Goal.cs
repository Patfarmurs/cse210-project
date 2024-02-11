using System;
using System.Collections.Generic;

// Base class for all types of goals
public abstract class Goal
{
    public string _Name;
    public int Value { get; protected set; }
    public bool IsCompleted { get; protected set; }

    public abstract void RecordEvent();
}
