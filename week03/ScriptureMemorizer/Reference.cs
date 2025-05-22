using System;
using System.Collections.Generic;

// Keeps track of the book, chapter, and verse information.
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse;  // 'int?' means that the variable can either hold an 'int' value or be 'null' (no value)

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        // return reference with end verse ("Proverbs 3:5-6"), otherwise as a single verse ("Proverbs 3:5")
        return _endVerse.HasValue ? $"{_book} {_chapter}:{_verse}-{_endVerse}" : $"{_book} {_chapter}:{_verse}";
    }
}