using System;
using System.Collections.Generic;
using System.IO;


public class PromptGenerator
{
    // Define a list of prompts
    List<string> _prompts = new List<string>
    {
        "Who was the most interesting person you interacted with today?",
        "What was the best part of your day?",
        "How did you see the hand of the Lord in your life today?",
        "What was the strongest emotion you felt today?",
        "If you had one thing you could do over today, what would it be?",
        "What made you smile today?",
        "What is one thing you are grateful for?",
        "What would you like to improve tomorrow?"
    };

    // Pick a random prompt
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}