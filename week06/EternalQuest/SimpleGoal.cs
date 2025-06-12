using System;
using System.Collections.Generic;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    
    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool isComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string check = isComplete() ? "[X]" : "[ ]";
        return $" {check} {GetName()} ({GetDescription()})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetName()},{GetDescription()},{GetPoints()},{_isComplete}";
    }
}