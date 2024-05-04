using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<JournalEntry> Entries { get; private set; } = new List<JournalEntry>();

    public void AddEntry(JournalEntry entry)
    {
        Entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (JournalEntry entry in Entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveJournal(string filename)
    {
        List<string> lines = new List<string>();
        foreach (JournalEntry entry in Entries)
        {
            lines.Add(entry.ToString());
        }
        File.WriteAllLines(filename, lines);
    }

    public void LoadJournal(string filename)
    {
        Entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                JournalEntry entry = new JournalEntry(parts[1], parts[2], parts[0]);
                Entries.Add(entry);
            }
        }
    }
}
