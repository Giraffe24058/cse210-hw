using System;
using System.Collections.Generic;
using System.IO;

public class Entry
{
    public string _dateTime;
    public string _prompt;
    public string _response;

    public Entry(string prompt, string response)
    {
        _dateTime = DateTime.Now.ToString("yyyy-MM-dd");
        _prompt = prompt;
        _response = response;
    }

    public void WriteEntry()
    {
        Console.WriteLine($"Date - {_dateTime}");
        Console.Write($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}\n");
    }

    public string FormatEntryForSaving()
    {
        return $"{_dateTime}|{_prompt}|{_response}";
    }

    public static Entry CreateEntryFromSavedData(string saved)
    {
        string[] parts = saved.Split('Ω');
        Entry entry = new Entry(parts[1], parts[2]);
        entry._dateTime = parts[0];
        return entry;
    }
}


