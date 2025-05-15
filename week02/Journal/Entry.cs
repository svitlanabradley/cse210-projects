using System;
using System.Collections.Generic;
using System.IO;

// An Entry class keeps track of the date, prompt text and text of the entry itself
public class Entry
{
    public string _date;
    public string _title;
    public string _location;
    public string _promptText;
    public string _entryText;

    // displays method that shows data saved in Entry class
    public void Display()
    {
        Console.WriteLine($"\nDate: {_date}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Location: {_location}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine ($"Entry: {_entryText}");
    }
}