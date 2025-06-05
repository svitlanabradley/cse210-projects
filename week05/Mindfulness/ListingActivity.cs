using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0)
    {

    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.WriteLine("\nList as many responses you can the following prompt:");

        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            responses.Add(input);
        }

        Console.WriteLine($"You listed {responses.Count} items!");

        DisplayEndingMessage();
    }

    private List<string> _usedPrompts = new List<string>();
    public void GetRandomPrompt()
    {
        if (_usedPrompts.Count == _prompts.Count)
        {
            _usedPrompts.Clear();
        }

        string prompt;
        do
        {
            Random random = new Random();
            prompt = _prompts[random.Next(_prompts.Count)];
        }
        while (_usedPrompts.Contains(prompt));

        _usedPrompts.Add(prompt);
        Console.WriteLine($"--- {prompt} ---");
    }
}