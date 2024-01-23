using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();

    public void AddEntry(string prompt, string response, DateTime date)
    {
        JournalEntry entry = new ConcreteJournalEntry { Prompt = prompt, Response = response, Date = date };
        entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile(string fileName)
    {
        // Code to save journal to file
    }

    public void LoadFromFile(string fileName)
    {
        // Code to load journal from file
    }
}
