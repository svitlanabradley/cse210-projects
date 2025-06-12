using System;
using System.Collections.Generic;

public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Ohhh! Noooo! You lost {GetPoints()} points for: {GetName()}");
    }

    public override bool isComplete() => false;
    

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{GetName()},{GetDescription()},{GetPoints()}";
    }

    public override string GetDetailsString()
    {
        return $" [!] {GetName()} ({GetDescription()}) - Penalty goal";
    }
}