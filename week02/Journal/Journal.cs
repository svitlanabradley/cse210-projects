using System;
using System.Collections.Generic;
using System.IO;

// class Journal stores a list of Entry objects
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._title}|{entry._location}|{entry._promptText}|{entry._entryText}");
            }
        }
        Console.WriteLine($"Entries are saved to {file}.");
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        if (File.Exists(file))
        {
            string[] lines = System.IO.File.ReadAllLines(file);
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._title = parts[1];
                entry._location = parts[2];
                entry._promptText = parts[3];
                entry._entryText = parts[4];
                _entries.Add(entry);
            }
            Console.WriteLine($"Journal is loaded from {file}.");
        }
        else
        {
            Console.WriteLine("File is not found");
        }
    }
}