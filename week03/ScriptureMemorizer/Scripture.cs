using System;
using System.Collections.Generic;
using System.Linq; // For LINQ usage like .Where() and .OrderBy()

// Keeps track of both the reference and the text of the scripture. Can hide words and get the rendered display of the text.
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach (string word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        // this way of coding I knew with the help of ChatGpt. I didn't just copy and paste. I tryed to learn the logic and sintaxis.
        foreach (var word in _words.Where(w => !w.IsHidden()).OrderBy(_ => _random.Next()).Take(numberToHide))
        {
            if (!word.IsHidden())
            {
                word.Hide(); // hide random words
            }
        }
    }

    // Get the display text as a string. The "display text" refers to the text with some words shown normally, and some replaced by underscores.
    public string GetDisplayText()
    {
        List<string> displayWords = new List<String>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }
        return $"{_reference.GetDisplayText()}\n{string.Join(" ", displayWords)}";


    }

    // Check if the scripture is completely hidden so that you know when to end the program.
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }



}