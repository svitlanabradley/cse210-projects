using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0)
    {

    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.ReadLine();

        Console.Write("Now ponder on each of the following questions as they related to this experience.\nYou may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }

    private List<string> _usedPrompts = new List<string>();
    public string GetRandomPrompt()
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
        return prompt;
    }

    private List<string> _usedQuestions = new List<string>();
    public string GetRandomQuestion()
    {
        if (_usedQuestions.Count == _questions.Count)
        {
            _usedQuestions.Clear();
        }

        string question;
        do
        {
            Random random = new Random();
            question = _questions[random.Next(_questions.Count)];
        }
        while (_usedQuestions.Contains(question));

        _usedQuestions.Add(question);
        return question;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue");
    }

    public void DisplayQuestion()
    {
        Console.Write($"\n> {GetRandomQuestion()} ");
    }

}