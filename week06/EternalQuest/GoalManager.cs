using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string choice = "";
        while (choice != "6")
        {
            Console.WriteLine();
            Console.WriteLine($"You have {_score} points");
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();
            if (choice == "1") {CreateGoal();}

            else if (choice == "2") {ListGoalDetails();}

            else if (choice == "3") {SaveGoals();}

            else if (choice == "4") {LoadGoals();}

            else if (choice == "5") {RecordEvent();}

            else if (choice == "6")
            {
                Console.WriteLine("Goodbye!");
            }

            else
            {
                Console.WriteLine("Wrong choice");
            }
        }

    }

    public void DisplayPlayerInfo()
    {

    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($" {i + 1}. {_goals[i].GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goal are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.WriteLine("  4. Negative Goal");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }

        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }

        else if (type == "3")
        {
            Console.Write("How many times does this goal need to be accomplishd for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }

        else if (type == "4")
        {
            _goals.Add(new NegativeGoal(name, description, points));
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        
        int i = int.Parse(Console.ReadLine()) - 1;
        Goal goal = _goals[i];
        goal.RecordEvent();

        if (goal is NegativeGoal)
        {
            _score -= goal.GetPoints();
        }
        else
        {
            _score += goal.GetPoints();

            if (goal is ChecklistGoal checklist && checklist.isComplete())
            {
                int bonus = checklist.GetBonus();
                _score += bonus;
                Console.WriteLine($"Congratulations! You have earned {goal.GetPoints() + bonus} points.");
            }
        }
        
        Console.WriteLine($"You now have {_score} points");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string file = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines("goals.txt");
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string type = parts[0];
            string[] data = parts[1].Split(",");

            if (type == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                if (bool.Parse(data[3]))
                {
                    simpleGoal.RecordEvent();
                }

                _goals.Add(simpleGoal);
            }

            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
            }

            else if (type == "ChecklistGoal")
            {
                ChecklistGoal goal = new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[4]), int.Parse(data[3]));
                for (int j = 0; j < int.Parse(data[5]); j++) goal.RecordEvent();
                _goals.Add(goal);
            }

            else if (type == "NegativeGoal")
            {
                _goals.Add(new NegativeGoal(data[0], data[1], int.Parse(data[2])));
            }
        }
    }
}