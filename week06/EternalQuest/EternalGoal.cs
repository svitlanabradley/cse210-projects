using System;
using System.Collections.Generic;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent() { }

    public override bool isComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetName()},{GetDescription()},{GetPoints()}";
    }

    public override string GetDetailsString()
    {
        return $" [∞] {GetName()} ({GetDescription()})";
    }
}