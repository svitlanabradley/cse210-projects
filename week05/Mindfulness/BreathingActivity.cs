using System;
using System.Collections.Generic;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int currentTime = 0;
        while (currentTime < GetDuration())
        {
            Console.WriteLine();
            Console.Write("\nBreathe in...");
            ShowCountDown(4);
            currentTime += 4;

            if (currentTime >= GetDuration())
            {
                break;
            }

            Console.Write("\nNow breathe out...");
            ShowCountDown(6);
            currentTime += 6;
        }

        DisplayEndingMessage();
    }
}