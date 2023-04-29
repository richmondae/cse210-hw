using System;
using System.Collections.Generic;

class Journal
{
    List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void DisplayJournalEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
            Console.WriteLine();
        }
    }

    public void CreateJournalEntry()
    {
        Console.Write("Enter date (MM/DD/YYYY): ");
        string date = Console.ReadLine();

        Console.Write("Enter prompt: ");
        string prompt = Console.ReadLine();

        Console.Write("Enter response: ");
        string response = Console.ReadLine();

        Entry entry = new Entry(date, prompt, response);
        entries.Add(entry);

        Console.WriteLine("Entry added to journal.");
    }

    public void SaveToCsv()
    {
        using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"journal.csv"))
        {
            foreach (Entry entry in entries)
            {
                file.WriteLine(entry.GetEntryAsCsv());
            }
        }

        Console.WriteLine("Journal saved to journal.csv");
    }

    public void LoadFromCsv()
    {
        string line;

        using (System.IO.StreamReader file = new System.IO.StreamReader(@"journal.csv"))
        {
            while ((line = file.ReadLine()) != null)
            {
                string[] values = line.Split('|');
                string date = values[0];
                string prompt = values[1];
                string response = values[2];
                Entry entry = new Entry(date, prompt, response);
                entries.Add(entry);
            }
        }

        Console.WriteLine("Journal loaded from journal.csv");
    }
}
