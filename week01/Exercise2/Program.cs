using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        string sign = "";
        if ((grade % 10) >= 7)
        {
            sign = "+";
        }
        else if ((grade % 10) < 3)
        {
            sign = "-";
        }
        else 
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine($"Congratulation! You passed the course!");
        } 
        else 
        {
            Console.WriteLine($"Sorry, next time you will do it!");
        }
    }
}