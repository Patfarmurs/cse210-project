using System;
using System.Collections.Generic;
using System.IO;

// Abstract class for journal entry
public abstract class JournalEntry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }
    
    // Abstract method to display entry details
    public abstract void DisplayEntry();
}

// Concrete class for journal entry
public class ConcreteJournalEntry : JournalEntry
{
    public override void DisplayEntry()
    {
        Console.WriteLine($"Date: {Date}, Prompt: {Prompt}, Response: {Response}");
    }
}
