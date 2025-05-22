using System;
using System.Collections.Generic;
using System.IO;

public class ScriptureLoader
{
    public List<Scripture> LoadFromFile(string file)
    {
        List<Scripture> scriptures = new List<Scripture>();
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string book = parts[0];
            int chapter = int.Parse(parts[1]);
            int verse = int.Parse(parts[2]);
            string endVerse = parts[3];
            string text = parts[4];

            Reference reference = string.IsNullOrWhiteSpace(endVerse)
                ? new Reference(book, chapter, verse)
                : new Reference(book, chapter, verse, int.Parse(endVerse));

            scriptures.Add(new Scripture(reference, text));
        }

        return scriptures;
    }
}