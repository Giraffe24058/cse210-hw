// See https://aka.ms/new-console-template for more information

using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    private List<Entry> _myEntries = new List<Entry>();

    public void AddNewEntry(Entry entry)
    {
        _myEntries.Add(entry);
    }

    public void ShowAllEntries()
    {
        Console.WriteLine("\nHere are all your journal entries:");
        foreach (Entry e in _myEntries)
        {
            e.WriteEntry();
        }
    }

    public void SaveJournal(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry e in _myEntries)
            {
                writer.WriteLine(e.FormatEntryForSaving());
            }
        }

        Console.WriteLine($"Saved your journal to: {fileName}");
    }

    public void LoadJournal(string fileName)
    {
        if (File.Exists(fileName))
        {
            _myEntries.Clear();
            string[] allLines = File.ReadAllLines(fileName);
            foreach (string line in allLines)
            {
                Entry loadedEntry = Entry.CreateEntryFromSavedData(line);
                _myEntries.Add(loadedEntry);
            }

            Console.WriteLine($"Loaded journal from: {fileName}");
        }
        else
        {
            Console.WriteLine($"Couldn't find a file called {fileName}");
        }
    }
}
